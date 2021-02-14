
namespace AnsichtsFenster.Fenster
{
    using Model;
    using System;
    using System.Linq;
    using Repositories;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Drawing;
    using Controller;
    using Utilities;
    public partial class HinzufuegenKarten : Form
    {
        private Karte selectedKarte;
        private List<Karte> alleKarten;
        private readonly StapelController stapelController;
        private readonly KarteController karteController;
        private readonly ViewController viewController;
        private readonly KartenListController kartenListController;
        private long stapelId;
        private readonly Stapel[] allesStapel = new StapelRepository().GetAlleStapel();
      
        private Point lastPoint;

        public HinzufuegenKarten(Point p)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Left += p.X - lastPoint.X;
            this.Top += p.Y - lastPoint.Y;

            viewController = new ViewController(); 
            stapelController = new StapelController();
            karteController = new KarteController();
            alleKarten = new List<Karte>();
            kartenListController = new KartenListController();
            ComboBoxLaden();

            txt_KartenSuche.Text = "Suchen nach:";
            txt_KartenSuche.ForeColor = Color.Gray;
            richTxt_Vorderseite.Text = @"Frage";
            richTxt_Vorderseite.ForeColor = Color.Gray;
            richTxt_Rueckseite.Text = @"Richtige Antwort";
            richTxt_Rueckseite.ForeColor = Color.Gray;
            fackeAntwort1.Text = "Falsche Antwort 1 (Optional)";
            fackeAntwort1.ForeColor = Color.Gray;
            fackeAntwort2.Text = "Falsche Antwort 2 (Optional)";
            fackeAntwort2.ForeColor = Color.Gray;
            fackeAntwort3.Text = "Falsche Antwort 3 (Optional)";
            fackeAntwort3.ForeColor = Color.Gray;
            listView_KartenAnzeige.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ComboBoxLaden()
        {
            comboBox1.Items.Clear();
            foreach (Stapel stapel in allesStapel)
            {
                comboBox1.Items.Add(stapel.Name);
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void ComboBox1SelectedValueChanged(object sender, EventArgs e)
        {
            string ausgewählterStapel = comboBox1.SelectedItem.ToString();

            stapelId = stapelController.GetStapel(ausgewählterStapel).Id;
            alleKarten = karteController.GetAlleKartenEinesStapels(stapelId);
            ListViewFormatieren();
        }

        private void BtnHinzufuegenClick(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text.Trim() != "Frage" && richTxt_Rueckseite.Text.Trim() != "Richtige Antwort")
            {
                if (karteController.Hinzufügen(KartenAnlegen()))
                {
                    string stapelName = comboBox1.SelectedItem.ToString();
                    Stapel newStapel = stapelController.GetStapel(stapelName);
                    stapelId = newStapel.Id;
                    List<Karte> alleKartenEinesStapels = karteController.GetAlleKartenEinesStapels(stapelId);

                    ListView listView = kartenListController.ReloadView(this.listView_KartenAnzeige,
                        alleKartenEinesStapels);
                    listView_KartenAnzeige = listView;

                    ClearTextFelder();
                    viewController.ShowMessageBoxHinzufuegenErfolgreich();
                }
            }
            else
            {
                viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
            }
        }

        private Karte KartenAnlegen()
        {
            Karte karte = new Karte
            {
                Frage = richTxt_Vorderseite.Text,
                Antwort = richTxt_Rueckseite.Text,
                FalschAntwort1 = fackeAntwort1.Text,
                FalschAntwort2 = fackeAntwort2.Text,
                FalschAntwort3 = fackeAntwort3.Text,
                StapelId = stapelId
            };

            if (karte.FalschAntwort1 != "Falsche Antwort 1 (Optional)" || karte.FalschAntwort2 !=
                "Falsche Antwort 2 (Optional)" || karte.FalschAntwort3 != "Falsche Antwort 3 (Optional)")
            {
                karte.ChallengeMode = true;
            }
            else
            {
                karte.ChallengeMode = false;
            }

            return karte;
        }

        private void ListViewFormatieren()
        {
            listView_KartenAnzeige.Clear();
            listView_KartenAnzeige.View = View.Details;
            listView_KartenAnzeige.Columns.Add("Fragen").Width = 550;
            KartenAnzeigen(alleKarten);
        }

        private void KartenAnzeigen(List<Karte> anzeigeList)
        {
            listView_KartenAnzeige.Items.Clear();
            listView_KartenAnzeige.Items.AddRange(anzeigeList.Select(karte => new ListViewItem(karte.Frage)).ToArray());
        }

        private void listViewKartenAnzeigeClick(object sender, EventArgs e)
        {
            selectedKarte = SelectedKarteAsKarte(listView_KartenAnzeige.SelectedItems[0].Text);

            if (selectedKarte == null)
            {
                string stapelname = comboBox1.SelectedItem.ToString();

                Stapel aktuellerStapel = stapelController.GetStapel(stapelname);
                List<Karte> alleKartenEinesStapels = karteController.GetAlleKartenEinesStapels(aktuellerStapel.Id);
                string zuletztAusgewählteFrage = listView_KartenAnzeige.Items[listView_KartenAnzeige.Items.Count - 1].Text; 

                Karte zuletztAusgewälteKarte = alleKartenEinesStapels.First(karte => karte.Frage == zuletztAusgewählteFrage);
                selectedKarte = zuletztAusgewälteKarte;
             
            }

            richTxt_Vorderseite.Text = selectedKarte.Frage;
            richTxt_Rueckseite.Text = selectedKarte.Antwort;
            fackeAntwort1.Text = selectedKarte.FalschAntwort1;
            fackeAntwort2.Text = selectedKarte.FalschAntwort2;
            fackeAntwort3.Text = selectedKarte.FalschAntwort3;
            richTxt_Vorderseite.ForeColor = Color.Black;
            richTxt_Rueckseite.ForeColor = Color.Black;

        }

        private void ClearTextFelder()
        {
            fackeAntwort1.Clear();
            fackeAntwort2.Clear();
            fackeAntwort3.Clear();
            richTxt_Rueckseite.Clear();
            richTxt_Vorderseite.Clear();
        }

        private Karte SelectedKarteAsKarte(string karteFrage)
        {
            return alleKarten.Find(karte => karte.Frage == karteFrage);
        }

        private void KartenSucheAnzeigen(string suchbegriff)
        {
            List<Karte> ergebnisListe = ListenDurchsuchenTool.GetSuchergebnis(suchbegriff, alleKarten);

            if (ergebnisListe.Count < 1)
            {
                viewController.ShowMessageBoxHinzufuegenErfolgreich();
                KartenAnzeigen(alleKarten);
            }
            else
                KartenAnzeigen(ergebnisListe);
        }

        private void listViewKartenAnzeigeColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_KartenAnzeige.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                if (karteController.Löschen(selectedKarte.Id))
                {
                    selectedKarte = null;
                    string stapelName = comboBox1.SelectedItem.ToString();

                    Stapel stapel = stapelController.GetStapel(stapelName);
                    stapelId = stapel.Id;
                    List<Karte> alleKartenEinesStapels = karteController.GetAlleKartenEinesStapels(stapelId);

                    ListView listView = kartenListController.ReloadView(this.listView_KartenAnzeige, alleKartenEinesStapels);
                    listView_KartenAnzeige = listView;
                    ClearTextFelder();
                    viewController.ShowMessageBoxErfolgreichGeloescht();
                }
                else
                {
                    viewController.ShowMessageBoxLoeschenNichtErfolgreich();
                }
            }
        }

        private void BtnBtnEditierenClick(object sender, EventArgs e)
        {
            if (selectedKarte != null)
            {
                selectedKarte.Frage = richTxt_Vorderseite.Text;
                selectedKarte.Antwort = richTxt_Rueckseite.Text;
                selectedKarte.FalschAntwort1 = fackeAntwort1.Text;
                selectedKarte.FalschAntwort2 = fackeAntwort2.Text;
                selectedKarte.FalschAntwort3 = fackeAntwort3.Text;

                if (selectedKarte.FalschAntwort1 != "" || selectedKarte.FalschAntwort2 != "" || selectedKarte.FalschAntwort3 != "")
                {
                    selectedKarte.ChallengeMode = true;
                }
                else
                {
                    selectedKarte.ChallengeMode = false;
                }

                if (karteController.Aktualisieren(selectedKarte))
                {
                    selectedKarte = null;
                    ListView listView = kartenListController.ReloadView(this.listView_KartenAnzeige, alleKarten);
                    listView_KartenAnzeige = listView;
                    viewController.ShowMessageBoxAktualisierenErfolgreich();
                }
                else
                {
                    viewController.ShowMessageBoxAktualisierenNichtErfolgreich();
                }

                ClearTextFelder();
            }
        }

        private void TxtKartenSucheKeyDown(object sender, KeyEventArgs e)
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

        private void TxtKartenSucheLeave(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text == "")
            {
                txt_KartenSuche.Text = "Suchen nach:";
                txt_KartenSuche.ForeColor = Color.Gray;
            }
        }

        private void TxtKartenSucheEnter(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text == "Suchen nach:")
            {
                txt_KartenSuche.Text = "";
                txt_KartenSuche.ForeColor = Color.Black;
            }
        }

        private void RichTxtVorderseiteLeave(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text == "")
            {
                richTxt_Vorderseite.Text = "Frage";
                richTxt_Vorderseite.ForeColor = Color.Gray;
            }
        }

        private void RichTxtVorderseiteEnter(object sender, EventArgs e)
        {
            if (richTxt_Vorderseite.Text == "Frage")
            {
                richTxt_Vorderseite.Clear();
                richTxt_Vorderseite.ForeColor = Color.Black;
            }
        }
        private void RichTxtRueckseiteLeave(object sender, EventArgs e)
        {
            if (richTxt_Rueckseite.Text == "")
            {
                richTxt_Rueckseite.Text = "Richtige Antwort";
                richTxt_Rueckseite.ForeColor = Color.Gray;
            }
        }

        private void RichTxtRueckseiteEnter(object sender, EventArgs e)
        {
            if (richTxt_Rueckseite.Text == "Richtige Antwort")
            {
                richTxt_Rueckseite.Clear();
                richTxt_Rueckseite.ForeColor = Color.Black;
            }
        }

        private void FackeAntwort1Leave(object sender, EventArgs e)
        {
            if (fackeAntwort1.Text == "")
            {
                fackeAntwort1.Text = "Falsche Antwort 1 (Optional)";
                fackeAntwort1.ForeColor = Color.Gray;
            }
        }

        private void FackeAntwort1Enter(object sender, EventArgs e)
        {
            if (fackeAntwort1.Text == "Falsche Antwort 1 (Optional)")
            {
                fackeAntwort1.Clear();
                fackeAntwort1.ForeColor = Color.Black;
            }
        }

        private void FackeAntwort2Leave(object sender, EventArgs e)
        {
            if (fackeAntwort2.Text == "")
            {
                fackeAntwort2.Text = "Falsche Antwort 2 (Optional)";
                fackeAntwort2.ForeColor = Color.Gray;
            }
        }

        private void FackeAntwort2Enter(object sender, EventArgs e)
        {
            if (fackeAntwort2.Text == "Falsche Antwort 2 (Optional)")
            {
                fackeAntwort2.Clear();
                fackeAntwort2.ForeColor = Color.Black;
            }
        }

        private void FackeAntwort3Leave(object sender, EventArgs e)
        {
            if (fackeAntwort3.Text == "")
            {
                fackeAntwort3.Text = "Falsche Antwort 3 (Optional)";
                fackeAntwort3.ForeColor = Color.Gray;
            }
        }

        private void FackeAntwort3Enter(object sender, EventArgs e)
        {
            if (fackeAntwort3.Text == "Falsche Antwort 3 (Optional)")
            {
                fackeAntwort3.Clear();
                fackeAntwort3.ForeColor = Color.Black;
            }
        }

        private void PictureBox1Click(object sender, EventArgs e)
        {
            if (txt_KartenSuche.Text.Trim() == "")
                KartenAnzeigen(alleKarten);
            else
                KartenSucheAnzeigen(txt_KartenSuche.Text);
            txt_KartenSuche.Clear();
        }

        
        private void MenuMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void MenuMouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ÜbersichtButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            new StapelUebersichtView(this.DesktopLocation).Show();
        }
        private void KarteBearbeitenButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            new HinzufuegenKarten(this.DesktopLocation).Show();
        }
        private void StapelBearbeitenButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            new StapelBearbeitenView(this.DesktopLocation).Show();
        }
        private void JetztLernenButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView(this.DesktopLocation).Show();
        }
        private void ChallengeButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            new ChallengeView(this.DesktopLocation).Show();
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
