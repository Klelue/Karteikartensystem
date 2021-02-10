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

        internal void ShowMessageBoxErfolgreichGeloescht()
        {
            MessageBox.Show("Erfolgreich gelöscht", "Gelöscht",
                MessageBoxButtons.OK); ;
        }
        internal void ShowMessageBoxLoeschenNichtErfolgreich()
        {
            MessageBox.Show("Löschen nicht möglich", "Achtung",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal void ShowMessageBoxHinzufuegenErfolgreich()
        {
            MessageBox.Show("Erfolgreich hinzugefügt!", "Hinzugefügt",
                MessageBoxButtons.OK);
        }

        internal void ShowMessageBoxHinzufuegenNichtErfolgreich()
        {
            MessageBox.Show("Hinzufügen nicht möglich", "Achtung",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal void ShowMessageBoxKeinElementGewaehlt()
        {
            MessageBox.Show("Es wurde kein Element ausgewählt", "Achtung",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void ShowMessageBoxKeinEintragGefunden()
        {
            MessageBox.Show("Kein Eintrag gefunden", "Kein passender Eintrag",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void ShowMessageBoxKeineGueltigeEingabe()
        {
            MessageBox.Show("Es wurde kein gültiger Wert angegeben", "Kein gültiger Wert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal void ShowMessageBoxAktualisierenErfolgreich()
        {
            MessageBox.Show("Daten wurden aktualisiert", "Aktualisiert",
                MessageBoxButtons.OK);
        }

        internal void ShowMessageBoxAktualisierenNichtErfolgreich()
        {
            MessageBox.Show("Daten wurden nicht aktualisiert", "Achtung",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}