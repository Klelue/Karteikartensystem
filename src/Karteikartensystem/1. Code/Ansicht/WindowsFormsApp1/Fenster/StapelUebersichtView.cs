using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelUebersichtView : Form
    {
        private ListViewItem selectedItem;
        private StapelListController listController;
        private ViewController viewController;

        public StapelUebersichtView()
        {
            InitializeComponent();
            listController = new StapelListController();
            viewController = new ViewController();

            listView_Ausgabe = listController.CreateView(listView_Ausgabe);
            listView_Ausgabe = listController.UpdateView(listView_Ausgabe);
			
            txt_StapelSuche.Text = "Suche nach dein Stapel";
            txt_StapelSuche.ForeColor = Color.Gray;			
        }


        //public void ChallengeAbfrage()
        //{

        //    Form ChallengeWerte = new Form()
        //    {
        //        Width = 500,
        //        Height = 150,
        //        FormBorderStyle = FormBorderStyle.FixedDialog,
        //        Text = "Werte für die Challenge",
        //        StartPosition = FormStartPosition.CenterScreen
        //    };
        //    Label lbl_KartenAnzahl = new Label() { Left = 50, Top = 20, Width = 200, Text = "Gebe die Anzahl der Karten an" };
        //    TextBox txt_KartenAnzahl = new TextBox() { Left = 50, Top = 50, Width = 200 };
        //    Label lbl_Zeit = new Label() { Left = 250, Top = 20, Width = 200, Text = "Bearbeitungszeit in Minuten" };
        //    TextBox txt_Zeit = new TextBox() { Left = 250, Top = 50, Width = 200 };
        //    Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
        //    confirmation.Click += (sender, e) => { ChallengeWerte.Close(); };
        //    ChallengeWerte.Controls.Add(lbl_KartenAnzahl);
        //    ChallengeWerte.Controls.Add(txt_KartenAnzahl);
        //    ChallengeWerte.Controls.Add(txt_Zeit);
        //    ChallengeWerte.Controls.Add(lbl_Zeit);
        //    ChallengeWerte.Controls.Add(confirmation);
        //    ChallengeWerte.AcceptButton = confirmation;

        //    if (ChallengeWerte.ShowDialog() == DialogResult.OK)
        //    {
        //        if (Int32.TryParse(txt_Zeit.Text, out int time))
        //        {
        //            if (Int32.TryParse(txt_KartenAnzahl.Text, out int anzahl) && anzahl > 0)
        //            {
        //                Stapel[] alleStapel = new StapelRepository().GetAlleStapel();
        //                Stapel stapelMitAusgewähltenName =
        //                    alleStapel.First(stapel => stapel.Name == selectedItem.SubItems[0].Text);
        //                ChallengeView challengeView = new ChallengeView(time, anzahl, stapelMitAusgewähltenName.Id);
        //                challengeView.Show();
        //            }

        //            else
        //                viewController.ErrorMessageBox("Es wurde keine Gültige Anzahl angegeben");
        //        }

        //        else
        //            viewController.ErrorMessageBox("Es wurde keine richtige Zeit angegeben");
        //    }
        //}


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
            listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView_Ausgabe = txt_StapelSuche.Text.Trim() == "" 
                    ? listController.UpdateView(listView_Ausgabe) 
                    : listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);

                txt_StapelSuche.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView_Ausgabe = txt_StapelSuche.Text.Trim() == "" 
                ? listController.UpdateView(listView_Ausgabe) 
                : listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
            
            txt_StapelSuche.Clear();
        }

        private void txt_StapelSuche_Enter(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "Suche nach dein Stapel")
            {
                txt_StapelSuche.Clear();
                txt_StapelSuche.ForeColor = Color.Black;
            }
        }

        private void txt_StapelSuche_Leave(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "")
            {
                txt_StapelSuche.Text = "Suche nach dein Stapel";
                txt_StapelSuche.ForeColor = Color.Gray;
            }
        }


        /****************************************/

        private Point LastPoint;
        private void dachPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top  += e.Y - LastPoint.Y;
            }
        }
        private void dachPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ÜbersichtButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelUebersichtView().Show();
        }
        private void KarteBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HinzufuegenKarten().Show();
        }
        private void StapelBearbeitenButton_Click(object sender, EventArgs e)
        {

        }
        private void JetztLernenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView().Show();
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           // new ChallengeView().Show();
            new ChallengeAbfrageView().Show();
        }

        private void MinimierenButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
