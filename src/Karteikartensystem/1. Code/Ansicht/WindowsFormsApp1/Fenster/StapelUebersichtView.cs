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
        private StapelViewController _stapelController;

        //LATER OUT - DATA TO CONTROLLER
        private List<Stapel> alleStapel;
        private UebersichtMethoden methoden = new UebersichtMethoden();
        private ListViewItem selectedItem;

        public StapelUebersichtView()
        {
            InitializeComponent();
            //NEW METHODS
            _stapelController = new StapelViewController();
            listView_Ausgabe = _stapelController.CreateView(listView_Ausgabe);
            listView_Ausgabe = _stapelController.UpdateView(listView_Ausgabe);
            //
            //TODO: ANDERER WEG ALS DURCHSCHLEIFEN?
            //listView_Ausgabe = _stapelController.CreateView();
            //listView_Ausgabe = _stapelController.ListViewUpdate(listView_Ausgabe);
            //
            //OUT - OLD CODE
            alleStapel = _stapelController.GetAlleStapelVonDatenbank();
            //listView_AusgabeAnzeigen(alleStapel);
        }
        
        private void listView_AusgabeAnzeigen(List<Stapel> anzeigen)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Stapel stapel in anzeigen)
            {
                listViewItems.Add(_stapelController.CreateViewItem(stapel));
            }

            listView_Ausgabe.Items.Clear();
            listView_Ausgabe.Items.AddRange(listViewItems.ToArray());
        }
        
        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_StapelSuche.Text.Trim() == "")
                {
                    //OLD
                    //listView_AusgabeAnzeigen(alleStapel);
                    //TODO ÜBERLADUNG ODER IMMER DB ABFRAGE? -ANDERS ZWISCHENSPEICHERN?
                    //listView_Ausgabe = _stapelController.ReloadView(listView_Ausgabe);
                    //TODO - ODER SO - WO STAPEL ZWISCHENSPEICHERN?:
                    listView_Ausgabe = _stapelController.ReloadView(listView_Ausgabe, alleStapel);
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
