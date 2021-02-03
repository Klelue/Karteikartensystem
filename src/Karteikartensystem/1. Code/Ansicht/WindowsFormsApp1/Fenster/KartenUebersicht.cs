using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FensterMethoden;

namespace WindowsFormsApp1
{
    public partial class KartenUebersicht : Form
    {
        private List<string> alleKarten;
        private UebersichtMethoden methoden = new UebersichtMethoden();

        public KartenUebersicht(string stapelName)
        {
            InitializeComponent();
            lbl_StapelName.Text = stapelName;


            alleKarten = methoden.DatenbankAbfrage();
            ListViewFormatieren();
        }

        private void ListViewFormatieren()
        {
            listView_KartenAnzeige.View = View.Details;
            listView_KartenAnzeige.Columns.Add("Kartename");
            KartenAnzeigen(alleKarten);
        }

        private void KartenAnzeigen(List<string> anzeigeList)
        {
            List<ListViewItem> listViewItem = new List<ListViewItem>();

            foreach (string stapel in anzeigeList)
            {
                listViewItem.Add(new ListViewItem(stapel));
            }

            listView_KartenAnzeige.Items.Clear();
            listView_KartenAnzeige.Items.AddRange(listViewItem.ToArray());
        }

        private void txt_KartenSuche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_KartenSuche.Text.Trim() == "")
                {
                    KartenAnzeigen(alleKarten);
                }

                else
                {
                    KartenSucheAnzeigen(txt_KartenSuche.Text);
                }

                txt_KartenSuche.Clear();
            }
        }

        private void KartenSucheAnzeigen(string eingabe)
        {
            List<string> gefundenList = methoden.GetGefundenList(eingabe, alleKarten);

            if (gefundenList.Count < 1)
            {
                MessageBox.Show("Leider kein Eintrag gefunden", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KartenAnzeigen(alleKarten);
            }

            else
            {
                KartenAnzeigen(gefundenList);
            }
        }

        private void ListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView_KartenAnzeige.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }
    }
}
