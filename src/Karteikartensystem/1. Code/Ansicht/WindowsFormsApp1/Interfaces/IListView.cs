using System.Windows.Forms;

namespace AnsichtsFenster.Controller
{
    public interface IListView
    {
        ListView CreateView(ListView listView);
        ListView UpdateView(ListView listView);
        ListView ClearView(ListView listView);
        ListView UpdateSuchergebnis(string suchbegriff, ListView listView);
        ListView DeleteItem(ListView listView, ListViewItem listViewItem, out bool geloescht);
    }
}