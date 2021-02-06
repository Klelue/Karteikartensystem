using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Repositories;
using Model;
using System.Linq;
using AnsichtsFenster.KartenManager;


namespace AnsichtsFenster.Fenster
{
    public partial class KartenUebersicht : Form
    {
        private List<Karte> alleKarten;
        private Karte selectedKarte;
        private StapelManager stapelManager;
        private KarteRepository repository;

        public KartenUebersicht(string stapelName, int stapelId)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;

            repository = new KarteRepository();
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();
            stapelManager = new StapelManager(alleKarten.ToArray());

            if (alleKarten.Count >= 1)
            {
                selectedKarte = stapelManager.GetNextKarte();
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
            Karte[] karten = stapelManager.getAlleKarten();

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
                stapelManager.Reset();
                selectedKarte = stapelManager.GetNextKarte();
            }

            lbl_Frage.Text = "Frage: " + selectedKarte.Frage;
            richTxt_Antwort.Clear();
        }

  

        private void btn_Nochmal(object sender, EventArgs e)
        {
            stapelManager.AddZuSchwereKarten(selectedKarte);
            selectedKarte = stapelManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }

        private void btn_Gut_Click(object sender, EventArgs e)
        {
            stapelManager.AddZuMittelKarten(selectedKarte);
            selectedKarte = stapelManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }

        private void btn_Einfach(object sender, EventArgs e)
        {
            stapelManager.AddZuLeichteKarten(selectedKarte);
            selectedKarte = stapelManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }

        private void btn_nichtNochmal(object sender, EventArgs e)
        {
            stapelManager.AddZuGelerntenKarten(selectedKarte);
            selectedKarte = stapelManager.GetNextKarte();
            lbl_FrageSetzen();
            pnl_Antwort.Visible = false;
            btn_Antwort.Visible = true;
        }
    }
}
