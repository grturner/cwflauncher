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
using System.IO;

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
        //Variable Declaration
        int yAxis;
        int fullScreen;
        int width;
        int height;
        int antiAlias;
        int rDist;
        int cSmooth;
        int cSpeed;
        int mVol;
        int sVol;
        int wCust;
        int hCust;
        int fpsLim;

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void widthCust_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar !='\b'))
            {
                MessageBox.Show("Numbers Only!");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void heightCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Numbers Only!");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void FullScreenCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FullScreenCheck.Checked == true) { fullScreen = 1;}
            else { fullScreen = 0; }
        }

        private void Yaxis_CheckedChanged(object sender, EventArgs e)
        {
            if (YaxisCheck.Checked == true) { yAxis = 1; }
            else { yAxis = 0; }
        }

        private void antialiasingBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (antialiasingBox.SelectedIndex)
            {
                case 0:
                    antiAlias = 0;
                    break;
                case 1:
                    antiAlias = 2;
                    break;
                case 2:
                    antiAlias = 4;
                    break;
            }
        }

        private void editCurrentConfig_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Options.cfg");
        }

        private void Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Resolution.SelectedIndex)
            {
                case 0:
                    width = -1;
                    height = -1;
                    break;
                case 1:
                    width = 1920;
                    height = 1200;
                    break;
                case 2:
                    width = 1920;
                    height = 1080;
                    break;
                case 3:
                    width = 1440;
                    height = 900;
                    break;
                case 4:
                    width = 1366;
                    height = 768;
                    break;
                case 5:
                    width = 1280;
                    height = 1024;
                    break;
                case 6:
                    width = 1280;
                    height = 720;
                    break;
                case 7:
                    width = 1024;
                    height = 768;
                    break;
                case 8:
                    width = 800;
                    height = 600;
                    break;
            }
        }

        private void renderDistanceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (renderDistanceList.SelectedIndex)
            {
                case 0:
                    rDist = 100;
                    break;
                case 1:
                    rDist = 95;
                    break;
                case 2:
                    rDist = 90;
                    break;
                case 3:
                    rDist = 85;
                    break;
                case 4:
                    rDist = 80;
                    break;
                case 5:
                    rDist = 75;
                    break;
                case 6:
                    rDist = 70;
                    break;
                case 7:
                    rDist = 65;
                    break;
                case 8:
                    rDist = 60;
                    break;
                case 9:
                    rDist = 55;
                    break;
                case 10:
                    rDist = 50;
                    break;
                case 11:
                    rDist = 45;
                    break;
                case 12:
                    rDist = 40;
                    break;
                case 13:
                    rDist = 35;
                    break;
                case 14:
                    rDist = 30;
                    break;
                case 15:
                    rDist = 25;
                    break;
            }
        }

        private void cameraSmoothList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cameraSmoothList.SelectedIndex)
            {
                case 0:
                    cSmooth = 100;
                    break;
                case 1:
                    cSmooth = 95;
                    break;
                case 2:
                    cSmooth = 90;
                    break;
                case 3:
                    cSmooth = 85;
                    break;
                case 4:
                    cSmooth = 80;
                    break;
                case 5:
                    cSmooth = 75;
                    break;
                case 6:
                    cSmooth = 70;
                    break;
                case 7:
                    cSmooth = 65;
                    break;
                case 8:
                    cSmooth = 60;
                    break;
                case 9:
                    cSmooth = 55;
                    break;
                case 10:
                    cSmooth = 50;
                    break;
                case 11:
                    cSmooth = 45;
                    break;
                case 12:
                    cSmooth = 40;
                    break;
                case 13:
                    cSmooth = 35;
                    break;
                case 14:
                    cSmooth = 30;
                    break;
                case 15:
                    cSmooth = 25;
                    break;
                case 16:
                    cSmooth = 20;
                    break;
                case 17:
                    cSmooth = 15;
                    break;
                case 18:
                    cSmooth = 10;
                    break;
                case 19:
                    cSmooth = 5;
                    break;
                case 20:
                    cSmooth = 0;
                    break;

            }
        }

        private void cameraSpeedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cameraSpeedList.SelectedIndex)
            {
                case 0:
                    cSpeed = 100;
                    break;
                case 1:
                    cSpeed = 95;
                    break;
                case 2:
                    cSpeed = 90;
                    break;
                case 3:
                    cSpeed = 85;
                    break;
                case 4:
                    cSpeed = 80;
                    break;
                case 5:
                    cSpeed = 75;
                    break;
                case 6:
                    cSpeed = 70;
                    break;
                case 7:
                    cSpeed = 65;
                    break;
                case 8:
                    cSpeed = 60;
                    break;
                case 9:
                    cSpeed = 55;
                    break;
                case 10:
                    cSpeed = 50;
                    break;
                case 11:
                    cSpeed = 45;
                    break;
                case 12:
                    cSpeed = 40;
                    break;
                case 13:
                    cSpeed = 35;
                    break;
                case 14:
                    cSpeed = 30;
                    break;
                case 15:
                    cSpeed = 25;
                    break;
                case 16:
                    cSpeed = 20;
                    break;
                case 17:
                    cSpeed = 15;
                    break;
                case 18:
                    cSpeed = 10;
                    break;
            }
        }

        private void musicVolList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (musicVolList.SelectedIndex)
            {
                case 0:
                    mVol = 100;
                    break;
                case 1:
                    mVol = 90;
                    break;
                case 2:
                    mVol = 80;
                    break;
                case 3:
                    mVol = 70;
                    break;
                case 4:
                    mVol = 60;
                    break;
                case 5:
                    mVol = 50;
                    break;
                case 6:
                    mVol = 40;
                    break;
                case 7:
                    mVol = 30;
                    break;
                case 8:
                    mVol = 20;
                    break;
                case 9:
                    mVol = 10;
                    break;
                case 10:
                    mVol = 0;
                    break;
            }
        }

        private void soundVolList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (soundVolList.SelectedIndex)
            {
                case 0:
                    sVol = 100;
                    break;
                case 1:
                    sVol = 90;
                    break;
                case 2:
                    sVol = 80;
                    break;
                case 3:
                    sVol = 70;
                    break;
                case 4:
                    sVol = 60;
                    break;
                case 5:
                    sVol = 50;
                    break;
                case 6:
                    sVol = 40;
                    break;
                case 7:
                    sVol = 30;
                    break;
                case 8:
                    sVol = 20;
                    break;
                case 9:
                    sVol = 10;
                    break;
                case 10:
                    sVol = 0;
                    break;
            }
        }
        private void fpsLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fpsLimit.SelectedIndex)
            {
                case 0:
                    fpsLim = 0;
                    break;
                case 1:
                    fpsLim = 1;
                    break;
                case 2: 
                    fpsLim = 2;
                    break;
                case 3:
                    fpsLim = 4;
                    break;
                case 4:
                    fpsLim = 6;
                    break;
                case 5:
                    fpsLim = 10;
                    break;
                case 6:
                    fpsLim = 13;
                    break;
                case 7:
                    fpsLim = 17;
                    break;
                case 8:
                    fpsLim = 25;
                    break;
                case 9:
                    fpsLim = 33;
                    break;
                case 10:
                    fpsLim = 50;
                    break;
            }
        }
        
        private void WriteConfig_Click(object sender, EventArgs e)
        {
            string hRes;
            string wRes;
            if (width == -1 | height == -1)
            {
            wRes = "resolutionX " + wCust;
            hRes = "resolutionY " + hCust;
            }
            else
            {
            wRes = "resolutionX " + width;
            hRes = "resolutionY " + height;
            }
            string fScreen = "fullScreen " + fullScreen;
            string rDis = "renderDistance " + rDist;
            string sV = "soundVolume " + sVol;
            string mV = "musicVolume " + mVol;
            string cSp = "cameraSpeed " + cSpeed;
            string cSm = "cameraSmooth " + cSmooth;
            string iY = "invertY " + yAxis;
            string fLim = "minTimeStep " + fpsLim;
                        
            if (File.Exists("options.cfg"))
            {
                if (File.Exists("options.cfg.bak")) { File.Delete("options.cfg.bak"); }
            File.Move("options.cfg", "options.cfg.bak"); 
            }

            using(StreamWriter tw = new StreamWriter("options.cfg"))
            {
            tw.WriteLine(fScreen);
            tw.WriteLine(wRes);
            tw.WriteLine(hRes);
            tw.WriteLine(rDis);
            tw.WriteLine(sV);
            tw.WriteLine(mV);
            tw.WriteLine(cSp);
            tw.WriteLine(cSm);
            tw.WriteLine(iY);
            tw.WriteLine(fLim);
            }
        }

        private void widthCust_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(widthCust.Text, out wCust);
        }

        private void heightCust_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(heightCust.Text, out hCust);
        }
    }
}