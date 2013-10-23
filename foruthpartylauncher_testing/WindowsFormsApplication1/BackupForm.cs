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
            string path = @"Backup_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".zip";
            File.Move(@"Backup.zip", path);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
    }
        }
}
