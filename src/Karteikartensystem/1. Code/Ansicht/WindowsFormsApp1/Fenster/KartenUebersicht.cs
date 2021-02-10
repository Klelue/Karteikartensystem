using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Utilities;
using Model;
using Repositories;


namespace AnsichtsFenster.Fenster
{
    public partial class KartenUebersicht : Form
    {
        private Karte selectedKarte;
        private Stapel selectetStapel;
        private KartenManager kartenManager;
        private KarteRepository repository;
        private Stoppuhr stoppuhr;

        public KartenUebersicht(Stapel stapel)
        {
            InitializeComponent();
            selectetStapel = stapel;
            lbl_StapelName.Text = stapel.Name;

            repository = new KarteRepository();
            var alleKarten = repository.GetAlleKartenEinesStapels(stapel.Id).ToList();
            kartenManager = new KartenManager(alleKarten.ToArray());

            if (alleKarten.Count >= 1)
            {
                selectedKarte = kartenManager.GetNextKarte();
            }
            else // falls keine Karten vorhanden
            {
                Karte karte = new Karte();
                karte.Frage = "Leider ist diese Liste leer";
                karte.Antwort = "Da keine Karten vorhanden sind, \n sind auch keine Antworten vorhanden";
                selectedKarte = karte;
            }

          //  lblZeitAngabe.Parent = imgParty;
            stoppuhr = new Stoppuhr();
            stoppuhr.Start();
            FrageSetzen();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            stoppuhr.Stop();

            Karte[] karten = kartenManager.GetAlleKarten();

            selectetStapel.GelernteZeitInMinuten = stoppuhr.GetZeit();

            new StapelRepository().StapelAktualisieren(selectetStapel);

            foreach (Karte karte in karten)
            {
                repository.KarteAktualisieren(karte);
            }

            stoppuhr.Stop();

            // base.Dispose();
            this.Hide();
            StapelUebersichtView stubvView = new StapelUebersichtView();
            stubvView.Show();

        }

        private void btn_Antwort_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                AntwortSetzen();
            }
        }

        private void AntwortSetzen()
        {
            richTxt.Text = selectedKarte.Antwort;
            btn_Antwort.Visible = false;
            btnEinfach.Visible = true;
            btnNochmal.Visible = true;
            btnGut.Visible = true;
            btnNichtNochmal.Visible = true;
        }

        private void FrageSetzen()
        {

           // imgParty.Visible = false;
            selectedKarte = kartenManager.GetNextKarte();
            btnEinfach.Visible = false;
            btnNochmal.Visible = false;
            btnGut.Visible = false;
            btnNichtNochmal.Visible = false;
            lblAuswertungUnten.Visible = false;
            lblAuswertungOben.Visible = false;
            imgParty.Visible = false;

            if (selectedKarte == null)
            {
                imgParty.Visible = true;
                lblAuswertungOben.Visible = true;
                lblAuswertungUnten.Visible = true;
                lblAuswertungOben.Text = "Herzlichen Glückwunsch!";
                lblAuswertungUnten.Text = $"Sie haben den Stapel {selectetStapel.Name} in {stoppuhr.GetZeit()} Minuten gelernt";
                richTxt.Visible = false;
                btnStapelErneutLernen.Visible = true;
                btn_Antwort.Visible = false;
            }

            else
            {
                richTxt.Text = selectedKarte.Frage;
                btn_Antwort.Visible = true;
                btnStapelErneutLernen.Visible = false;
            }

        }

        private void btn_Nochmal(object sender, EventArgs e)
        {
            kartenManager.AddZuSchwereKarten(selectedKarte);
            FrageSetzen();
        }

        private void btn_Gut_Click(object sender, EventArgs e)
        {
            kartenManager.AddZuMittelKarten(selectedKarte);
            FrageSetzen();
        }

        private void btn_Einfach(object sender, EventArgs e)
        {
            kartenManager.AddZuLeichteKarten(selectedKarte);
            FrageSetzen();
        }

        private void btn_nichtNochmal(object sender, EventArgs e)
        {
            kartenManager.AddZuGelerntenKarten(selectedKarte);
            FrageSetzen();
        }

        private void btnErneutLernen(object sender, EventArgs e)
        {
            kartenManager.Reset();
            richTxt.Visible = true;
            lblAuswertungUnten.Visible = false;
            FrageSetzen();
        }


        /****************************************/
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

        private void StapelWählenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView().Show();
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
