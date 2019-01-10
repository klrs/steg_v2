using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steg_v2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //test();
        }
        static void test()
        {
            byte[] b = new byte[6];
            b[0] = 77;
            b[1] = 79;
            b[2] = 84;
            b[3] = 72;
            b[4] = 69;
            b[5] = 82;

            File.WriteAllBytes("G:/Programming/C#/steg_v2/Test/ttt", b);
        }
    }
}
