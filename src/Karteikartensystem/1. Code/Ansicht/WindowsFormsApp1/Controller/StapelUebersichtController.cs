using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class StapelUebersichtController
    {
        private ListView listView;
        private List<ListViewItem> listViewItems;

        private KarteRepository karteRepository;
        private StapelRepository stapelRepository;

        public StapelUebersichtController()
        {
            karteRepository = new KarteRepository();
            stapelRepository = new StapelRepository();
        }

        public List<Stapel> GetAlleStapelVonDatenbank()
        {
            return stapelRepository.GetAlleStapel().ToList();
        }

        public ListView ListViewCreate()
        {
            listView = new ListView
            {
                View = View.Details
            };
            listView.Columns.Add("ID");
            listView.Columns.Add("Stapelname").Width = 140;
            listView.Columns.Add("Anzahl");

            return listView;
        }
        public void ListViewUpdate(List<Stapel> kartenStapel)
        {
            listViewItems = new List<ListViewItem>();

            foreach (Stapel stapel in kartenStapel)
            {
                listViewItems.Add(ListViewItemCreate(stapel));
            }

            listView.Items.Clear();
            listView.Items.AddRange(listViewItems.ToArray());
        }

        private ListViewItem ListViewItemCreate(Stapel stapel)
        {
            ListViewItem item = new ListViewItem(stapel.Id.ToString());
            item.SubItems.Add(stapel.Name);
            item.SubItems.Add("0");
            //TODO: ADD COUNT
            //item.SubItems.Add(stapel.Karten.Count());
            return item;
        }

        public void SortListView()
        {
            //sListView.Sorting;
        }
    }
}
