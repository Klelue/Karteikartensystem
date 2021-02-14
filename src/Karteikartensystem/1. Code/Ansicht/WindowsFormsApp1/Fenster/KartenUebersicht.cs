
namespace AnsichtsFenster.Fenster
{
    using System.Collections.Generic;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Controller;
    using Utilities;
    using Model;
    using Repositories;

    public partial class KartenUebersicht : Form
    {
        private Karte selectedKarte;
        private readonly Stapel selectetStapel;
        private readonly KartenManager kartenManager;
        private readonly KarteController karteController;
        private readonly Stoppuhr stoppuhr;
        private Point lezteMouseKoordinaten;

        public KartenUebersicht(Stapel stapel)
        {
            InitializeComponent();

            // window position fix
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.selectetStapel = stapel;
            this.lbl_StapelName.Text = stapel.Name; 
            this.karteController = new KarteController();
            List<Karte> alleKarten = karteController.GetAlleKartenEinesStapels(stapel.Id);
            this.kartenManager = KartenManager.CreateInstance(alleKarten.ToArray());

            if (alleKarten.Count >= 1)
            {
                selectedKarte = kartenManager.GetNextKarte();
            }
            else // falls keine Karten vorhanden
            {
                Karte karte = new Karte
                {
                    Frage = "Leider ist diese Liste leer",
                    Antwort = "Da keine Karten vorhanden sind, \n sind auch keine Antworten vorhanden"
                };
                selectedKarte = karte;
            }

            this.stoppuhr = new Stoppuhr();
            this.stoppuhr.Start();
            FrageSetzen();
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
                lblAuswertungOben.Text = @"Herzlichen Glückwunsch!";
                lblAuswertungUnten.Text = $@"Sie haben den Stapel {selectetStapel.Name} in {stoppuhr.GetZeit()} Minuten gelernt";
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

        private void BtnHomeClick(object sender, EventArgs e)
        {
            this.stoppuhr.Stop();
            Karte[] karten = kartenManager.GetAlleKarten();
            selectetStapel.GelernteZeitInMinuten += stoppuhr.GetZeit();

            new StapelRepository().StapelAktualisieren(selectetStapel);
            foreach (Karte karte in karten)
            {
                this.karteController.Aktualisieren(karte);
            }

            stoppuhr.Stop();
            this.Hide();
            StapelUebersichtView stubvView = new StapelUebersichtView();
            stubvView.Show();
        }

        private void BtnAntwortClick(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                AntwortSetzen();
            }
        }

        private void BtnNochmalClick(object sender, EventArgs e)
        {
            this.kartenManager.AddZuSchwereKarten(selectedKarte);
            FrageSetzen();
        }

        private void BtnGutClick(object sender, EventArgs e)
        {
            this.kartenManager.AddZuMittelKarten(selectedKarte);
            FrageSetzen();
        }

        private void BtnEinfachClick(object sender, EventArgs e)
        {
            this.kartenManager.AddZuLeichteKarten(selectedKarte);
            FrageSetzen();
        }

        private void BtnNichtNochmalClick(object sender, EventArgs e)
        {
            this.kartenManager.AddZuGelerntenKarten(selectedKarte);
            FrageSetzen();
        }

        private void BtnErneutLernenClick(object sender, EventArgs e)
        {
            this.kartenManager.Reset();
            richTxt.Visible = true;
            lblAuswertungUnten.Visible = false;
            FrageSetzen();
        }

        private void MenuMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lezteMouseKoordinaten.X;
                this.Top += e.Y - lezteMouseKoordinaten.Y;
            }
        }
        private void MenuMouseDown(object sender, MouseEventArgs e)
        {
            this.lezteMouseKoordinaten = new Point(e.X, e.Y);
        }

        private void StapelWählenButtonClick(object sender, EventArgs e)
        {
           
            selectetStapel.GelernteZeitInMinuten += stoppuhr.GetZeit();
            new StapelRepository().StapelAktualisieren(selectetStapel);


            this.Hide();
            new JetztLernenView().Show();
        }

        private void MinimierenButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
