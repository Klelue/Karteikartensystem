﻿using System;
using System.Drawing;
using System.Windows.Forms;
using AnsichtsFenster.Controller;
using Model;

namespace AnsichtsFenster.Fenster
{
    public partial class StapelUebersichtView : Form
    {
        //TODO OTHER WAY TO STORE ITEM STATE?
        private ListViewItem selectedItem;
        private StapelListController listController;
        private ViewController viewController;

        public StapelUebersichtView()
        {
            InitializeComponent();
            listController = new StapelListController();
            viewController = new ViewController();

            listView_Ausgabe = listController.CreateView(listView_Ausgabe);
            listView_Ausgabe = listController.UpdateView(listView_Ausgabe);
			
            txt_StapelSuche.Height = 50;
            txt_StapelSuche.Text = "Suche nach dein Stapel";
            txt_StapelSuche.ForeColor = Color.Gray;			
        }

        private void listView_Ausgabe_Click(object sender, EventArgs e)
        {
            selectedItem = listController.SelectItem(listView_Ausgabe);
        }

        private void listView_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            viewController.BuildKartenUebersicht(selectedItem).Show();
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView_Ausgabe.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_Entfernen_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                if (viewController.ShowMessageBoxChoiceStapelLoeschen(selectedItem))
                {
                    listView_Ausgabe = listController.DeleteItem(listView_Ausgabe, selectedItem, out bool geloescht);
                    if (geloescht)
                        viewController.ShowMessageBoxErfolgreichGeloescht();
                    else
                        viewController.ShowMessageBoxLoeschenNichtErfolgreich();
                }
            }
            else
                viewController.ShowMessageBoxKeinElementGewaehlt();
        }


        //TODO selectedItem von string zu Stapel ändern
        private void btn_KartenHinzufuegen_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                viewController.BuildHinzufuegenKarten(selectedItem).Show();
            }
            else
            {
                viewController.ShowMessageBoxKeinElementGewaehlt();
            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "Es wurde nichts angegeben";
        }
        
        private void StapelHinzufuegen(string stapelname)
        {
            if (stapelname.Trim().Length != 0)
            {
                Stapel stapel = new Stapel();
                stapel.Name = stapelname;

                if (new Repositories.StapelRepository().StapelHinzufügen(stapel))
                    viewController.ShowMessageBoxHinzufuegenErfolgreich();
                else
                    viewController.ShowMessageBoxHinzufuegenNichtErfolgreich();
            }
            else
                viewController.ShowMessageBoxKeineEingabe();
        }

        private void txt_StapelSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_StapelSuche.Text.Trim() == "")
                {
                    listView_Ausgabe = listController.UpdateView(listView_Ausgabe);
                }
                else
                {
                    listView_Ausgabe = listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
                }
                txt_StapelSuche.Clear();
            }
        }

        // TODO schauen, ob Stapel mindestens eine Karte besitzt
        private void btn_StapelHinzufuegen_Click(object sender, EventArgs e)
        {
            string stapelName = ShowDialog("Gib den Namen des Stapels an", "Stapel hinzufügen");
            if (stapelName != "Es wurde nichts angegeben")
            {
                StapelHinzufuegen(stapelName);
            }
        }

        private void JetztLernenEvent(object sender, EventArgs e)
        {
            JetztLernenView jetztLernenView = new JetztLernenView();
            jetztLernenView.Show();
        }

        /****************************************/

        private Point LastPoint;
        private void dachPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top  += e.Y - LastPoint.Y;
            }
        }

        private void dachPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void txt_StapelSuche_Enter(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "Suche nach dein Stapel")
            {
                txt_StapelSuche.Clear();
                txt_StapelSuche.ForeColor = Color.Black;
            }
        }

        private void txt_StapelSuche_Leave(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text == "")
            {
                txt_StapelSuche.Text = "Suche nach dein Stapel";
                txt_StapelSuche.ForeColor = Color.Gray;
            }
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_StapelSuche.Text.Trim() == "")
                listView_Ausgabe = listController.UpdateView(listView_Ausgabe);
            else
                listView_Ausgabe = listController.UpdateSuchergebnis(txt_StapelSuche.Text, listView_Ausgabe);
            txt_StapelSuche.Clear();
        }

        private void MinimierenButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
