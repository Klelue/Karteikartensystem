using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class ChallengeView : Form
    {
        private Karte selectedKarte;
        private List<Karte> kartenListe = new List<Karte>();
        private int richtigeAntworten;
        private int falscheAntworten;
        private int abschlussZeit;

        private Stapel selectedStapel;

        public ChallengeView()
        {
            InitializeComponent();
            Object[] alleStapel = new StapelRepository().GetAlleStapel();
            listBoxStapel.Items.AddRange(alleStapel);
            listBoxStapel.SetSelected(0, true);
            ZeitUpDown.Value = 1;
            AnzahlKartenUpDown.Value = 1;
            ZeitUpDown.Maximum = 30;
            AnzahlKartenUpDown.Maximum = 30;
            //  ZeitUpDown.Minimum = -100;            
            //  AnzahlKartenUpDown.Minimum = -100;
            btn_finish.Visible = false;
        }

        private void IsCorrect()
        {
            RadioButton checkedRadioButton = pnl_FrageAntwort.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true);
            if (selectedKarte.Antwort == checkedRadioButton.Text)
                richtigeAntworten++;
            else
                falscheAntworten++;
        }

        private void FrageSetzen()
        {
            if (selectedKarte == null)
            {
                Auswertung();
            }

            else
            {
                frage.Text = selectedKarte.Frage;
                RadioButtonsAnlegen();
            }
        }

        private void RadioButtonsAnlegen()
        {
            List<string> antworten = RandomAntwortenAnordnung();

            radioButtonAntwort1.Text = antworten[0];
            radioButtonAntwort2.Text = antworten[1];
            antwort1.Text = antworten[0];
            antwort2.Text = antworten[1];


            if (antworten.Count > 2)
            {
                radioButtonAntwort3.Visible = true;
                antwort3.Visible = true;
                antwort3.Text = antworten[2];
            }
            else
            {
                radioButtonAntwort3.Visible = false;
                antwort3.Visible = false;
            }

            if (antworten.Count > 3)
            {
                radioButtonAntwort4.Visible = true;
                antwort4.Visible = true;
                antwort4.Text = antworten[3];
            }
            else
            { 
                radioButtonAntwort4.Visible = false;
                antwort4.Visible = false;
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
                    listeOhneLeereintreage.RemoveAt(i);
            }

            return listeOhneLeereintreage;
        }

        private List<Karte> RandomKartenFromAlleKarten(int anzahl, List<Karte> alleChallengeKarten)
        {
            List<Karte> randomKarten = new List<Karte>();
            Random random = new Random();

            for (int i = 0; i < anzahl; i++)
            {
                int randomIndex = random.Next(alleChallengeKarten.Count);
                randomKarten.Add(alleChallengeKarten[randomIndex]);
                alleChallengeKarten.RemoveAt(randomIndex);
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
                selectedKarte = kartenListe[indexAktuell + 1];
            else
                selectedKarte = null;
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

        private void ÜbersichtButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelUebersichtView().Show();
        }
        private void KarteBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HinzufuegenKarten().Show();
        }
        private void StapelBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelBearbeitenView().Show();
        }
        private void JetztLernenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView().Show();
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChallengeView().Show();
        }

        private void MinimierenButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*************************************************/
        private void StartButton_Click(object sender, EventArgs e)
        {
            selectedStapel = (Stapel)listBoxStapel.SelectedItem;
            if (int.TryParse(ZeitUpDown.Text, out int zeitInMinuten) && zeitInMinuten > 0)
            {
                List<Karte> alleKartenEinesStapels = new KarteRepository().GetAlleKartenEinesStapels(selectedStapel.Id).ToList();
                List<Karte> alleChallengKartenEinesStapels = alleKartenEinesStapels.Where(karte => karte.ChallengeMode).ToList();

                if (int.TryParse(AnzahlKartenUpDown.Text, out int anzahlKarten) && anzahlKarten > 0 && anzahlKarten <= alleChallengKartenEinesStapels.Count)
                {
                    kartenListe = RandomKartenFromAlleKarten(anzahlKarten, alleChallengKartenEinesStapels);
                    selectedKarte = kartenListe[0];
                    this.abschlussZeit = zeitInMinuten * 60;
                    lbl_Auswertung.Visible = false;
                    ChallengeAbfragePanel.Visible = false;
                    pnl_FrageAntwort.Visible = true;
                    btn_finish.Visible = true;
                    timer_Anzeige.Start();
                    FrageSetzen();
                }

                else
                {
                    MessageBox.Show("Es wurde keine Gültige Anzahl an Karten angegeben", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Es wurde keine Gültige Zeit angegeben", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
