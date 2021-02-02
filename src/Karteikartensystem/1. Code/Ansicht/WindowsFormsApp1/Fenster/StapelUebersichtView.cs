using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FensterMethoden;

namespace WindowsFormsApp1
{
    public partial class StapelUebersichtView : Form
    {
        private List<string> alleStapel = new List<string> ();
        private UebersichtMethoden methoden = new UebersichtMethoden();

        public StapelUebersichtView()
        {
            InitializeComponent(); // hier müsste die erste Abfrage drinstehen.

            alleStapel = methoden.DatenbankAbfrage();
            listView_Ausgabe.View = View.Details;
            listView_Ausgabe.Columns.Add("Stapelname");
            listView_AusgabeAnzeigen(alleStapel);

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
            List<string> gefundenList = methoden.GetGefundenList(eingabe, alleStapel);

            if(gefundenList.Count < 1)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                listView_AusgabeAnzeigen(gefundenList);
            }
        }

        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            Form hinzufuegenFenster = new HinzufuegenView();
            hinzufuegenFenster.Show(this);
        }

        private void listView_Ausgabe_Click(object sender, EventArgs e)
        {
            Form kartenUebersicht = new KartenUebersicht(listView_Ausgabe.SelectedItems[0].Text);
            kartenUebersicht.Show();

        }
    }
}
