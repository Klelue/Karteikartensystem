using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AnsichtsFenster.FensterMethoden;
using Repositories;
using Model;
using System.Linq;

namespace AnsichtsFenster.Fenster
{
    public partial class KartenUebersicht : Form
    {
        private List<Karte> alleKarten;
        private UebersichtMethoden methoden = new UebersichtMethoden();

        public KartenUebersicht(string stapelName, int stapelId)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;

            KarteRepository repository = new KarteRepository();
            alleKarten = repository.GetKarten(stapelId).ToList();
            ListViewFormatieren();
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

        private void KartenSucheAnzeigen(string eingabe)
        {
            List<Karte> gefundenList = methoden.GetGefundenList(eingabe, alleKarten);

            if (gefundenList.Count < 1)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KartenAnzeigen(alleKarten);
            }

            else
            {
                KartenAnzeigen(gefundenList);
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
    }
}
