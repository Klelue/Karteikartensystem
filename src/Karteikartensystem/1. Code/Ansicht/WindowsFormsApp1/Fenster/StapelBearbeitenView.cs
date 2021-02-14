
namespace AnsichtsFenster.Fenster
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Controller;
    using Utilities;
    using Model;
    public partial class StapelBearbeitenView : Form
    {
        private readonly ViewController viewController;
        private readonly StapelListController listController;
        private readonly StapelController stapelController;
        private readonly StapelFileHandler fileHandler;

        private Point lastPoint;
        public StapelBearbeitenView(Point p)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Left += p.X - lastPoint.X;
            this.Top += p.Y - lastPoint.Y;

            this.viewController = new ViewController();
            this.listController = new StapelListController();
            this.stapelController = new StapelController();
            this.fileHandler = new StapelFileHandler();

            textBoxStapelName.Text = "Stapel";
            textBoxStapelName.ForeColor = Color.Gray;

            listViewAusgabe.View = View.Details;
            listViewAusgabe.Columns.Add("Stapel").Width = 245;

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
                viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
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
                viewController.ShowMessageBoxKeinElementGewaehlt();
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
                viewController.ShowMessageBoxKeinElementGewaehlt();
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
                        listController.ReloadView(listViewAusgabe, stapelController.GetAlleStapel());
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

            Stapel selectedStapel = null;

            if (listViewAusgabe.SelectedItems.Count == 1)
            {
                string selectedStapelName = listViewAusgabe.SelectedItems[0].Text;
                selectedStapel = stapelController.GetStapel(selectedStapelName);
            }

            if (selectedStapel != null)
            {
                if (fileHandler.StapelAlsSepDateiAnlegen(selectedStapel, selectedPath))
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

        private void listViewAusgabe_Click(object sender, EventArgs e)
        {
            textBoxStapelName.Text = listViewAusgabe.SelectedItems[0].Text;
        }

        private void menuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ÜbersichtButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelUebersichtView(this.DesktopLocation).Show();
        }
        private void KarteBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HinzufuegenKarten(this.DesktopLocation).Show();
        }
        private void StapelBearbeitenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StapelBearbeitenView(this.DesktopLocation).Show();
        }
        private void jetztLernenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JetztLernenView(this.DesktopLocation).Show();
        }
        
        private void challengeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChallengeView(this.DesktopLocation).Show();
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
