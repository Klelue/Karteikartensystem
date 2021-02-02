﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HinzufügenView : Form
    {
        public HinzufügenView()
        {
            InitializeComponent();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            string eingabe = txt_eingabe.Text;
            txt_eingabe.Clear();
            //eingabe zu datenbank
            MessageBox.Show("Erfolgreich hinzugefügt", "Yippy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            base.Dispose();
        }
    }
}
