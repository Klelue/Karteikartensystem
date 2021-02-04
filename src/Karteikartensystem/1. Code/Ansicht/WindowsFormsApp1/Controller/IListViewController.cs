using System.Windows.Forms;

namespace AnsichtsFenster.Controller
{
    public interface IListViewController
    {
        ListView CreateView(ListView listView);
        ListView UpdateView(ListView listView);
        ListView UpdateSuchergebnis(string suchbegriff, ListView listView);
        ListView ClearView(ListView listView);


        ListView SortAscending(ListView listView);
        ListView SortDescending(ListView listView);

        //TODO INTERFACE TYP IMODEL ODER NUR KARTEN
        //ListViewItem CreateViewItem(IModel iModel);
       // ListView ReloadView(ListView listView, List<IModel> datenliste)
    }
}