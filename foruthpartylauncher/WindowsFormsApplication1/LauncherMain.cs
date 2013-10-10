using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class LauncherMain : Form
    {
        public LauncherMain()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //
        //}

        private void Launch_Click(object sender, EventArgs e)
        {
            Process.Start("Cube.exe");
        }

        private void OrigLauncher_Click(object sender, EventArgs e)
        {
            Process.Start("CubeLauncher.exe");
        }

        private void CubeWorldForum_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cubeworldforum.org");
        }

        private void ServerSettings_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "server.cfg");
        }

        private void ServerLaunch_Click(object sender, EventArgs e)
        {
            Process.Start("Server.exe");
        }

        private void Skins_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
        }

        private void GameSettings_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Options.cfg");
        }
    }
}
