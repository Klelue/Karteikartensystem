﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace AnsichtsFenster.Fenster
{
    public partial class ChallengeView : Form
    {
        private Karte selectedKarte;
        private readonly List<Karte> kartenListe;
        private int richtigeAntworten;
        private int falscheAntworten;
        private int abschlussZeit;


        public ChallengeView(int abschlussZeit, int anzahl, Stapel aktuellerStapel, List<Karte> alleKarten)

        {
            InitializeComponent();

            kartenListe = RandomKartenFromAlleKarten(anzahl, alleKarten);

            selectedKarte = kartenListe[0];

            this.abschlussZeit = abschlussZeit * 60;

            timer_Anzeige.Start();
            lbl_Auswertung.Visible = false;
            FrageSetzen();

        }


        private void IsCorrect()
        {
            RadioButton checkedRadioButton = pnl_FrageAntwort.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true);
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
            if (selectedKarte == null)
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

            if (antworten.Count > 2)
            {
                radioButtonAntwort3.Visible = true;
                radioButtonAntwort3.Text = antworten[2];
            }
            else
            {
                radioButtonAntwort3.Visible = false;
            }


            if (antworten.Count > 3)
            {
                radioButtonAntwort4.Visible = true;
                radioButtonAntwort4.Text = antworten[3];
            }
            else
            {
                radioButtonAntwort4.Visible = false;
            }

            radioButtonAntwort1.Checked = true;
        }

        private List<string> RandomAntwortenAnordnung()
        {
            List<string> antworten = new List<string>();
            antworten.Add(selectedKarte.Antwort);
            antworten.Add(selectedKarte.FalschAntwort1);
            antworten.Add(selectedKarte.FalschAntwort2);
            antworten.Add(selectedKarte.FalschAntwort3);

            antworten = LeerEintraegeEntfernen(antworten);

            if (antworten.Count < 2)
            {
                antworten.Add("Keien Fakeantwort vorhanden");
            }

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

        private List<string> LeerEintraegeEntfernen(List<string> antworten)
        {
            List<string> listeOhneLeereintreage = antworten;

            for(int i = listeOhneLeereintreage.Count -1 ; i >= 0 ; i--)
            {
                if (listeOhneLeereintreage[i].Trim() == "")
                {
                    listeOhneLeereintreage.RemoveAt(i);
                }
            }

            return listeOhneLeereintreage;
        }

        private List<Karte> RandomKartenFromAlleKarten(int anzahl, List<Karte> alleKarten)
        {
            List<Karte> bearbeitendeList = alleKarten;
            List<Karte> randomKarten = new List<Karte>();

            Random random = new Random();
            for (int i = 0; i < anzahl; i++)
            {
               // bool minEineFalscheAntwort = false;
               // while (!minEineFalscheAntwort)
               // {

                    int randomIndex = random.Next(bearbeitendeList.Count - i);

                  //  if (bearbeitendeList[randomIndex].FalschAntwort1.Trim() != "")
                  //  {

                        randomKarten.Add(bearbeitendeList[randomIndex]);
                        bearbeitendeList.RemoveAt(randomIndex);

                 //       minEineFalscheAntwort = true;
                 //   }
                 //}
                
            }

            return randomKarten;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            NaechsteKarte();
            FrageSetzen();
        }

        private void NaechsteKarte()
        {

            IsCorrect();

            int indexAktuell = kartenListe.IndexOf(selectedKarte);

            if (indexAktuell + 1 < kartenListe.Count)
            {
                selectedKarte = kartenListe[indexAktuell + 1];
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
            lbl_Zeit.Visible = false;
            
            lbl_Auswertung.Text = "Richtige Antworten: " + richtigeAntworten +
                                  "\nFalsche Antworten: " + falscheAntworten +
                                  "\nUnbeantwortete Fragen: " + (kartenListe.Count - richtigeAntworten - falscheAntworten) +
                                  "\nRichtig in Prozent: " + ((richtigeAntworten * 100) / kartenListe.Count) + "%" +
                                  "\nDu hast " + ZeitUmrechnung(abschlussZeit) + " übrig gehabt";
        }

        private string ZeitUmrechnung(int zeitInSekunden)
        {
            int minuten = zeitInSekunden / 60;
            int sekunden = zeitInSekunden % 60;
            return minuten + " : " + sekunden;
        }

        private void timer_Anzeige_Tick(object sender, EventArgs e)
        {
            if (abschlussZeit > 0)
            {
                lbl_Zeit.Text = ZeitUmrechnung(abschlussZeit);
                abschlussZeit -= 1;
            }
            else
            {
                IsCorrect();
                Auswertung();
            }
        }
    }
}
