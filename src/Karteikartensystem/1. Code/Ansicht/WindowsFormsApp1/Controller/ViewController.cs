using System;
using System.Windows.Forms;
using AnsichtsFenster.Fenster;
using Model;

namespace AnsichtsFenster.Controller
{
    internal class ViewController
    {
        internal KartenUebersicht BuildKartenUebersicht(Stapel stapel)
        {
           return new KartenUebersicht(stapel);
        }


        /*** OkMessageBox ***/
        internal void OkMessageBox(string txt1, string txt2)
        {
            MessageBox.Show(txt1, txt2, MessageBoxButtons.OK);
        }

        /*** ExclamationsMessageBox ***/
        internal void ExclamationsMessageBox(string txt1, string txt2)
        {
            MessageBox.Show(txt1, txt2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /*** InformationsMessageBox ***/
        internal void InformationsMessageBox(string txt)
        {
            MessageBox.Show(txt, "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*** WarningsMessageBox ***/
        internal void WarningsMessageBox(string txt)
        {
            MessageBox.Show(txt, "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /*** ErrorMessageBox ***/
        internal void ErrorMessageBox(string txt)
        {
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }





        //internal HinzufuegenKarten BuildHinzufuegenKarten(ListViewItem item)
        //{
        //    string panelName = item.SubItems[1].Text;
        //    return new HinzufuegenKarten(panelName, Convert.ToInt32(item.SubItems[0].Text));
        //}

        internal bool ShowMessageBoxChoiceStapelLoeschen(ListViewItem item)
        {
            return MessageBox.Show(
                "Möchtest du es wirklich den \"" + item.SubItems[0].Text +
                "\" und alle darin enthaltenen Karten entfernen?", "Entfernen", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        internal void ShowMessageBoxErfolgreichGeloescht()
        {
            MessageBox.Show("Erfolgreich gelöscht", "Gelöscht", 
                MessageBoxButtons.OK); ;
        }
        internal void ShowMessageBoxLoeschenNichtErfolgreich()
        {
            MessageBox.Show("Löschen nicht möglich", "Achtung!", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal void ShowMessageBoxHinzufuegenErfolgreich()
        {
            MessageBox.Show("Erfolgreich hinzugefügt!", "Hinzugefügt", 
                MessageBoxButtons.OK);
        }

        internal void ShowMessageBoxHinzufuegenNichtErfolgreich()
        {
            MessageBox.Show("Hinzufügen nicht möglich", "Achtung!", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal void ShowMessageBoxKeinElementGewaehlt()
        {
            MessageBox.Show("Es wurde kein Element ausgewählt", "Achtung!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void ShowMessageBoxKeinEintragGefunden()
        {
            MessageBox.Show("Kein Eintrag gefunden", "Kein passender Eintrag!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowMessageBoxKeineEingabe()
        {
            MessageBox.Show("Es wurde kein Name angegeben", "Kein Name angebenen!", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}