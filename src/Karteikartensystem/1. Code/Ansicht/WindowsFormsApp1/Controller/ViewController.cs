using System;
using System.Windows.Forms;
using AnsichtsFenster.Fenster;

namespace AnsichtsFenster.Controller
{
    internal class ViewController
    {
        internal HinzufuegenView BuildHinzufuegenView()
        {
            return new HinzufuegenView();
        }

        internal KartenUebersicht BuildKartenUebersicht(ListViewItem item)
        {
            string panelName = item.SubItems[1].Text;
            int panelId = Convert.ToInt32(item.SubItems[0].Text);

            return new KartenUebersicht(panelName, panelId);
        }

        internal HinzufuegenKarten BuildHinzufuegenKarten(ListViewItem item)
        {
            string panelName = item.SubItems[1].Text;
            return new HinzufuegenKarten(panelName);
        }

        internal void GetMessageBoxKeinStapelGewaehlt()
        {
            MessageBox.Show("Es wurde kein Stapel ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void GetMessageBoxStapelGeloescht()
        {
            MessageBox.Show("Stapel wurde gelöscht", "Gelöscht", MessageBoxButtons.OK); ;
        }

        internal void GetMessageBoxKeinEintragGefunden()
        {
            MessageBox.Show("Leider kein Eintrag gefunden", "Kein passender Eintrag!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal bool GetMessageBoxChoiceStapelLoeschen(ListViewItem item)
        {
            return MessageBox.Show(
                "Möchtest du es wirklich den \"" + item.SubItems[1].Text +
                "\" und alle darin enthaltenen Karten entfernen?", "Entfernen", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes;
        }
    }
}