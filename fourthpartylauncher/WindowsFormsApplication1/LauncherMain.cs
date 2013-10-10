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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Launch_Click(object sender, EventArgs e)
        {
            Process.Start("Cube.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Options.cfg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("CubeLauncher.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cubeworldforum.org");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "server.cfg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Server.exe");
        }
    }
}
