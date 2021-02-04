using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class StapelViewController : IListViewController
    {
        private StapelRepository stapelRepository;

        public StapelViewController()
        {
            stapelRepository = new StapelRepository();
        }

        public ListView CreateView(ListView listView)
        {
            listView.View = View.Details;
            listView.Columns.Add("ID");
            listView.Columns.Add("Stapelname").Width = 140;
            listView.Columns.Add("Anzahl");

            return listView;
        }

        public ListView UpdateView(ListView listView)
        {
            List<Stapel> kartenStapelListe = GetAlleStapelVonDatenbank();
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Stapel stapel in kartenStapelListe)
            {
                listViewItems.Add(CreateViewItem(stapel));
            }

            listView.Items.Clear();
            listView.Items.AddRange(listViewItems.ToArray());
            return listView;
        }

        //TODO WAS BESSERES ALS ÜBERLADUNG FINDEN
        public ListView ReloadView(ListView listView, List<Stapel> kartenStapelListe)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Stapel stapel in kartenStapelListe)
            {
                listViewItems.Add(CreateViewItem(stapel));
            }

            listView.Items.Clear();
            listView.Items.AddRange(listViewItems.ToArray());
            return listView;
        }
        //TODO
        public ListView ClearView(ListView listView)
        {
            throw new NotImplementedException();
        }

        public ListView SortListViewAscending(ListView listView)
        {
            listView.Sorting = SortOrder.Ascending;
            return listView;
        }

        public ListView SortListViewDescending(ListView listView)
        {
            listView.Sorting = SortOrder.Descending;
            return listView;
        }
        
        //TODO LATER PRIVATE
        public List<Stapel> GetAlleStapelVonDatenbank()
        {
            return stapelRepository.GetAlleStapel().ToList();
        }

        //TODO LATER PRIVATE
        public ListViewItem CreateViewItem(Stapel stapel)
        {
            ListViewItem item = new ListViewItem(stapel.Id.ToString());
            item.SubItems.Add(stapel.Name);
            item.SubItems.Add("0");
            //TODO: ADD COUNT
            //item.SubItems.Add(stapel.Karten.Count());
            return item;
        }
    }
}
