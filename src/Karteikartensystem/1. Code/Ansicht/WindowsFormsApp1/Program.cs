using System;
using System.Drawing;
using System.Windows.Forms;
using AnsichtsFenster.Fenster;

namespace AnsichtsFenster
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StapelUebersichtView(new Point(200, 200)));
        }
    }
}
