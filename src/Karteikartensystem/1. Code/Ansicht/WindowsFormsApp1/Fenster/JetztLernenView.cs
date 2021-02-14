using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class JetztLernenView : Form
    {
        private Point lastPoint;

        public JetztLernenView(Point p)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Left += p.X - lastPoint.X;
            this.Top  += p.Y - lastPoint.Y;

            Object[] alleStapel = new StapelRepository().GetAlleStapel();
            listBoxLampe.Items.AddRange(alleStapel);
        }

        private void StapelBoxClick(object sender, EventArgs e)
        {
            Stapel selectedStapel = (Stapel) listBoxLampe.SelectedItem;

            KartenUebersicht kartenUebersicht = new KartenUebersicht(selectedStapel, this.DesktopLocation);

            this.Hide();
            kartenUebersicht.Show();
        }


        private void dachPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void dachPanel_MouseDown(object sender, MouseEventArgs e)
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
