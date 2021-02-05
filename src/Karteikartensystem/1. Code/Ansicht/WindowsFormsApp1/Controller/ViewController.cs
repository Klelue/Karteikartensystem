using System;
using System.Windows.Forms;
using AnsichtsFenster.Fenster;

namespace AnsichtsFenster.Controller
{
    public class ViewController
    {
        public HinzufuegenView BuildHinzufuegenView()
        {
            return new HinzufuegenView();
        }

        public KartenUebersicht BuildKartenUebersicht(ListViewItem item)
        {
            string panelName = item.SubItems[1].Text;
            int panelId = Convert.ToInt32(item.SubItems[0].Text);

            return new KartenUebersicht(panelName, panelId);
        }
    }
}