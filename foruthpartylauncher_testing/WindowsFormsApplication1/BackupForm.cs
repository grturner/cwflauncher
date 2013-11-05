using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;
namespace WindowsFormsApplication1
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(@"Save");
                zip.Comment = "This zip was created by Fourth Party Launcher at " + System.DateTime.Now.ToString("G");
                zip.Save("Backup.zip");
            }
            string path = @"Backup_" + DateTime.Now.ToString("MMddyyHHmmss") + ".zip";
            File.Move(@"Backup.zip", path);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
    }

        private void chooseBackupButton_Click(object sender, EventArgs e)
        {
            //Stream openBackupStream = null;
            OpenFileDialog openBackupDialog1 = new OpenFileDialog();
            openBackupDialog1.InitialDirectory = "";
            openBackupDialog1.Filter = "zip files(*.zip)|*.zip|All files (*.*)|*.*";
            openBackupDialog1.FilterIndex = 2;
            openBackupDialog1.RestoreDirectory = true;

            if (openBackupDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openBackupDialog1.FileName;
                try
                {
                    //Directory.Delete(@"Save");
                    //Directory.CreateDirectory(@"Save");
                    //File.Copy(file, @"Save\backup.zip");
                    using (ZipFile zip1 = ZipFile.Read(file))
                    {
                        foreach(ZipEntry f in zip1)
                        {
                            f.Extract(@"Save", ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
                    MessageBox.Show("Backup restored.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk. Error: " + ex.Message);
                }
            }
        }


        }
}
