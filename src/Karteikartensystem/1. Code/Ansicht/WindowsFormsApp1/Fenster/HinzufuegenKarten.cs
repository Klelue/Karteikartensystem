using Model;
using System;
using System.Linq;
using Repositories;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using AnsichtsFenster.Utilities;

namespace AnsichtsFenster.Fenster
{
    public partial class HinzufuegenKarten : Form
    {
        private List<Karte> alleKarten;
        private Karte selectedKarte;
        private KarteRepository repository;
        private int stapelId;
        private Stapel[] allesStapel = new StapelRepository().GetAlleStapel();

        public HinzufuegenKarten(string stapelName, int stapelId)
        {
            InitializeComponent();
            this.stapelId = stapelId;
            repository = new KarteRepository();
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();
            ListViewFormatieren();
        }


        public HinzufuegenKarten()
        {
            InitializeComponent();
            repository = new KarteRepository();
            alleKarten = new List<Karte>();
            comboBoxLaden();
            txt_KartenSuche.Text = "Suchen nach:";
            txt_KartenSuche.ForeColor = Color.Gray;
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
                    MessageBox.Show("Die karte wurde gespeichert", "Es hat geklappt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Es wurde nicht in eins oder in beiden Felder etwas geschrieben", "Sorry",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Karte KartenAnlegen()
        {
            Karte karte = new Karte();
            karte.Frage = richTxt_Vorderseite.Text;
            karte.Antwort = richTxt_Rueckseite.Text;
            karte.StapelId = stapelId;
            return karte;
        }

        private void ListViewFormatieren()
        {
            listView_KartenAnzeige.Clear();
            listView_KartenAnzeige.View = View.Details;
            listView_KartenAnzeige.Columns.Add("Fragen");
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
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Es hat geklappt", "Yeah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                selectedKarte.Frage = richTxt_Vorderseite.Text;
                selectedKarte.Antwort = richTxt_Rueckseite.Text;
                if (repository.KarteAktualisieren(selectedKarte))
                { 
                    selectedKarte = null;
                    MessageBox.Show("Es hat geklappt", "Yeah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }           
            }
        }

/***************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StapelUebersichtView stubvView = new StapelUebersichtView();
            stubvView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HinzufuegenKarten hkView = new HinzufuegenKarten();
            hkView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            JetztLernenView elv = new JetztLernenView();
            elv.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text.Trim() == "")
                KartenAnzeigen(alleKarten);
            else
                KartenSucheAnzeigen(txt_KartenSuche.Text);
            txt_KartenSuche.Clear();
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
