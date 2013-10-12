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
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WindowsFormsApplication1
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }

        private void ResolutionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WriteConfig_Click(object sender, EventArgs e)
        {

        }

        private void BackupConfig_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void FullScreenCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FullScreenCheck.Checked == true) { int fullScreen = 1;}
            else { int fullScreen = 0; }
        }

        private void Yaxis_CheckedChanged(object sender, EventArgs e)
        {
            if (YaxisCheck.Checked == true) { int yAxis = 1; }
            else { int yAxis = 0; }
        }

        private void WidthCustom_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightCustom_TextChanged(object sender, EventArgs e)
        {

        }

        private void RenderDistanceBar_Scroll(object sender, EventArgs e)
        {

        }

        private void antialiasingBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editCurrentConfig_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Options.cfg");
        }

        private void Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Resolution.Get.SelectedIndex = 1)
            { int width = 1920;
            int height = 1200;
            }
        }
    }
}
