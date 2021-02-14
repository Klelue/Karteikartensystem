
namespace AnsichtsFenster.Controller
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Utilities;
    using Model;
    using Repositories;
    public class StapelListController : IStapelListView
    {
        private readonly StapelController stapelController;
        private readonly KarteController karteController;

        public StapelListController()
        {
            stapelController = new StapelController();
            karteController = new KarteController();
        }

        public ListView CreateView(ListView listView)
        {
            listView.View = View.Details;
            listView.Columns.Add("Stapelname").Width = 198;
            listView.Columns.Add("Anzahl Karten").Width = 198;
            listView.Columns.Add("Anzahl gelernter Karten").Width = 198;
            listView.Columns.Add("Zeit").Width = 198;

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
            List<Stapel> ergebnisListe = ListenDurchsuchenTool.GetSuchergebnis(suchbegriff, alleStapel);

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
            return stapelController.GetAlleStapel();
        }

        public ListViewItem CreateViewItem(Stapel stapel)
        {
            ListViewItem item = new ListViewItem((stapel.Name));

            int anzahlKarten = karteController.CountAlleKartenEinesStapels(stapel.Id);
            item.SubItems.Add(anzahlKarten.ToString());

            int gelernteKarten = GelernteKartenBerechnen(stapel);
            item.SubItems.Add(gelernteKarten.ToString());

            item.SubItems.Add(stapel.GelernteZeitInMinuten + " Minuten");

            return item;
        }

        private int GelernteKartenBerechnen(Stapel stapel)
        {
            Karte[] alleKartenEinesStapels = new KarteRepository().GetAlleKartenEinesStapels(stapel.Id);

            return alleKartenEinesStapels.Count(karte => karte.Schwierigkeitsgrad == 3);
        }

        public ListView DeleteItem(ListView listView, ListViewItem listViewItem, out bool geloescht)
        {
            string stapelName = listViewItem.SubItems[0].Text;

            Stapel stapelMitAusgewähltenName = stapelController.GetStapel(stapelName);
            geloescht = stapelController.Löschen(stapelMitAusgewähltenName.Id);
            listView.Items.Remove(listViewItem);

            return listView;
        }
    }
}
