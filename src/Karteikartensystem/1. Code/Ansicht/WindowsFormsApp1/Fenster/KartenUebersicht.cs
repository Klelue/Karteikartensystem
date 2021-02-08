using System;
using System.Windows.Forms;
using Repositories;
using Model;
using System.Linq;
using AnsichtsFenster.Utilities;


namespace AnsichtsFenster.Fenster
{
    public partial class KartenUebersicht : Form
    {
        private Karte selectedKarte;
        private KartenManager kartenManager;
        private KarteRepository repository;
        private Stoppuhr stoppuhr;

        public KartenUebersicht(string stapelName, int stapelId)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;

            repository = new KarteRepository();
            var alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();
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

            lblZeitAngabe.Parent = imgParty;
            stoppuhr = new Stoppuhr();
            stoppuhr.Start();
            lblZeitAngabe.Visible = false;
            FrageSetzen();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Karte[] karten = kartenManager.GetAlleKarten();

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

            imgParty.Visible = false;
            selectedKarte = kartenManager.GetNextKarte();
            btnEinfach.Visible = false;
            btnNochmal.Visible = false;
            btnGut.Visible = false;
            btnNichtNochmal.Visible = false;

            if (selectedKarte == null)
            {
                imgParty.Visible = true;
                lblZeitAngabe.Visible = true;
                lblZeitAngabe.Text = $" Herzlichen Glückwunsch sie haben den Stapel in {stoppuhr.GetZeit()} Minuten gelernt";
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
            lblZeitAngabe.Visible = false;
            FrageSetzen();
        }
    }
}
