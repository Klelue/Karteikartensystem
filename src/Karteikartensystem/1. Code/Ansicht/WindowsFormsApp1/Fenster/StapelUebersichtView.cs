using System;
using System.Windows.Forms;
using AnsichtsFenster.Controller;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelUebersichtView : Form
    {
        //TODO OTHER WAY TO STORE ITEM STATE?
        private ListViewItem selectedItem;
        //
        private StapelListController listController;
        private ViewController viewController;

        public StapelUebersichtView()
        {
            InitializeComponent();
            listController = new StapelListController();
            viewController = new ViewController();

            listView_Ausgabe = listController.CreateView(listView_Ausgabe);
            listView_Ausgabe = listController.UpdateView(listView_Ausgabe);
        }
        
        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_StapelSuche.Text.Trim() == "")
                {
                    listView_Ausgabe = listController.UpdateView(listView_Ausgabe);
                }
                else
                {
                    listView_Ausgabe =listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
                }
                txt_StapelSuche.Clear();
            }
        }
        
        private void btn_StapelHinzufuegen_Click(object sender, EventArgs e)
        {
            viewController.BuildHinzufuegenView().Show(this);
        }

        private void listView_Ausgabe_Click(object sender, EventArgs e)
        {
            selectedItem =  listController.SelectItem(listView_Ausgabe);
        }

        private void listView_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            viewController.BuildKartenUebersicht(selectedItem).Show();
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_Entfernen_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                if (viewController.GetMessageBoxChoiceStapelLoeschen(selectedItem))
                {
                    listView_Ausgabe = listController.DeleteItem(listView_Ausgabe, selectedItem);
                        //TODO CHECK FOR SUCCESS
                        viewController.GetMessageBoxStapelErfolgreichGeloescht();

                        viewController.GetMessageBoxStapelLoeschenNichtMoeglich();
                }
            }
            else
            {
                viewController.GetMessageBoxKeinStapelGewaehlt();
            }
        }

        private void btn_KartenHinzufuegen_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                viewController.BuildHinzufuegenKarten(selectedItem).Show();
            }
            else
            {
                viewController.GetMessageBoxKeinStapelGewaehlt();
            }
        }
    }
}
