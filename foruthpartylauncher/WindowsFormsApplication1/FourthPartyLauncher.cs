using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    static class FourthPartyLauncher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //determine whether OS is 64 or 32 bit
            if (Environment.Is64BitOperatingSystem)
            {
                //64 bit
                Directory.SetCurrentDirectory(@"C:\Program Files (x86)\Cube World");
            }
            else
            {
                //32 bit
                Directory.SetCurrentDirectory(@"C:\Program Files\Cube World");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherMain());
        }
    }
}
