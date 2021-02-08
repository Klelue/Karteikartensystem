using System;
using System.Drawing.Text;
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
                    listView_Ausgabe = listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
                }
                txt_StapelSuche.Clear();
            }
        }

        // TODO schauen, ob Stapel mindestens eine Karte besitzt
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
            selectedItem = listController.SelectItem(listView_Ausgabe);
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
                if (viewController.ShowMessageBoxChoiceStapelLoeschen(selectedItem))
                {
                    listView_Ausgabe = listController.DeleteItem(listView_Ausgabe, selectedItem, out bool geloescht);
                    if (geloescht)
                    {
                        viewController.ShowMessageBoxErfolgreichGeloescht();
                    }
                    else
                    {
                        viewController.ShowMessageBoxLoeschenNichtErfolgreich();
                    }
                }
            }
            else
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
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
                viewController.ShowMessageBoxKeinElementGewaehlt();
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

        private void StapelHinzufuegen(string stapelname)
        {
            if (stapelname.Trim().Length != 0)
            {
                Stapel stapel = new Stapel();
                stapel.Name = stapelname;

                if (new Repositories.StapelRepository().StapelHinzufügen(stapel))
                {
                    viewController.ShowMessageBoxHinzufuegenErfolgreich();
                }
                else
                {
                    viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
                }
            }
            else
            {
                viewController.ShowMessageBoxKeineEingabe();
            }
        }

        private void JetztLernenEvent(object sender, EventArgs e)
        {
            JetztLernenView jetztLernenView = new JetztLernenView();

            jetztLernenView.Show();
        }

        private void btn_Challenge_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                ChallengeAbfrage();
            }

            else
            {
                ErrorMessageBox("Kein Stapel ausgewählt");
            }
        }

        public void ChallengeAbfrage()
        {
            
            Form ChallengeWerte = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Werte für die Challenge",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label lbl_KartenAnzahl = new Label() { Left = 50, Top = 20, Width = 200, Text = "Gebe die Anzahl der Karten an" };
            TextBox txt_KartenAnzahl = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Label lbl_Zeit = new Label() { Left = 250, Top = 20, Width = 200, Text = "Bearbeitungszeit in Minuten" };
            TextBox txt_Zeit = new TextBox() { Left = 250, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { ChallengeWerte.Close(); };
            ChallengeWerte.Controls.Add(lbl_KartenAnzahl);
            ChallengeWerte.Controls.Add(txt_KartenAnzahl);
            ChallengeWerte.Controls.Add(txt_Zeit);
            ChallengeWerte.Controls.Add(lbl_Zeit);
            ChallengeWerte.Controls.Add(confirmation);
            ChallengeWerte.AcceptButton = confirmation;

            if (ChallengeWerte.ShowDialog() == DialogResult.OK)
            {
                if (Int32.TryParse(txt_Zeit.Text, out int time))
                {
                    if (Int32.TryParse(txt_KartenAnzahl.Text, out int anzahl) && anzahl > 0)
                    {
                        ChallengeView challengeView = new ChallengeView(time, anzahl, Convert.ToInt32(selectedItem.SubItems[0].Text));
                        challengeView.Show();
                    }

                    else
                    {
                        ErrorMessageBox("Es wurde keine Gültige Anzahl angegeben");
                    }
                }

                else
                {
                    ErrorMessageBox("Es wurde keine richtige Zeit angegeben");
                }
            }
        }

        private static void ErrorMessageBox(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
