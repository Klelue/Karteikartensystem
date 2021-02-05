using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace AnsichtsFenster.Controller
{
    public interface IKartenListView : IListView
    {
        ListViewItem CreateViewItem(Karte karte);
        ListView ReloadView(ListView listView, List<Karte> kartenListe);
    }
}