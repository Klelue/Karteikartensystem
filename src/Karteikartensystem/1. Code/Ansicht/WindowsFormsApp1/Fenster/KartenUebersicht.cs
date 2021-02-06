using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Repositories;
using Model;
using System.Linq;
using AnsichtsFenster.Utilities;


namespace AnsichtsFenster.Fenster
{
    public partial class KartenUebersicht : Form
    {
        private List<Karte> alleKarten;
        private Karte selectedKarte;
        private KartenManager _kartenManager;
        private KarteRepository repository;

        public KartenUebersicht(string stapelName, int stapelId)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;

            repository = new KarteRepository();
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();
            _kartenManager = new KartenManager(alleKarten.ToArray());

            if (alleKarten.Count >= 1)
            {
                selectedKarte = _kartenManager.GetNextKarte();
            }
            else // falls keine Karten vorhanden
            {
                Karte karte = new Karte();
                karte.Frage = "Leider ist diese Liste leer";
                karte.Antwort = "Da keine Karten vorhanden sind, \n sind auch keine Antworten vorhanden";
                selectedKarte = karte;
            }

            lbl_FrageSetzen();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Karte[] karten = _kartenManager.GetAlleKarten();

            foreach (Karte karte in karten)
            {
                repository.KarteAktualisieren(karte);
            }

            base.Dispose();
        }

        private void btn_Antwort_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                pnl_Antwort.Visible = true;
                richTxt_Antwort.Text = selectedKarte.Antwort;
                btn_Antwort.Visible = false;
            }
        }

        private void lbl_FrageSetzen()
        {
            if (selectedKarte == null)
            {
                MessageBox.Show("Sie haben alle Karten aus diesen Stapel gelernt");
                _kartenManager.Reset();
                selectedKarte = _kartenManager.GetNextKarte();
            }

            lbl_Frage.Text = "Frage: " + selectedKarte.Frage;
            richTxt_Antwort.Clear();
        }

  

        private void btn_Nochmal(object sender, EventArgs e)
        {
            _kartenManager.AddZuSchwereKarten(selectedKarte);
            selectedKarte = _kartenManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }

        private void btn_Gut_Click(object sender, EventArgs e)
        {
            _kartenManager.AddZuMittelKarten(selectedKarte);
            selectedKarte = _kartenManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }

        private void btn_Einfach(object sender, EventArgs e)
        {
            _kartenManager.AddZuLeichteKarten(selectedKarte);
            selectedKarte = _kartenManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }

        private void btn_nichtNochmal(object sender, EventArgs e)
        {
            _kartenManager.AddZuGelerntenKarten(selectedKarte);
            selectedKarte = _kartenManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }
    }
}
