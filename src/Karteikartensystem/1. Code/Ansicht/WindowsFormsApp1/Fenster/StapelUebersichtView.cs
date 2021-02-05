using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using AnsichtsFenster.Utilities;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelUebersichtView : Form
    {
        private StapelListController stapelListController;

        //TODO SINNVOLL AUSZULAGERN? - KLEMENS FRAGEN
        //TODO OTHER WAY TO STORE ITEM STATE?
        private ListViewItem selectedItem;

        public StapelUebersichtView()
        {
            InitializeComponent();
            stapelListController = new StapelListController();

            //TODO: ANDERER WEG ALS DURCHSCHLEIFEN?
            listView_Ausgabe = stapelListController.CreateView(listView_Ausgabe);
            listView_Ausgabe = stapelListController.UpdateView(listView_Ausgabe);
        }
        
        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_StapelSuche.Text.Trim() == "")
                {
                    listView_Ausgabe = stapelListController.UpdateView(listView_Ausgabe);
                }
                else
                {
                    listView_Ausgabe =stapelListController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
                }
                txt_StapelSuche.Clear();
            }
        }
        
        private void btn_StapelHinzufuegen_Click(object sender, EventArgs e)
        {
            new ViewController().BuildHinzufuegenView().Show(this);
        }

        private void listView_Ausgabe_Click(object sender, EventArgs e)
        {
            //TODO OTHER WAY TO STORE ITEM STATE?
            selectedItem =  stapelListController.SelectItem(listView_Ausgabe);
        }

        private void listView_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            //TODO OTHER WAY TO STORE ITEM STATE?
            new ViewController().BuildKartenUebersicht(selectedItem).Show();
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_Entfernen_Click(object sender, EventArgs e)
        {
            //TODO: TRY FOR NULL!
            //TODO DELETE OBJECT
            //TODO DELETE DATABASE ENTRY
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
