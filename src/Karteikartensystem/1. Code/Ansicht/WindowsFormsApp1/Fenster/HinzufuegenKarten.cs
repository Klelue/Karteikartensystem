using Model;
using System;
using System.Linq;
using Repositories;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using AnsichtsFenster.Controller;
using AnsichtsFenster.Utilities;

namespace AnsichtsFenster.Fenster
{
    public partial class HinzufuegenKarten : Form
    {
        private Karte selectedKarte;
        private List<Karte> alleKarten;
        private KarteRepository repository;
        private ViewController viewController;
       

        private long stapelId;
        private Stapel[] allesStapel = new StapelRepository().GetAlleStapel();

        public HinzufuegenKarten()
        {
            InitializeComponent();
            viewController = new ViewController();
            repository = new KarteRepository();
            alleKarten = new List<Karte>();
            comboBoxLaden();
            txt_KartenSuche.Text = "Suchen nach:";
            txt_KartenSuche.ForeColor = Color.Gray;
            richTxt_Vorderseite.Text = "Frage";
            richTxt_Vorderseite.ForeColor = Color.Gray;
            richTxt_Rueckseite.Text = "Richtige Antwort";
            richTxt_Rueckseite.ForeColor = Color.Gray;
            fackeAntwort1.Text = "Falsche Antwort 1 (Optional)";
            fackeAntwort1.ForeColor = Color.Gray;
            fackeAntwort2.Text = "Falsche Antwort 2 (Optional)";
            fackeAntwort2.ForeColor = Color.Gray;
            fackeAntwort3.Text = "Falsche Antwort 3 (Optional)";
            fackeAntwort3.ForeColor = Color.Gray;
        }

        private void comboBoxLaden() 
        {
            comboBox1.Items.Clear();
            foreach (Stapel stapel in allesStapel)
            {
                comboBox1.Items.Add(stapel.Name);
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string ausgewählteKategorie = comboBox1.SelectedItem.ToString();
            stapelId = allesStapel.FirstOrDefault(stapel => stapel.Name == ausgewählteKategorie).Id;
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();
            ListViewFormatieren();
        }

        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text.Trim() != "" && richTxt_Rueckseite.Text.Trim() != "")
            {
                if (repository.KarteHinzufügen(KartenAnlegen()))
                    viewController.OkMessageBox("Die karte wurde gespeichert", "Es hat geklappt");
            }
            else
                viewController.ExclamationsMessageBox("Es wurde nicht in eins oder in beiden Felder etwas geschrieben", "Sorry");
        }

        private Karte KartenAnlegen()
        {
            Karte karte = new Karte();
            karte.Frage = richTxt_Vorderseite.Text;
            karte.Antwort = richTxt_Rueckseite.Text;
            karte.FalschAntwort1 = fackeAntwort1.Text;
            karte.FalschAntwort2 = fackeAntwort2.Text;
            karte.FalschAntwort3 = fackeAntwort3.Text;
            karte.StapelId = stapelId;
            return karte;
        }

        private void ListViewFormatieren()
        {
            listView_KartenAnzeige.Clear();
            listView_KartenAnzeige.View = View.Details;
            listView_KartenAnzeige.Columns.Add("Fragen").Width = 550;

           // listView_KartenAnzeige.Columns.Add("Fragen");
           // listView_KartenAnzeige.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
           // listView_KartenAnzeige.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            KartenAnzeigen(alleKarten);
        }

        private void KartenAnzeigen(List<Karte> anzeigeList)
        {
            listView_KartenAnzeige.Items.Clear();
            listView_KartenAnzeige.Items.AddRange(anzeigeList.Select(karte => new ListViewItem(karte.Frage)).ToArray());
        }

        private void listView_KartenAnzeige_Click(object sender, EventArgs e)
        {
            selectedKarte = SelectedKarteAsKarte(listView_KartenAnzeige.SelectedItems[0].Text);
            richTxt_Vorderseite.Text = selectedKarte.Frage;
            richTxt_Rueckseite.Text = selectedKarte.Antwort;
            richTxt_Vorderseite.ForeColor = Color.Black;
            richTxt_Rueckseite.ForeColor = Color.Black;
        }

        private Karte SelectedKarteAsKarte(string karteFrage)
        {
            return alleKarten.Find(karte => karte.Frage == karteFrage);
        }

        private void KartenSucheAnzeigen(string suchbegriff)
        {
            List<Karte> ergebnisListe = StringSuchTool.GetSuchergebnis(suchbegriff, alleKarten);

            if (ergebnisListe.Count < 1)
            {
                viewController.InformationsMessageBox("Leider kein Eintrag gefunden");
                KartenAnzeigen(alleKarten);
            }

            else
               KartenAnzeigen(ergebnisListe);
        }

        private void listView_KartenAnzeige_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_KartenAnzeige.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                if (repository.KarteLöschen(selectedKarte.Id))
                {
                    selectedKarte = null;
                    viewController.OkMessageBox("Es hat geklappt", "Yeah");
                }
            }
        }

        private void btn_editieren_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                selectedKarte.Frage = richTxt_Vorderseite.Text;
                selectedKarte.Antwort = richTxt_Rueckseite.Text;
                selectedKarte.FalschAntwort1 = fackeAntwort1.Text;
                selectedKarte.FalschAntwort2 = fackeAntwort2.Text;
                selectedKarte.FalschAntwort3 = fackeAntwort3.Text;
                if (repository.KarteAktualisieren(selectedKarte))
                { 
                    selectedKarte = null;
                    viewController.OkMessageBox("Es hat geklappt", "Yeah");
                }
            }
        }


        private void txt_KartenSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_KartenSuche.Text.Trim() == "")
                    KartenAnzeigen(alleKarten);
                else
                    KartenSucheAnzeigen(txt_KartenSuche.Text);
                txt_KartenSuche.Clear();
                selectedKarte = null;
            }
        }

        private void txt_KartenSuche_Leave(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text == "")
            {
                txt_KartenSuche.Text = "Suchen nach:";
                txt_KartenSuche.ForeColor = Color.Gray;
            }
        }

        private void txt_KartenSuche_Enter(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text == "Suchen nach:")
            {
                txt_KartenSuche.Text = "";
                txt_KartenSuche.ForeColor = Color.Black;
            }
        }

        private void richTxt_Vorderseite_Leave(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text == "")
            {
                richTxt_Vorderseite.Text = "Frage";
                richTxt_Vorderseite.ForeColor = Color.Gray;
            }
        }

        private void richTxt_Vorderseite_Enter(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text == "Frage")
            {
                richTxt_Vorderseite.Clear();
                richTxt_Vorderseite.ForeColor = Color.Black;
            }
        }
        private void richTxt_Rueckseite_Leave(object sender, EventArgs e)
        {
            if (richTxt_Rueckseite.Text == "")
            {
                richTxt_Rueckseite.Text = "Richtige Antwort";
                richTxt_Rueckseite.ForeColor = Color.Gray;
            }
        }

        private void richTxt_Rueckseite_Enter(object sender, EventArgs e)
        {
            if (richTxt_Rueckseite.Text == "Richtige Antwort")
            {
                richTxt_Rueckseite.Clear();
                richTxt_Rueckseite.ForeColor = Color.Black;
            }
        }

        private void fackeAntwort1_Leave(object sender, EventArgs e)
        {
            if (fackeAntwort1.Text == "")
            {
                fackeAntwort1.Text = "Falsche Antwort 1 (Optional)";
                fackeAntwort1.ForeColor = Color.Gray;
            }
        }

        private void fackeAntwort1_Enter(object sender, EventArgs e)
        {
            if (fackeAntwort1.Text == "Falsche Antwort 1 (Optional)")
            {
                fackeAntwort1.Clear();
                fackeAntwort1.ForeColor = Color.Black;
            }
        }

        private void fackeAntwort2_Leave(object sender, EventArgs e)
        {
            if (fackeAntwort2.Text == "")
            {
                fackeAntwort2.Text = "Falsche Antwort 2 (Optional)";
                fackeAntwort2.ForeColor = Color.Gray;
            }
        }

        private void fackeAntwort2_Enter(object sender, EventArgs e)
        {
            if (fackeAntwort2.Text == "Falsche Antwort 2 (Optional)")
            {
                fackeAntwort2.Clear();
                fackeAntwort2.ForeColor = Color.Black;
            }
        }

        private void fackeAntwort3_Leave(object sender, EventArgs e)
        {
            if (fackeAntwort3.Text == "")
            {
                fackeAntwort3.Text = "Falsche Antwort 3 (Optional)";
                fackeAntwort3.ForeColor = Color.Gray;
            }
        }

        private void fackeAntwort3_Enter(object sender, EventArgs e)
        {
            if (fackeAntwort3.Text == "Falsche Antwort 3 (Optional)")
            {
                fackeAntwort3.Clear();
                fackeAntwort3.ForeColor = Color.Black;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text.Trim() == "")
                KartenAnzeigen(alleKarten);
            else
                KartenSucheAnzeigen(txt_KartenSuche.Text);
            txt_KartenSuche.Clear();
        }

        /*********************************/
        private Point lastPoint;

        private void dachPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void dachPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

    }
}
