using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Repositories;
using System.Windows.Forms;
using Model;
using AnsichtsFenster.Utilities;

namespace AnsichtsFenster.Fenster
{
    public partial class HinzufuegenKarten : Form
    {
        private readonly List<Karte> alleKarten;
        private Karte selectedKarte = null;
        private KarteRepository repository;
        private readonly int stapelID;

        public HinzufuegenKarten(string stapelName, int stapelId)
        {

            InitializeComponent();

            this.stapelID = stapelId;
            repository = new KarteRepository();
            alleKarten = repository.GetAlleKartenEinesStapels(stapelId).ToList();

            ListViewFormatieren();

            lbl_StapelName.Text = "Du befindest dich im Stapel: " + stapelName;
        }

        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text.Trim() != "" && richTxt_Rueckseite.Text.Trim() != "")
            {
                if (repository.KarteHinzufügen(KartenAnlegen()))
                {
                    MessageBox.Show("Die karte wurde gespeichert", "Es hat geklappt", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }

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
            karte.StapelId = stapelID;

            return karte;
        }

        private void ListViewFormatieren()
        {
            listView_KartenAnzeige.View = View.Details;
            listView_KartenAnzeige.Columns.Add("Fragen");
            KartenAnzeigen(alleKarten);
        }

        private void KartenAnzeigen(List<Karte> anzeigeList)
        {
            List<ListViewItem> listViewItem = new List<ListViewItem>();

            foreach (Karte karte in anzeigeList)
            {
                listViewItem.Add(new ListViewItem(karte.Frage));
            }

            listView_KartenAnzeige.Items.Clear();
            listView_KartenAnzeige.Items.AddRange(listViewItem.ToArray());
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
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KartenAnzeigen(alleKarten);
            }

            else
            {
                KartenAnzeigen(ergebnisListe);
            }
        }

        private void txt_KartenSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_KartenSuche.Text.Trim() == "")
                {
                    KartenAnzeigen(alleKarten);
                }

                else
                {
                    KartenSucheAnzeigen(txt_KartenSuche.Text);
                }

                txt_KartenSuche.Clear();
                selectedKarte = null;
            }
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
    }
}
