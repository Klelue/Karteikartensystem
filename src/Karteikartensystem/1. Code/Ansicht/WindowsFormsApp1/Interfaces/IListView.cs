using System.Windows.Forms;

namespace AnsichtsFenster.Controller
{
    public interface IListView
    {
        //TODO INTERFACE TYP IMODEL ODER NUR KARTEN ODER DURCH INTERFACE VERERBUNG
        ListView CreateView(ListView listView);
        ListView UpdateView(ListView listView);
        ListView ClearView(ListView listView);

        //TODO CHECK FOR NEED
        ListView UpdateSuchergebnis(string suchbegriff, ListView listView);
        //
        
        ListViewItem SelectItem(ListView listView);
        ListView DeleteItem(ListView listView, ListViewItem listViewItem, out bool geloescht);

        //TODO CHECK FOR NEED
        /*ListView SortAscending(ListView listView);
        ListView SortDescending(ListView listView);*/
    }
}