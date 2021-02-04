using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;
using Model;

namespace AnsichtsFenster.Fenster
{
    public partial class HinzufuegenView : Form
    {
        private readonly StapelRepository repository = new StapelRepository();

        public HinzufuegenView()
        {
            InitializeComponent();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            Repositories.StapelRepository repository = new StapelRepository();
            string eingabe = txt_eingabe.Text;
            txt_eingabe.Clear();

            Stapel stapel = new Stapel();
            stapel.Name = eingabe;

            if (repository.AddStapel(stapel))
            {
                MessageBox.Show("Erfolgreich hinzugefügt", "Yippy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Es hat leider nicht geklappt", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            // base.Dispose();
        }
    }
}