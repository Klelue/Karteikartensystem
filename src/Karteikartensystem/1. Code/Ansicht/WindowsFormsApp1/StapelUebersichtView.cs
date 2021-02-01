using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StapelUebersichtView : Form
    {
        private List<string> alleStapel = new List<string> ();
        public StapelUebersichtView()
        {
            InitializeComponent(); // hier müsste die erste Abfrage drinstehen.
            alleStapel.Add("bubi");
            alleStapel.Add("Stephan");
            alleStapel.Add("bubicon");
            listView_Ausgabe.View = View.Details;
            listView_Ausgabe.Columns.Add("Stapelname");

        }

        private void listView_AusgabeAnzeigen(List<string> anzeigen)
        {
            listView_Ausgabe.Items.Clear();
            List<ListViewItem> lvi = new List<ListViewItem>();
            foreach(string s in anzeigen)
            {
                lvi.Add(new ListViewItem(s));
            }
            listView_Ausgabe.Items.AddRange(lvi.ToArray());
        }

        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                if(txt_StapelSuche.Text.Trim() == "")
                {
                    listView_AusgabeAnzeigen(alleStapel);
                }
                else
                {
                    StapelSucheAnzeigen(txt_StapelSuche.Text);
                }
                txt_StapelSuche.Clear();

            }
        }

        private void StapelSucheAnzeigen(string eingabe)
        {
            bool nichtGefunden = true;
            List<string> gefundenList = new List<string>();

            foreach(string s in alleStapel)
            {
                if (s.Contains(eingabe))
                {
                    nichtGefunden = false;
                    gefundenList.Add(s);
                }
            }

            if(nichtGefunden)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                listView_AusgabeAnzeigen(gefundenList);
            }
        }


    }
}
