using System.Windows.Forms;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class KartenListController : IListViewController
    {
        private KarteRepository karteRepository;

        public KartenListController()
        {
            karteRepository = new KarteRepository();
        }

        public ListView CreateView(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView UpdateView(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView UpdateSuchergebnis(string suchbegriff, ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView ClearView(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListViewItem SelectItem(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListViewItem GetSelectItem(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView SortAscending(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView SortDescending(ListView listView)
        {
            throw new System.NotImplementedException();
        }
    }
}