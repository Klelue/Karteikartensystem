
namespace AnsichtsFenster.Fenster
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Controller;
    public partial class StapelUebersichtView : Form
    {
        private readonly StapelListController listController;
        private readonly ViewController viewController;
        private Point lastPoint;

        public StapelUebersichtView(Point p)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Left += p.X - lastPoint.X;
            this.Top += p.Y - lastPoint.Y;

            listController = new StapelListController();
            viewController = new ViewController();

            listView_Ausgabe = listController.CreateView(listView_Ausgabe);
            listView_Ausgabe = listController.UpdateView(listView_Ausgabe);

            txt_StapelSuche.Text = "Stapel suchen";
            txt_StapelSuche.ForeColor = Color.Gray;
        }

        private void listView_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            viewController.BuildKartenUebersicht(listController.SelectStapel(listView_Ausgabe), 
                this.DesktopLocation).Show();
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void TextBoxStapelSucheKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView_Ausgabe = txt_StapelSuche.Text.Trim() == ""
                    ? listController.UpdateView(listView_Ausgabe)
                    : listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);

                txt_StapelSuche.Clear();
            }
        }

        private void PictureBoxLupeClick(object sender, EventArgs e)
        {
            listView_Ausgabe = txt_StapelSuche.Text.Trim() == ""
                ? listController.UpdateView(listView_Ausgabe)
                : listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);

            txt_StapelSuche.Clear();
        }

        private void TextBoxStapelSucheEnter(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "Stapel suchen")
            {
                txt_StapelSuche.Clear();
                txt_StapelSuche.ForeColor = Color.Black;
            }
        }

        private void TextBoxStapelSucheLeave(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "")
            {
                txt_StapelSuche.Text = "Stapel suchen";
                txt_StapelSuche.ForeColor = Color.Gray;
            }
        }

        private void MenuMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                 this.Left += e.X - lastPoint.X;
                 this.Top += e.Y - lastPoint.Y;
            }
        }
        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void ÜbersichtButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelUebersichtView(this.DesktopLocation).Show();
        }
        private void KarteBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HinzufuegenKarten(this.DesktopLocation).Show();
        }
        private void StapelBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelBearbeitenView(this.DesktopLocation).Show();
        }
        private void JetztLernenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView(this.DesktopLocation).Show();
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChallengeView(this.DesktopLocation).Show();
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
