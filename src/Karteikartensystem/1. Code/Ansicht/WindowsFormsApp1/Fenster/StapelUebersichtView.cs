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
        //IN
        private StapelViewController _stapelController;
        //LATER OUT - DATA TO CONTROLLER
        private List<Stapel> alleStapel;
        private ListViewItem selectedItem;

        public StapelUebersichtView()
        {
            InitializeComponent();

            //NEW METHODS
            _stapelController = new StapelViewController();
            listView_Ausgabe = _stapelController.CreateView(listView_Ausgabe);
            listView_Ausgabe = _stapelController.UpdateView(listView_Ausgabe);
            //TODO: ANDERER WEG ALS DURCHSCHLEIFEN?
            //listView_Ausgabe = _stapelController.CreateView();
            //listView_Ausgabe = _stapelController.ListViewUpdate(listView_Ausgabe);

            //OUT - CODE
            //alleStapel = _stapelController.GetAlleStapelVonDatenbank();
        }
        
        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_StapelSuche.Text.Trim() == "")
                {
                    listView_Ausgabe = _stapelController.UpdateView(listView_Ausgabe);
                }
                else
                {
                    listView_Ausgabe =_stapelController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
                }
                //TODO NEED TO NULL?
                selectedItem = null;
                txt_StapelSuche.Clear();
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
            _stapelController.SortAscending(listView_Ausgabe);
            //this.listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
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
