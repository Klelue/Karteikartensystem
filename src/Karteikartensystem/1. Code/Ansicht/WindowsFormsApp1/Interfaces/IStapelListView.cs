using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace AnsichtsFenster.Controller
{
    public interface IStapelListView : IListView
    {
        ListViewItem CreateViewItem(Stapel stapel);
        ListView ReloadView(ListView listView, List<Stapel> stapellListe);
    }
}