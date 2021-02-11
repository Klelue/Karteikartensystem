using System;
using System.Drawing;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using AnsichtsFenster.Utilities;
using Model;


namespace AnsichtsFenster.Fenster
{
    public partial class StapelBearbeitenView : Form
    {
        private ViewController viewController;
        private StapelListController listController;
        private StapelController stapelController;
        private StapelFileHandler fileHandler;

        private Point letzteMouseKoordinaten;
        public StapelBearbeitenView()
        {
            InitializeComponent();

            viewController = new ViewController();
            listController = new StapelListController();
            stapelController = new StapelController();
            fileHandler = new StapelFileHandler();

            textBoxStapelName.Text = "Stapel";
            textBoxStapelName.ForeColor = Color.Gray;


            // listViewAusgabe.View = View.Details;
            // listController.ClearView(listViewAusgabe);

            listViewAusgabe.View = View.Details;
            listViewAusgabe.Columns.Add("Stapel").Width = 245;

            //listViewAusgabe = listController.CreateView(listViewAusgabe);
            listController.UpdateView(listViewAusgabe);

            
        }

        private void stapelAnlegen_Click(object sender, EventArgs e)
        {

            string stapelName = textBoxStapelName.Text;

            if (stapelName != "Stapel")
            {
                Stapel stapel = new Stapel
                {
                    Name = stapelName
                };

                if (stapelController.Hinzufügen(stapel))
                {
                    listController.ReloadView(listViewAusgabe, stapelController.GetAlleStapel());
                    viewController.ShowMessageBoxHinzufuegenErfolgreich();
                }
                else
                {
                    viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
                }
            }
            else
            {
                viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
            }

        }

        private void stapelAktualisieren_Click(object sender, EventArgs e)
        {
            string selectedStapelName = listViewAusgabe.SelectedItems[0].Text;
            Stapel selectedStapel = stapelController.GetStapel(selectedStapelName);

            if (selectedStapel != null)
            {
                selectedStapel.Name = textBoxStapelName.Text;
                stapelController.Aktualisieren(selectedStapel);
                listController.ReloadView(listViewAusgabe, stapelController.GetAlleStapel());

                viewController.ShowMessageBoxAktualisierenErfolgreich();
            }
            else
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
            }
        }

        private void stapelLöschen_Click(object sender, EventArgs e)
        {
            string selectedStapelName = listViewAusgabe.SelectedItems[0].Text;
            Stapel selectedStapel = stapelController.GetStapel(selectedStapelName);

            if (selectedStapel != null)
            {
                selectedStapel.Name = textBoxStapelName.Text;
                stapelController.Löschen(selectedStapel.Id);
                listController.ReloadView(listViewAusgabe, stapelController.GetAlleStapel());

                viewController.ShowMessageBoxErfolgreichGeloescht();
            }
            else
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
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

                    if (fileHandler.SepDateiEinlesen(pfad)){

                        viewController.ShowMessageBoxHinzufuegenErfolgreich();
                    }
                    else
                    {
                        viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
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

            string selectedStapelName = listViewAusgabe.SelectedItems[0].Text;
            Stapel selectedStapel = stapelController.GetStapel(selectedStapelName);

            if (selectedStapel != null)
            {
                
                if(fileHandler.StapelAlsSepDateiAnlegen(selectedStapel, selectedPath))
                {
                    viewController.ShowMessageBoxHinzufuegenErfolgreich();
                }
                else
                {
                    viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
                }

            }
            else
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
            }
        }

        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - letzteMouseKoordinaten.X;
                this.Top += e.Y - letzteMouseKoordinaten.Y;
            }
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            letzteMouseKoordinaten = new Point(e.X, e.Y);
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

        private void jetztLernenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView().Show();
        }
        
        private void challengeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChallengeView().Show();
        }

        private void minimierenButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBoxStapelName_Enter(object sender, EventArgs e)
        {
            if (textBoxStapelName.Text == "Stapel")
            {
                textBoxStapelName.Clear();
                textBoxStapelName.ForeColor = Color.Gray; ;
            }
        }

        private void textBoxStapelName_Leave(object sender, EventArgs e)
        {
            if (textBoxStapelName.Text == "")
            {
                textBoxStapelName.Text = "Stapel";
                textBoxStapelName.ForeColor = Color.Black;
            }
        }
    }
}
