using System;
using System.Drawing;
using System.Windows.Forms;
using AnsichtsFenster.Controller;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelUebersichtView : Form
    {
        private StapelListController listController;
        private ViewController viewController;
      

        private Point letzteMouseKoordinaten;

        public StapelUebersichtView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            listController = new StapelListController();
            viewController = new ViewController();

            listView_Ausgabe = listController.CreateView(listView_Ausgabe);
            listView_Ausgabe = listController.UpdateView(listView_Ausgabe);

            txt_StapelSuche.Text = "Stapel suchen";
            txt_StapelSuche.ForeColor = Color.Gray;
        }

        private void listView_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            viewController.BuildKartenUebersicht(listController.SelectStapel(listView_Ausgabe)).Show();
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void textBox_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView_Ausgabe = txt_StapelSuche.Text.Trim() == ""
                    ? listController.UpdateView(listView_Ausgabe)
                    : listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);

                txt_StapelSuche.Clear();
            }
        }

        private void pictureBox_Lupe_Click(object sender, EventArgs e)
        {
            listView_Ausgabe = txt_StapelSuche.Text.Trim() == ""
                ? listController.UpdateView(listView_Ausgabe)
                : listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);

            txt_StapelSuche.Clear();
        }

        private void textBox_StapelSuche_Enter(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "Stapel suchen")
            {
                txt_StapelSuche.Clear();
                txt_StapelSuche.ForeColor = Color.Black;
            }
        }

        private void textBox_StapelSuche_Leave(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "")
            {
                txt_StapelSuche.Text = "Stapel suchen";
                txt_StapelSuche.ForeColor = Color.Gray;
            }
        }

        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                 this.Left += e.X - letzteMouseKoordinaten.X;
                 this.Top += e.Y - letzteMouseKoordinaten.Y;
            }
        }
        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            letzteMouseKoordinaten = new Point(e.X, e.Y);
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
            this.Hide();
            new StapelBearbeitenView().Show();
        }
        private void JetztLernenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView().Show();
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChallengeView().Show();
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
