using GestionEtudiantsApps;
using System;
using System.Windows.Forms;

namespace GestionEtudiantsApps
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmEtudiants());
        }
    }
}
