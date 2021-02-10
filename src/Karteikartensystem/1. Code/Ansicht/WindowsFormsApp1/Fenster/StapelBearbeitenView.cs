using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using AnsichtsFenster.Utilities;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelBearbeitenView : Form
    {

        private StapelRepository stapelRepository;
        private ViewController viewController;
        private Point letzteMousekoordinaten;
        

        public StapelBearbeitenView()
        {
            InitializeComponent();

            stapelRepository = new StapelRepository();
            viewController = new ViewController();

            Object[] alleStapel = stapelRepository.GetAlleStapel();

            listBoxStapel.Items.AddRange(alleStapel);
        }

        private void stapelAnlegen_Click(object sender, EventArgs e)
        {
            string stapelName = textBoxStapelName.Text;

            Stapel stapel = new Stapel
            {
                Name = stapelName
            };

            if (stapelRepository.StapelHinzufügen(stapel))
            {
                viewController.ShowMessageBoxHinzufuegenErfolgreich();
            }
            else
            {
               viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
            }
           
        }

        private void dateiAuswählen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = @"Stapel-Export-Datei|*.sed";
                
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pfad = fileDialog.FileName;

                    string[] pfadGesplitet = pfad.Split('\\');

                    string dateiname = pfadGesplitet[pfadGesplitet.Length - 1];

                    string[] dateinameGesplitet = dateiname.Split('.');

                    StapelFileHandler stapelFileHandler = new StapelFileHandler();

                    Karte[] kartenCsvEinlesen = stapelFileHandler.KartenCsvEinlesen(pfad);

                    StapelRepository stapelHinzufügen = new StapelRepository();

                    Stapel neuerStapel = new Stapel();

                    string dateinameOhneDateiendung = dateinameGesplitet[0];

                    neuerStapel.Name = dateinameOhneDateiendung;

                    stapelHinzufügen.StapelHinzufügen(neuerStapel);

                    Stapel[] alleStapel = stapelHinzufügen.GetAlleStapel();

                    Stapel first = alleStapel.First(stapel => stapel.Name == neuerStapel.Name);

                    KarteRepository karteRepository = new KarteRepository();

                    foreach (Karte karte in kartenCsvEinlesen)
                    {
                        karte.StapelId = first.Id;
                        karte.Schwierigkeitsgrad = 0;
                        karteRepository.KarteHinzufügen(karte);
                    }
                }
            }
        }

        private void StapelExportieren_Click(object sender, EventArgs e)
        {
            string selectedPath;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.ShowDialog();
                selectedPath = folderBrowserDialog.SelectedPath;
            }

            Stapel selectedStapel = (Stapel) listBoxStapel.SelectedItem;

            if (selectedStapel == null)
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
            }
            else
            {
                StapelFileHandler fileHandler = new StapelFileHandler();

                Karte[] alleKartenEinesStapels = new KarteRepository().GetAlleKartenEinesStapels(selectedStapel.Id);

                fileHandler.KartenAlsCsvDateiAnlegen(selectedStapel.Name, alleKartenEinesStapels, selectedPath);
            }
        }

        private void stapelAktualisieren_Click(object sender, EventArgs e)
        {
            Stapel selectedStapel = (Stapel) listBoxStapel.SelectedItem;

            if (selectedStapel == null)
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
            }
            else
            {
                selectedStapel.Name = textBoxStapelName.Text;
                stapelRepository.StapelAktualisieren(selectedStapel);

                viewController.ShowMessageBoxAktualisierenErfolgreich();
            }
        }

        private void stapelLöschen_Click(object sender, EventArgs e)
        {
            Stapel selectedStapel = (Stapel) listBoxStapel.SelectedItem;

            if (selectedStapel == null)
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
            }
            else
            {
                stapelRepository.StapelLöschen(selectedStapel.Id);
                viewController.ShowMessageBoxErfolgreichGeloescht();
            }
        }


        private void dachPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - letzteMousekoordinaten.X;
                this.Top += e.Y - letzteMousekoordinaten.Y;
            }
        }

        private void dachPanel_MouseDown(object sender, MouseEventArgs e)
        {
            letzteMousekoordinaten = new Point(e.X, e.Y);
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
