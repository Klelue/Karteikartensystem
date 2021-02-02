using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Fenster
{
    public partial class HinzufuegenView : Form
    {
        public HinzufuegenView()
        {
            InitializeComponent();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            string eingabe = txt_eingabe.Text;
            txt_eingabe.Clear();
            //eingabe zu datenbank
            MessageBox.Show("Erfolgreich hinzugefügt", "Yippy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.Dispose();
        }
    }
}
