using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnsichtsFenster.Fenster
{
    public partial class HinzufuegenKarten : Form
    {
        private string stapelName;

        public HinzufuegenKarten(string stapelName)
        {
            InitializeComponent();

            this.stapelName = stapelName;
        }

        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            string vorderseite = richTxt_Vorderseite.Text;
            string rueckseite = richTxt_Rueckseite.Text;

            MessageBox.Show("Vorderseite : \n" + vorderseite + "\n Rückseite : \n" + rueckseite, "Was wird gespeichert", MessageBoxButtons.OK);
        }
    }
}
