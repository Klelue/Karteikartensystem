using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AnsichtsFenster.Utilities;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class ChallengeView : Form
    {
        private Karte selectedKarte;
        private KarteRepository repository;
        private List<Karte> alleKarten;
        private int richtigeAntworten;
        private int falscheAntworten;
        private int abschlussZeit;


        public ChallengeView(int abschlussZeit, int anzahl, long stapelId)

        {
            InitializeComponent();
            repository = new KarteRepository();
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

            this.abschlussZeit = (abschlussZeit * 60 * 1000);
            TimerAnzeige();

            lbl_Auswertung.Visible = false;
            FrageSetzen();
            
        }

        private void TimerAnzeige()
        {
            timer_Anzeige.Interval = 1000;
            timer_Anzeige.Start();
        }

        private void IsCorrect()
        {
            var checkedRadioButton = pnl_FrageAntwort.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true);
            if (selectedKarte.Antwort == checkedRadioButton.Text)
            {
                richtigeAntworten++;
            }
            else
            {
                falscheAntworten++;
            }
        }


        private void FrageSetzen()
        {
            radioButtonAntwort1.Checked = true;


            if (selectedKarte == null)  //|| stoppuhr.GetZeit() <= abschlussZeit)
            {
                Auswertung();
            }

            else
            {
                lbl_Frage.Text = selectedKarte.Frage;
               
                RadioButtonsAnlegen();
            }
        }

        private void RadioButtonsAnlegen()
        {
            List<string> antworten = RandomAntwortenAnordnung();
            radioButtonAntwort1.Text = antworten[0];
            radioButtonAntwort2.Text = antworten[1];
            radioButtonAntwort3.Text = antworten[2];
            radioButtonAntwort4.Text = antworten[3];

        }

        private List<string> RandomAntwortenAnordnung()
        {
            List<string> antworten = new List<string>();
            antworten.Add(selectedKarte.Antwort);
           // antworten.Add(selectedKarte.FakeAntwort1);
           // antworten.Add(selectedKarte.FakeAntwort2);
           // antworten.Add(selectedKarte.FakeAntwort3);

           antworten.Add("test1");
           antworten.Add("test2");
           antworten.Add("test3");

           Random random = new Random();

           for (int i = 0; i < antworten.Count; i++)
           {
               int j = random.Next(antworten.Count);
               string antwort = antworten[j];
               antworten[j] = antworten[i];
               antworten[i] = antwort;
           }

            return antworten;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            NaechsteKarte();
            FrageSetzen();
        }

        private void NaechsteKarte()
        {

            IsCorrect();
            int indexAktuell = alleKarten.IndexOf(selectedKarte);
            if (indexAktuell+1 < alleKarten.Count)
            {
                selectedKarte = alleKarten[indexAktuell + 1];
            }
            else
            {
                selectedKarte = null;
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            IsCorrect();
            Auswertung();
        }

        private void Auswertung()
        {
            timer_Anzeige.Stop();
            pnl_FrageAntwort.Visible = false;
            btn_finish.Visible = false;
            lbl_Auswertung.Visible = true;
            
            
            lbl_Auswertung.Text = "Richtige Antworten: " + richtigeAntworten +
                                  "\nFalsche Antworten: " + falscheAntworten + 
                                  "\nRichtig in Prozent: " + ((richtigeAntworten * 100 )/ alleKarten.Count) + "%"+
                                  "\nDu hast " + ZeitUmrechnung(abschlussZeit) + " gebraucht";
            
        }

        private string ZeitUmrechnung(int zeitInMiliSekunden)
        {
            int zeitInSekunden = zeitInMiliSekunden / 1000 -1;
            int minuten = zeitInSekunden / 60;
            int sekunden = zeitInSekunden & 60;
            return minuten + " : " + sekunden;


        }

        private void timer_Anzeige_Tick(object sender, EventArgs e)
        {
            if (abschlussZeit > 0)
            {
                lbl_Zeit.Text = ZeitUmrechnung(abschlussZeit);
                abschlussZeit -= 1000;
            }
            else
            {
                IsCorrect();
                Auswertung();
            }
        }
    }
}
