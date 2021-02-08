using System;

using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class JetztLernenView : Form
    {
        public JetztLernenView()
        {
            InitializeComponent();

            Object[] alleStapel = new StapelRepository().GetAlleStapel();

            listBoxLampe.Items.AddRange(alleStapel);
        }

        private void StapelBoxClick(object sender, EventArgs e)
        {
            Stapel selectedStapel = (Stapel) listBoxLampe.SelectedItem;

            KartenUebersicht kartenUebersicht = new KartenUebersicht(selectedStapel);

            this.Hide();

            kartenUebersicht.Show();

        }
    }
}
