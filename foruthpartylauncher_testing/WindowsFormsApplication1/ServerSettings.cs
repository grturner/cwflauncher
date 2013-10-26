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

namespace WindowsFormsApplication1
{
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
        }
        //Variable Declaration
        int seedInt;
        string seedString;

        private void button2_Click(object sender, EventArgs e)
        {
            seedString = File.ReadAllText("server.cfg");
            seedTextBox.Text = seedString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void seedTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.seedTextBox.Text == "")
            {
                MessageBox.Show("Please insert a valid seed");
            }
            else
            {
                if (File.Exists("server.cfg"))
                {
                    if (File.Exists("server.cfg.bak")) { File.Delete("server.cfg.bak"); }
                    File.Move("server.cfg", "server.cfg.bak");
                }

                using (StreamWriter tw = new StreamWriter("server.cfg"))
                {
                    tw.WriteLine(seedTextBox.Text);
                }
            }
                
       }
    }
}
