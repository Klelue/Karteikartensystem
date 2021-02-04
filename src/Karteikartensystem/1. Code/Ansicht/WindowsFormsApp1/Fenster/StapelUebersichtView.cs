using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using AnsichtsFenster.FensterMethoden;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelUebersichtView : Form
    {
        //IN
        private StapelListViewController _stapelListViewController;

        //LATER OUT - DATA TO CONTROLLER
        private List<Stapel> alleStapel;
        private UebersichtMethoden methoden = new UebersichtMethoden();
        private ListViewItem selectedItem;

        public StapelUebersichtView()
        {
            InitializeComponent();
           
            //IN MODULES
            _stapelListViewController = new StapelListViewController();
            //IN METHODS
            listView_Ausgabe = _stapelListViewController.CreateView(listView_Ausgabe);
            listView_Ausgabe = _stapelListViewController.UpdateView(listView_Ausgabe);
            //
            //TODO: ANDERER WEG ALS DURCHSCHLEIFEN?
            //listView_Ausgabe = _stapelListViewController.CreateView();
            //listView_Ausgabe = _stapelListViewController.ListViewUpdate(listView_Ausgabe);
            //
            //
            alleStapel = _stapelListViewController.GetAlleStapelVonDatenbank();
            //OUT - OLD CODE
            //ListViewFormatieren();
            //listView_AusgabeAnzeigen(alleStapel);
        }

        /*
        private void ListViewFormatieren()
        {
            listView_Ausgabe.View = View.Details;
            listView_Ausgabe.Columns.Add("ID");
            listView_Ausgabe.Columns.Add("Stapelname").Width = 130;
            listView_Ausgabe.Columns.Add("Anzahl");
        }
        */

        private void listView_AusgabeAnzeigen(List<Stapel> anzeigen)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Stapel stapel in anzeigen)
            {
                listViewItems.Add(ListViewItemErzeugen(stapel));
            }

            listView_Ausgabe.Items.Clear();
            listView_Ausgabe.Items.AddRange(listViewItems.ToArray());
        }

        public ListViewItem ListViewItemErzeugen(Stapel stapel)
        {
            ListViewItem item = new ListViewItem(stapel.Id.ToString());
            item.SubItems.Add(stapel.Name);
            item.SubItems.Add("0");
            return item;
        }

        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_StapelSuche.Text.Trim() == "")
                {
                    listView_AusgabeAnzeigen(alleStapel);
                }

                else
                {
                    StapelSucheAnzeigen(txt_StapelSuche.Text);
                }

                //listView_Ausgabe.
                selectedItem = null;
                txt_StapelSuche.Clear();
            }
        }

        private void StapelSucheAnzeigen(string eingabe)
        {
            List<Stapel> gefundenList = methoden.GetGefundenList(eingabe, alleStapel);

            if (gefundenList.Count == 0)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView_AusgabeAnzeigen(alleStapel);
            }

            else
            {
                listView_AusgabeAnzeigen(gefundenList);

            }
        }

        private void btn_StapelHinzufuegen_Click(object sender, EventArgs e)
        {
            Form hinzufuegenFenster = new HinzufuegenView();
            hinzufuegenFenster.Show(this);
        }

        private void listView_Ausgabe_Click(object sender, EventArgs e)
        {
            selectedItem = listView_Ausgabe.SelectedItems[0];
        }

        private void listView_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listView_Ausgabe.SelectedItems[0];

            string panelName = item.SubItems[1].Text;
            int panelId = Convert.ToInt32(item.SubItems[0].Text);

            Form kartenUebersicht = new KartenUebersicht(panelName, panelId);
            kartenUebersicht.Show();
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_Entfernen_Click(object sender, EventArgs e)
        {
            //TODO: TRY FOR NULL!
            if (MessageBox.Show("Möchtest du es wirklich den Stapel \"" + selectedItem.SubItems[1].Text + "\" entfernen?", "Entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Stapel wurde gelöscht", "Hat geklappt", MessageBoxButtons.OK); ;
            }
        }

        private void btn_KartenHinzufuegen_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                Form kartenHinzufuegenFenster = new HinzufuegenKarten(selectedItem.SubItems[1].Text);
                kartenHinzufuegenFenster.Show();
            }

            else
            {
                MessageBox.Show("Es wurde kein Stapel ausgewählt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
