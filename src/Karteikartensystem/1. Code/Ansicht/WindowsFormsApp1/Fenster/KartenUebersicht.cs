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

        public KartenUebersicht(string stapelName, int stapelId)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;

            KarteRepository repository = new KarteRepository();
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();

            if (alleKarten.Count >= 1)
            {
                selectedKarte = alleKarten[0];
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
            base.Dispose();
        }

        private void btn_Antwort_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            { 
                richTxt_Antwort.Text = selectedKarte.Antwort;
            }
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            if (alleKarten.Count > 1)
            {
                Random random = new Random();
                Karte newKarte = null;

                while (newKarte == null)
                {
                    int index = random.Next(alleKarten.Count);
                    if (alleKarten[index] != selectedKarte)
                    {
                        newKarte = alleKarten[index]; ;
                    }
                }

                selectedKarte = newKarte;
                lbl_FrageSetzen();
            }
           

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (alleKarten.Count > 1)
            {
                int aktuellerIdex = alleKarten.IndexOf(selectedKarte);

                if ( aktuellerIdex +1 < alleKarten.Count)
                {
                    selectedKarte = alleKarten[aktuellerIdex+1];
                }

                else
                {
                    selectedKarte = alleKarten[0];
                }

                lbl_FrageSetzen();
            }
        }

        private void lbl_FrageSetzen()
        {
            lbl_Frage.Text = "Frage: " + selectedKarte.Frage;
            richTxt_Antwort.Clear();
        }

    }
}
