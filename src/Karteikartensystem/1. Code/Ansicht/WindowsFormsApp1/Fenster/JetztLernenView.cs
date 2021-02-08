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

        /******************************/
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StapelUebersichtView stubvView = new StapelUebersichtView();
            stubvView.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HinzufuegenKarten hkView = new HinzufuegenKarten();
            hkView.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            JetztLernenView elv = new JetztLernenView();
            elv.Show();
        }
        private void ChallengeButton_Click(object sender, EventArgs e)
        {

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
