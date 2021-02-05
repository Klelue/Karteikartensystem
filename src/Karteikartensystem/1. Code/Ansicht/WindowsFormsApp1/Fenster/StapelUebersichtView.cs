using System;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using Model;

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
            string stapelName = ShowDialog("Gib den Namen des Stapels an", "Stapel hinzufügen");
            if (stapelName != "Es wurde nichts angegeben")
            {
                StapelHinzufuegen(stapelName);
            }
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


        //TODO selectedItem von string zu Stapel ändern
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

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "Es wurde nichts angegeben";
        }

        private void StapelHinzufuegen(string Stapelname)
        {
            if (Stapelname.Trim().Length != 0)
            {
                Stapel stapel = new Stapel();
                stapel.Name = Stapelname;

                if (new Repositories.StapelRepository().StapelHinzufügen(stapel))
                {
                    MessageBox.Show("Erfolgreich hinzugefügt", "Yippy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Es hat leider nicht geklappt", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Es wurde kein Stapelname angegeben", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
