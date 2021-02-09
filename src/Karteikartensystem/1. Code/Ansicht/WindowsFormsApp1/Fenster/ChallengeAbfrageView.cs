using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using Model;
using Repositories;

namespace AnsichtsFenster.Fenster
{
    public partial class ChallengeAbfrageView : Form
    {
        private Stapel selectedStapel;

        public ChallengeAbfrageView()
        {
            InitializeComponent();

            Object[] alleStapel = new StapelRepository().GetAlleStapel();

            listBoxStapel.Items.AddRange(alleStapel);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            selectedStapel = (Stapel) listBoxStapel.SelectedItem;

            if (int.TryParse(textBoxZeit.Text, out int zeitInMinuten) && zeitInMinuten > 0)
            {

                if (int.TryParse(textBoxAnzahlKarten.Text, out int anzahlKarten) && anzahlKarten > 0)
                {
                    Karte[] alleKartenEinesStapels = new KarteRepository().GetAlleKartenEinesStapels(selectedStapel.Id);

                    ChallengeView challengeView = new ChallengeView(zeitInMinuten, anzahlKarten, selectedStapel,
                        alleKartenEinesStapels.ToList());

                    challengeView.Show();
                }

                else
                {
                    MessageBox.Show("Es wurde keine Gültige Zeit angegeben", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Es wurde keine Gültige Anzahl an Karten angegeben", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }

}
