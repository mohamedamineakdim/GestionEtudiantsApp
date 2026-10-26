using GestionEtudiantsApps;
using System;
using System.Windows.Forms;

namespace GestionEtudiantsApp.UII
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmEtudiants f1 = new FrmEtudiants())
            {
                f1.ShowDialog();
            }

            using (FrmMatieres f2 = new FrmMatieres())
            {
                f2.ShowDialog();
            }

            using (FrmNotes f3 = new FrmNotes())
            {
                f3.ShowDialog();
            }

            using (FrmClassement f4 = new FrmClassement())
            {
                f4.ShowDialog();
            }
        }
    }
}
