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
            //Process.Start("notepad.exe", "server.cfg");
            ServerSettings f3 = new ServerSettings();
            f3.ShowDialog();
        }

        private void ServerLaunch_Click(object sender, EventArgs e)
        {
            Process.Start("Server.exe");
        }

        private void Skins_Click(object sender, EventArgs e)
        {
            if (Environment.Is64BitOperatingSystem)
            {
                Process.Start(@"C:\Program Files (x86)\Cube World");
            }
            else
            {
              Process.Start(@"C:\Program Files\Cube World");
            }
        }

        private void GameSettings_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GameSettings f2 = new GameSettings();
            f2.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == (Keys.Control | Keys.Shift))
            {
                Process.Start("http://www.youtube.com/watch?v=SdUGTKF8MEE");
            }
        }
    }
}
