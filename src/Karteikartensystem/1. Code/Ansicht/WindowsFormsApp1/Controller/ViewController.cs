using System;
using System.Windows.Forms;
using AnsichtsFenster.Fenster;
using Model;

namespace AnsichtsFenster.Controller
{
    internal class ViewController
    {
        internal KartenUebersicht BuildKartenUebersicht(ListViewItem item)
        {
            
            string panelName = item.SubItems[1].Text;
            int panelId = Convert.ToInt32(item.SubItems[0].Text);

            Stapel stapel = new Stapel();
            stapel.Name = panelName;
            stapel.Id = panelId;

            return new KartenUebersicht(stapel);
        }

        internal HinzufuegenKarten BuildHinzufuegenKarten(ListViewItem item)
        {
            string panelName = item.SubItems[1].Text;
            return new HinzufuegenKarten(panelName, Convert.ToInt32(item.SubItems[0].Text));
        }

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