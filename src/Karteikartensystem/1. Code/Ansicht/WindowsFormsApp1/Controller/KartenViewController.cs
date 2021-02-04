using System.Windows.Forms;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class KartenViewController : IListViewController
    {
        private KarteRepository karteRepository;

        public KartenViewController()
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