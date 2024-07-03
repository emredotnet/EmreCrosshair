using System;
using System.Windows.Forms;

namespace CrosshairCsharp
{
    static class Program
    {
        /// <summary>
        /// Uygulamanýn ana giriþ noktasý.
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

