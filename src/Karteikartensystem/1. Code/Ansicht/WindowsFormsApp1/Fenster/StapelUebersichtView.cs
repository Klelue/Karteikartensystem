using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Fenster;
using WindowsFormsApp1.FensterMethoden;

namespace WindowsFormsApp1
{
    public partial class StapelUebersichtView : Form
    {
        //OUT
        private List<Stapel.Stapel> alleStapel;
        private UebersichtMethoden methoden = new UebersichtMethoden();
        //
        public StapelUebersichtView()
        {
            InitializeComponent(); 
            //OUT
            StapelRepository repository = new StapelRepository();
            alleStapel = repository.GetAlleStapel().ToList();
            //
            ListViewFormatieren();
            listView_AusgabeAnzeigen(alleStapel);
        }

        private void ListViewFormatieren()
        {
            listView_Ausgabe.View = View.Details;
            listView_Ausgabe.Columns.Add("ID");
            listView_Ausgabe.Columns.Add("Stapelname").Width = 140;
            listView_Ausgabe.Columns.Add("Anzahl");
        }

        private void listView_AusgabeAnzeigen(List<Stapel.Stapel> anzeigen)
        {
            List<ListViewItem> listViewItems= new List<ListViewItem>();
            foreach(Stapel.Stapel stapel in anzeigen)
            {
                listViewItems.Add(ListViewItemErzeugen(stapel));
            }
            listView_Ausgabe.Items.Clear();
            listView_Ausgabe.Items.AddRange(listViewItems.ToArray());
        }

        private ListViewItem ListViewItemErzeugen(Stapel.Stapel stapel)
        {
            ListViewItem item = new ListViewItem(stapel.Id.ToString());
            item.SubItems.Add(stapel.Name);
            //TODO:
            //item.SubItems.Add(stapel.Karten.Count.ToString());
            item.SubItems.Add("-");
            return item;
        }

        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
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
        //TODO:
        /// <summary>
        /// -> TO CONTROLLER
        /// </summary>
        /// <param name="eingabe"></param>
        private void StapelSucheAnzeigen(string eingabe)
        {
            List<Stapel.Stapel> gefundenList = methoden.GetGefundenList(eingabe, alleStapel);

            if(gefundenList.Count == 0)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView_AusgabeAnzeigen(alleStapel);
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
            Form kartenUebersicht = new KartenUebersicht(listView_Ausgabe.SelectedItems[0].SubItems[1].Text);
            kartenUebersicht.Show();
        }

        //TODO RENAME ?! SORTIERUNG
        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_Entfernen_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Möchtest du es wirklich entfernen?", "Entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Stapel wurde gelöscht", "Hat geklappt", MessageBoxButtons.OK); ;
            }
        }
    }
}
