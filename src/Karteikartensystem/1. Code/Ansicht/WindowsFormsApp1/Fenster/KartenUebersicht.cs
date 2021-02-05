using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Repositories;
using Model;
using System.Linq;
using AnsichtsFenster.Utilities;

namespace AnsichtsFenster.Fenster
{
    public partial class KartenUebersicht : Form
    {
        private List<Karte> alleKarten;
        private Karte selectedKarte;

        public KartenUebersicht(string stapelName, int stapelId)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;

            KarteRepository repository = new KarteRepository();
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();
            ListViewFormatieren();
            selectedKarte = alleKarten[0];
            lbl_FrageSetzen();
        }

        private void ListViewFormatieren()
        {
            listView_KartenAnzeige.View = View.Details;
            listView_KartenAnzeige.Columns.Add("Fragen");
            KartenAnzeigen(alleKarten);
        }

        private void KartenAnzeigen(List<Karte> anzeigeList)
        {
            List<ListViewItem> listViewItem = new List<ListViewItem>();

            foreach (Karte karte in anzeigeList)
            {
                listViewItem.Add(new ListViewItem(karte.Frage));
            }

            listView_KartenAnzeige.Items.Clear();
            listView_KartenAnzeige.Items.AddRange(listViewItem.ToArray());
        }

        private void txt_KartenSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_KartenSuche.Text.Trim() == "")
                {
                    KartenAnzeigen(alleKarten);
                }

                else
                {
                    KartenSucheAnzeigen(txt_KartenSuche.Text);
                }

                txt_KartenSuche.Clear();
            }
        }

        private void KartenSucheAnzeigen(string suchbegriff)
        {
            List<Karte> ergebnisListe = StringSuchTool.GetSuchergebnis(suchbegriff, alleKarten);

            if (ergebnisListe.Count < 1)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KartenAnzeigen(alleKarten);
            }

            else
            {
                KartenAnzeigen(ergebnisListe);
            }
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_KartenAnzeige.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        private void btn_Antwort_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            { 
                richTxt_Antwort.Text = selectedKarte.Antwort;
            }
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            if (alleKarten.Count > 1)
            {
                Random random = new Random();
                Karte newKarte = null;

                while (newKarte == null)
                {
                    int index = random.Next(alleKarten.Count);
                    if (alleKarten[index] != selectedKarte)
                    {
                        newKarte = alleKarten[index]; ;
                    }
                }

                selectedKarte = newKarte;
                lbl_FrageSetzen();
            }
           

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (alleKarten.Count > 1)
            {
                int aktuellerId = selectedKarte.Id;

                if (aktuellerId < alleKarten.Count)
                {
                    selectedKarte = alleKarten[aktuellerId];
                }

                else
                {
                    selectedKarte = alleKarten[0];
                }

                lbl_FrageSetzen();
            }
        }

        private void lbl_FrageSetzen()
        {
            lbl_Frage.Text = "Frage: " + selectedKarte.Frage;
            richTxt_Antwort.Clear();
        }

        private Karte SelectedKarteAsKarte(string karteFrage)
        {
            return alleKarten.Find(karte => karte.Frage == karteFrage);
        }

        private void listView_KartenAnzeige_MouseClick(object sender, MouseEventArgs e)
        {
            selectedKarte = SelectedKarteAsKarte(listView_KartenAnzeige.SelectedItems[0].Text);
            lbl_FrageSetzen();
        }
    }
}
