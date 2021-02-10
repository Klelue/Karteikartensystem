using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AnsichtsFenster.Utilities;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class StapelListController : IStapelListView
    {
        private StapelRepository stapelRepository;

        public StapelListController()
        {
            stapelRepository = new StapelRepository();
        }

        public ListView CreateView(ListView listView)
        {
            listView.View = View.Details;
            listView.Columns.Add("Stapelname").Width = 180;
            listView.Columns.Add("Zeit").Width = 180;
            listView.Columns.Add("Anzahl gelernter Karten").Width = 180;
          

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

        public ListView ReloadView(ListView listView, List<Stapel> stapellListe)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            foreach (Stapel stapel in stapellListe)
            {
                listViewItems.Add(CreateViewItem(stapel));
            }

            listView.Items.Clear();
            listView.Items.AddRange(listViewItems.ToArray());

            return listView;
        }

        public ListView ClearView(ListView listView)
        {
            listView.Clear();
            return listView;
        }

        public Stapel SelectStapel(ListView listView)
        {
            //TODO TRY FOR NULL
            return GetAlleStapelVonDatenbank().Find(stapel => stapel.Name == listView.SelectedItems[0].Text);
        }

        public ListView UpdateSuchergebnis(string suchbegriff, ListView listView)
        {
            //TODO alleStapel von DB lösen
            List<Stapel> alleStapel = GetAlleStapelVonDatenbank();
            List<Stapel> ergebnisListe = StringSuchTool.GetSuchergebnis(suchbegriff, alleStapel);

            if (ergebnisListe.Count == 0)
            {
                new ViewController().ShowMessageBoxKeinEintragGefunden();
                return ReloadView(listView, alleStapel);
            }
            else
            {
                return ReloadView(listView, ergebnisListe);
            }
        }

        //TODO TRY CATCH!
        private List<Stapel> GetAlleStapelVonDatenbank()
        {
            return stapelRepository.GetAlleStapel().ToList();
        }

        //TODO INTERFACE TYP IMODEL ODER NUR KARTEN STATT STAPEL UND KARTEN
        public ListViewItem CreateViewItem(Stapel stapel)
        {

            ListViewItem item = new ListViewItem((stapel.Name));
            item.SubItems.Add(stapel.GelernteZeitInMinuten + " Minuten");

            int gelernteKarten = GelernteKartenBerechnen(stapel);

            item.SubItems.Add(gelernteKarten.ToString());
            //TODO: ADD COUNT
            //item.SubItems.Add(stapel.Karten.Count().ToString());
            return item;
        }

        private int GelernteKartenBerechnen(Stapel stapel)
        {
            Karte[] alleKartenEinesStapels = new KarteRepository().GetAlleKartenEinesStapels(stapel.Id);

            return alleKartenEinesStapels.Count(karte => karte.Schwierigkeitsgrad == 3);

        }

        public ListView DeleteItem(ListView listView, ListViewItem listViewItem, out bool geloescht)
        {
            Stapel[] alleStapel = stapelRepository.GetAlleStapel();
            Stapel stapelMitAusgewähltenName = alleStapel.First(stapel => stapel.Name == listViewItem.SubItems[0].Text);

            int itemDatenbankIndex = Convert.ToInt32(stapelMitAusgewähltenName.Id);

            geloescht = stapelRepository.StapelLöschen(itemDatenbankIndex);
            listView.Items.Remove(listViewItem);
            return listView;
        }
    }
}
