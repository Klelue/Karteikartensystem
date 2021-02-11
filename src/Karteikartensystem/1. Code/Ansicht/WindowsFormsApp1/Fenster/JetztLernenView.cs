using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class JetztLernenView : Form
    {
        public JetztLernenView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            Object[] alleStapel = new StapelRepository().GetAlleStapel();
            listBoxLampe.Items.AddRange(alleStapel);
        }

        private void StapelBoxClick(object sender, EventArgs e)
        {
            Stapel selectedStapel = (Stapel) listBoxLampe.SelectedItem;

            KartenUebersicht kartenUebersicht = new KartenUebersicht(selectedStapel);

            this.Hide();
            kartenUebersicht.Show();
        }


        private Point LastPoint;
        private void dachPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
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
