using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CubeLib;

namespace AssetBrowser
{
    public partial class MainForm : Form
    {
        AssetDatabase currentDb;
        DataFile currentFile;
        int files = 0;


        public MainForm()
        {
            InitializeComponent();
            
        }


        void PopulateAssetRoot(DataFile file)
        {
            UnloadAssetRoot();

            currentFile = file;
            currentDb = new AssetDatabase(file.FilePath);

            using (new ScopedListViewUpdate(assetListView))
            {
                foreach (var asset in currentDb.GetAssets())
                {
                    var lvi = new ListViewItem
                    {
                        Text = asset.FileName,
                    };
                    lvi.Tag = asset;

                    lvi.SubItems.Add(BytesToString(asset.Size));

                    assetListView.Items.Add(lvi);
                }
            }
        }
        void UnloadAssetRoot()
        {
            if (currentDb != null)
            {
                currentDb.Dispose();
                currentDb = null;
            }

            currentFile = null;

            assetListView.Items.Clear();
        }

        //Open new data folder
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data1ToolStripMenuItem.Enabled = false;
            data2ToolStripMenuItem.Enabled = false;
            data3ToolStripMenuItem.Enabled = false;
            data4ToolStripMenuItem.Enabled = false;
            dataFileListBox.Items.Clear();

            var guessedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Cube World");
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Select your data folder path",

                ShowNewFolderButton = false,
                SelectedPath = guessedPath,
            };

            var result = fbd.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            var path = fbd.SelectedPath;

            var dirInfo = new DirectoryInfo(path);
            foreach (var fileInfo in dirInfo.EnumerateFiles("*.db", SearchOption.TopDirectoryOnly))
            {
                var dataFile = new DataFile
                {
                    FilePath = fileInfo.FullName,
                };

                dataFileListBox.Items.Add(dataFile);
            }
            foreach (var item in dataFileListBox.Items)
            {
                if (item.ToString() == "data1")
                {
                    data1ToolStripMenuItem.Enabled = true;
                }
                else if (item.ToString() == "data2")
                {
                    data2ToolStripMenuItem.Enabled = true;
                }
                else if (item.ToString() == "data3")
                {
                    data3ToolStripMenuItem.Enabled = true;
                }
                else if (item.ToString() == "data4")
                {
                    data4ToolStripMenuItem.Enabled = true;
                }
            }

            // display our controls
            tabControl1.Visible = true;
            selectToolStripMenuItem.Visible = true;
        }

        //Read selected data
        private void dataFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            assetListView.Items.Clear();
            var file = dataFileListBox.SelectedItem as DataFile;

            if (file == null)
            {
                UnloadAssetRoot();
                return;
            }

            PopulateAssetRoot(file);
        }

        //Selected item Name
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (assetListView.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            var selectedItem = assetListView.SelectedItems[0];

            fileNameMenuItem.Text = string.Format("[{0}]", selectedItem.Text);
        }

        //Extract selected file
        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = assetListView.SelectedItems[0];

            var sfd = new SaveFileDialog
            {
                Title = string.Format("Extract {0}...", selectedItem.Text),

                CheckPathExists = true,
                FileName = selectedItem.Text,

                Filter = "All Files (*.*)|*.*",
            };

            var result = sfd.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            byte[] fileData = currentDb.GetAssetData(selectedItem.Tag as Asset);
            File.WriteAllBytes(sfd.FileName, fileData);
        }

        //Delete selected file
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = assetListView.SelectedItems[0];

            var result = MessageBox.Show(this,
                string.Format("Are you sure you wish to delete \"{0}\"?", selectedItem.Text), "Delete?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            currentDb.DeleteAsset(selectedItem.Tag as Asset);

            // refresh asset view
            PopulateAssetRoot(currentFile);
        }

        static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0 " + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return string.Format("{0} {1}", Math.Sign(byteCount) * num, suf[place]);
        }
        class DataFile
        {
            public string FilePath { get; set; }

            public override string ToString()
            {
                return Path.GetFileNameWithoutExtension(FilePath);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (dataFileListBox.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            var selectedItem = dataFileListBox.SelectedItems[0];

            nameToolStripMenuItem.Text = string.Format("[{0}]", selectedItem + ".db");
            extractDataToolStripMenuItem.Text = string.Format("Decompile: " + "[{0}]", selectedItem + ".db");
            insertDataToolStripMenuItem.Text = string.Format("Insert file into " + "[{0}]", selectedItem + ".db");
        }

        private void insertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentDb == null)
            {
                MessageBox.Show(this, "Please select an asset root to insert into.", "Unable to insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ofd = new OpenFileDialog
            {
                Title = "Select file to insert into database",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "All Files (*.*)|*.*",
            };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            foreach (var filePath in ofd.FileNames)
            {
                string fileName = Path.GetFileName(filePath);

                byte[] data = File.ReadAllBytes(filePath);
                currentDb.InsertAsset(fileName, data);
            }

            // refresh
            PopulateAssetRoot(currentFile);
        }

        //COMPILE 
        private void Compile()
        {
            try
            {
                listBox1.Items.Clear();
                progressBar1.Value = 0;
                string extension;

                if (currentDb == null)
                {
                    MessageBox.Show(this, "Please select an asset root to insert into.", "Unable to insert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dirInfo = new DirectoryInfo(textBox1.Text);
                foreach (var fileInfo in dirInfo.EnumerateFiles())
                {
                    extension = Path.GetExtension(textBox1.Text + "\\" + fileInfo);
                    var dataFile = new DataFile
                    {
                        FilePath = fileInfo.FullName,
                    };
                    byte[] data = File.ReadAllBytes(textBox1.Text + "\\" + dataFile + extension);
                    currentDb.InsertAsset(dataFile + extension, data);

                    progressBar1.Value = progressBar1.Value + 1;
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] [" + dataFile + extension + "] added to [" + dataFileListBox.SelectedItem.ToString() + ".db]");
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                }
                listBox1.Items.Add("");
                listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] " + "Succsessfully added all files.");
                files = 0;
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Something went wrong :/ ");
            }
        }
        //DECOMPILE ALL  Not working yet
        private void Decompile()
        {
            /*var selectedItem = assetListView.SelectedItems[0];
            var sfd = new SaveFileDialog
            {
                Title = string.Format("Extract {0}...", selectedItem.Text),

                CheckPathExists = true,
                FileName = selectedItem.Text,

                Filter = "All Files (*.*)|*.*",
            };

            var result = sfd.ShowDialog(this);

            if (result != DialogResult.OK)
                return;

            byte[] fileData = currentDb.GetAssetData(selectedItem.Tag as Asset);
            File.WriteAllBytes(sfd.FileName, fileData);*/
        }
        //////////////////////////////////////////////////////////////////////////
        //data1 compile
        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                files = 0;
                dataFileListBox.SetSelected(0, true);
                tabControl1.SelectedTab = tabPage2;
                progressBar1.Value = 0;
                folderBrowserDialog2.Description = "Select data folder path.";
                folderBrowserDialog2.ShowDialog();
                textBox1.Text = folderBrowserDialog2.SelectedPath;
                listBox1.Items.Clear();
                var dirInfo = new DirectoryInfo(textBox1.Text);
                foreach (var fileInfo in dirInfo.EnumerateFiles())
                {
                    var dataFile = new DataFile
                    {
                        FilePath = fileInfo.FullName,
                    };
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] [" + dataFile + "]");
                    files++;
                    progressBar1.Maximum = files;
                }
                MessageBox.Show(files.ToString() + " files found");
                DialogResult dialogResult = MessageBox.Show("Add files now ?", "CW Data Manager", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Compile();
                }
                else if (dialogResult == DialogResult.No)
                {
                   
                }
            }
            catch
            {
                MessageBox.Show("Error: No path selected.");
            }
        }
        //data1 read
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(0, true);
            tabControl1.SelectedTab = tabPage1;
        }
        //data1 decompile
        private void decompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(0, true);
            tabControl1.SelectedTab = tabPage3;
            Decompile();
        }
        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////
        //data2 read
        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(1, true);
            tabControl1.SelectedTab = tabPage1;
        }
        //data2 decompile
        private void decompileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(1, true);
            tabControl1.SelectedTab = tabPage3;
            Decompile();
        }
        //data2 compile
        private void compileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                files = 0;
                dataFileListBox.SetSelected(1, true);
                tabControl1.SelectedTab = tabPage2;
                progressBar1.Value = 0;
                folderBrowserDialog2.Description = "Select data folder path.";
                folderBrowserDialog2.ShowDialog();
                textBox1.Text = folderBrowserDialog2.SelectedPath;
                listBox1.Items.Clear();
                var dirInfo = new DirectoryInfo(textBox1.Text);
                foreach (var fileInfo in dirInfo.EnumerateFiles())
                {
                    var dataFile = new DataFile
                    {
                        FilePath = fileInfo.FullName,
                    };
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] [" + dataFile + "]");
                    files++;
                    progressBar1.Maximum = files;
                }
                MessageBox.Show(files.ToString() + " files found");
                DialogResult dialogResult = MessageBox.Show("Add files now ?", "CW Data Manager", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Compile();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch
            {
                MessageBox.Show("Error: No path selected.");
            }
        }
        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////
        //data3 read
        private void readToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(2, true);
            tabControl1.SelectedTab = tabPage1;
        }
        //data3 decompile
        private void decompileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(2, true);
            tabControl1.SelectedTab = tabPage3;
            Decompile();
        }
        //data3 compile
        private void compileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                files = 0;
                dataFileListBox.SetSelected(2, true);
                tabControl1.SelectedTab = tabPage2;
                progressBar1.Value = 0;
                folderBrowserDialog2.Description = "Select data folder path.";
                folderBrowserDialog2.ShowDialog();
                textBox1.Text = folderBrowserDialog2.SelectedPath;
                listBox1.Items.Clear();
                var dirInfo = new DirectoryInfo(textBox1.Text);
                foreach (var fileInfo in dirInfo.EnumerateFiles())
                {
                    var dataFile = new DataFile
                    {
                        FilePath = fileInfo.FullName,
                    };
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] [" + dataFile + "]");
                    files++;
                    progressBar1.Maximum = files;
                }
                MessageBox.Show(files.ToString() + " files found");
                DialogResult dialogResult = MessageBox.Show("Add files now ?", "CW Data Manager", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Compile();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch
            {
                MessageBox.Show("Error: No path selected.");
            }
        }
        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////
        //data4 read
        private void readToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(3, true);
            tabControl1.SelectedTab = tabPage1;
        }
        //data4 decompile
        private void decompileToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataFileListBox.SetSelected(3, true);
            tabControl1.SelectedTab = tabPage3;
            Decompile();
        }
        //data4 compile
        private void compileToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                files = 0;
                dataFileListBox.SetSelected(3, true);
                tabControl1.SelectedTab = tabPage2;
                progressBar1.Value = 0;
                folderBrowserDialog2.Description = "Select data folder path.";
                folderBrowserDialog2.ShowDialog();
                textBox1.Text = folderBrowserDialog2.SelectedPath;
                listBox1.Items.Clear();
                var dirInfo = new DirectoryInfo(textBox1.Text);
                foreach (var fileInfo in dirInfo.EnumerateFiles())
                {
                    var dataFile = new DataFile
                    {
                        FilePath = fileInfo.FullName,
                    };
                    listBox1.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] [" + dataFile + "]");
                    files++;
                    progressBar1.Maximum = files;
                }
                MessageBox.Show(files.ToString() + " files found");
                DialogResult dialogResult = MessageBox.Show("Add files now ?", "CW Data Manager", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Compile();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch
            {
                MessageBox.Show("Error: No path selected.");
            }
        }
        //////////////////////////////////////////////////////////////////////////
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CW Data Manager [v1.0.1]" + Environment.NewLine + Environment.NewLine + "Coding: .ReFleX" + Environment.NewLine + "Design: .ReFleX" + Environment.NewLine + Environment.NewLine + "CubeLib.dll: VoiDeD" + Environment.NewLine + Environment.NewLine +"Contact: " + Environment.NewLine + Environment.NewLine + "www.elitepvpers.com" + Environment.NewLine + "www.cubeworldforum.org");
        }
    }
}
