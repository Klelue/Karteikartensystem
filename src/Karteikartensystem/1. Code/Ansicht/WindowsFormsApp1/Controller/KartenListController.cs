using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class KartenListController : IKartenListView
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

        public ListView ClearView(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView UpdateSuchergebnis(string suchbegriff, ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListViewItem SelectStapel(ListView listView)
        {
            throw new System.NotImplementedException();
        }

        public ListView DeleteItem(ListView listView, ListViewItem listViewItem, out bool geloescht)
        {
            throw new System.NotImplementedException();
        }

        public ListViewItem CreateViewItem(Karte karte)
        {
            ListViewItem item = new ListViewItem((karte.Frage));
            item.SubItems.Add(karte.Frage);

            return item;
        }

        public ListView ReloadView(ListView listView, List<Karte> kartenListe)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            
            foreach (Karte karte in kartenListe)
            {
                listViewItems.Add(CreateViewItem(karte));
            }

            listView.Items.Clear();
            listView.Items.AddRange(listViewItems.ToArray());

            return listView; 
        }
    }
}