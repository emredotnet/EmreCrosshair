using System;
using System.Windows.Forms;

namespace CrosshairCsharp
{
    static class Program
    {
        /// <summary>
        /// Uygulaman�n ana giri� noktas�.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormEmreCrosshair());
        }
    }
}

