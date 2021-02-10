﻿
namespace AnsichtsFenster.Fenster
{
    partial class StapelBearbeitenView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StapelBearbeitenView));
            this.textBoxStapelName = new System.Windows.Forms.TextBox();
            this.stapelAnlegen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateiAuswählen = new System.Windows.Forms.Button();
            this.StapelExportieren = new System.Windows.Forms.Button();
            this.stapelAktualisieren = new System.Windows.Forms.Button();
            this.listBoxStapel = new System.Windows.Forms.ListBox();
            this.stapelLöschen = new System.Windows.Forms.Button();
            this.dachPanel = new System.Windows.Forms.Panel();
            this.StapelBearbeitenButton = new System.Windows.Forms.Button();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.JetztLernenButton = new System.Windows.Forms.Button();
            this.KarteBearbeitenButton = new System.Windows.Forms.Button();
            this.ÜbersichtButton = new System.Windows.Forms.Button();
            this.InhaltPanel = new System.Windows.Forms.Panel();
            this.dachPanel.SuspendLayout();
            this.InhaltPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStapelName
            // 
            this.textBoxStapelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStapelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStapelName.Location = new System.Drawing.Point(473, 41);
            this.textBoxStapelName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStapelName.Multiline = true;
            this.textBoxStapelName.Name = "textBoxStapelName";
            this.textBoxStapelName.Size = new System.Drawing.Size(472, 30);
            this.textBoxStapelName.TabIndex = 0;
            // 
            // stapelAnlegen
            // 
            this.stapelAnlegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stapelAnlegen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.stapelAnlegen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.stapelAnlegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stapelAnlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stapelAnlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapelAnlegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stapelAnlegen.Location = new System.Drawing.Point(473, 95);
            this.stapelAnlegen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stapelAnlegen.Name = "stapelAnlegen";
            this.stapelAnlegen.Size = new System.Drawing.Size(124, 37);
            this.stapelAnlegen.TabIndex = 1;
            this.stapelAnlegen.Text = "Stapel erstellen";
            this.stapelAnlegen.UseVisualStyleBackColor = true;
            this.stapelAnlegen.Click += new System.EventHandler(this.stapelAnlegen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Stapel-Export-Datei|*.sed";
            // 
            // dateiAuswählen
            // 
            this.dateiAuswählen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateiAuswählen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.dateiAuswählen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.dateiAuswählen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateiAuswählen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateiAuswählen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateiAuswählen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateiAuswählen.Location = new System.Drawing.Point(720, 266);
            this.dateiAuswählen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateiAuswählen.Name = "dateiAuswählen";
            this.dateiAuswählen.Size = new System.Drawing.Size(225, 37);
            this.dateiAuswählen.TabIndex = 2;
            this.dateiAuswählen.Text = "Stapel importieren";
            this.dateiAuswählen.UseVisualStyleBackColor = true;
            this.dateiAuswählen.Click += new System.EventHandler(this.dateiAuswählen_Click);
            // 
            // StapelExportieren
            // 
            this.StapelExportieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StapelExportieren.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.StapelExportieren.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.StapelExportieren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StapelExportieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StapelExportieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StapelExportieren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StapelExportieren.Location = new System.Drawing.Point(473, 266);
            this.StapelExportieren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StapelExportieren.Name = "StapelExportieren";
            this.StapelExportieren.Size = new System.Drawing.Size(225, 37);
            this.StapelExportieren.TabIndex = 3;
            this.StapelExportieren.Text = "Stapel exportieren";
            this.StapelExportieren.UseVisualStyleBackColor = true;
            this.StapelExportieren.Click += new System.EventHandler(this.StapelExportieren_Click);
            // 
            // stapelAktualisieren
            // 
            this.stapelAktualisieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stapelAktualisieren.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.stapelAktualisieren.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.stapelAktualisieren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stapelAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stapelAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapelAktualisieren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stapelAktualisieren.Location = new System.Drawing.Point(750, 95);
            this.stapelAktualisieren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stapelAktualisieren.Name = "stapelAktualisieren";
            this.stapelAktualisieren.Size = new System.Drawing.Size(195, 37);
            this.stapelAktualisieren.TabIndex = 10;
            this.stapelAktualisieren.Text = "Stapelname aktualisieren";
            this.stapelAktualisieren.UseVisualStyleBackColor = true;
            this.stapelAktualisieren.Click += new System.EventHandler(this.stapelAktualisieren_Click);
            // 
            // listBoxStapel
            // 
            this.listBoxStapel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxStapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStapel.FormattingEnabled = true;
            this.listBoxStapel.ItemHeight = 20;
            this.listBoxStapel.Location = new System.Drawing.Point(52, 41);
            this.listBoxStapel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxStapel.Name = "listBoxStapel";
            this.listBoxStapel.Size = new System.Drawing.Size(370, 460);
            this.listBoxStapel.TabIndex = 11;
            // 
            // stapelLöschen
            // 
            this.stapelLöschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stapelLöschen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.stapelLöschen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.stapelLöschen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stapelLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stapelLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapelLöschen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stapelLöschen.Location = new System.Drawing.Point(473, 178);
            this.stapelLöschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stapelLöschen.Name = "stapelLöschen";
            this.stapelLöschen.Size = new System.Drawing.Size(124, 37);
            this.stapelLöschen.TabIndex = 12;
            this.stapelLöschen.Text = "Löschen";
            this.stapelLöschen.UseVisualStyleBackColor = true;
            this.stapelLöschen.Click += new System.EventHandler(this.stapelLöschen_Click);
            // 
            // dachPanel
            // 
            this.dachPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.dachPanel.Controls.Add(this.StapelBearbeitenButton);
            this.dachPanel.Controls.Add(this.ChallengeButton);
            this.dachPanel.Controls.Add(this.MinimierenButton);
            this.dachPanel.Controls.Add(this.CloseButton);
            this.dachPanel.Controls.Add(this.JetztLernenButton);
            this.dachPanel.Controls.Add(this.KarteBearbeitenButton);
            this.dachPanel.Controls.Add(this.ÜbersichtButton);
            this.dachPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dachPanel.Location = new System.Drawing.Point(0, 0);
            this.dachPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dachPanel.Name = "dachPanel";
            this.dachPanel.Size = new System.Drawing.Size(1050, 49);
            this.dachPanel.TabIndex = 13;
            this.dachPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dachPanel_MouseDown);
            this.dachPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dachPanel_MouseMove);
            // 
            // StapelBearbeitenButton
            // 
            this.StapelBearbeitenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.StapelBearbeitenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StapelBearbeitenButton.FlatAppearance.BorderSize = 0;
            this.StapelBearbeitenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.StapelBearbeitenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.StapelBearbeitenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StapelBearbeitenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StapelBearbeitenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.StapelBearbeitenButton.Location = new System.Drawing.Point(352, 6);
            this.StapelBearbeitenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StapelBearbeitenButton.Name = "StapelBearbeitenButton";
            this.StapelBearbeitenButton.Size = new System.Drawing.Size(188, 37);
            this.StapelBearbeitenButton.TabIndex = 10;
            this.StapelBearbeitenButton.Text = "Stapel bearbeiten";
            this.StapelBearbeitenButton.UseVisualStyleBackColor = false;
            this.StapelBearbeitenButton.Click += new System.EventHandler(this.StapelBearbeitenButton_Click);
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ChallengeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChallengeButton.FlatAppearance.BorderSize = 0;
            this.ChallengeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.ChallengeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.ChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChallengeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.ChallengeButton.Location = new System.Drawing.Point(720, 6);
            this.ChallengeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(190, 37);
            this.ChallengeButton.TabIndex = 9;
            this.ChallengeButton.Text = "Challenge Mode";
            this.ChallengeButton.UseVisualStyleBackColor = false;
            this.ChallengeButton.Click += new System.EventHandler(this.ChallengeButton_Click);
            // 
            // MinimierenButton
            // 
            this.MinimierenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimierenButton.FlatAppearance.BorderSize = 0;
            this.MinimierenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.MinimierenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.MinimierenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimierenButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimierenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.MinimierenButton.Location = new System.Drawing.Point(994, 0);
            this.MinimierenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimierenButton.Name = "MinimierenButton";
            this.MinimierenButton.Size = new System.Drawing.Size(34, 28);
            this.MinimierenButton.TabIndex = 8;
            this.MinimierenButton.Text = "__";
            this.MinimierenButton.UseVisualStyleBackColor = true;
            this.MinimierenButton.Click += new System.EventHandler(this.MinimierenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CloseButton.Location = new System.Drawing.Point(1024, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 28);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // JetztLernenButton
            // 
            this.JetztLernenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.JetztLernenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JetztLernenButton.FlatAppearance.BorderSize = 0;
            this.JetztLernenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.JetztLernenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.JetztLernenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JetztLernenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JetztLernenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.JetztLernenButton.Location = new System.Drawing.Point(555, 6);
            this.JetztLernenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JetztLernenButton.Name = "JetztLernenButton";
            this.JetztLernenButton.Size = new System.Drawing.Size(150, 37);
            this.JetztLernenButton.TabIndex = 3;
            this.JetztLernenButton.Text = "Jetzt lernen";
            this.JetztLernenButton.UseVisualStyleBackColor = false;
            this.JetztLernenButton.Click += new System.EventHandler(this.JetztLernenButton_Click);
            // 
            // KarteBearbeitenButton
            // 
            this.KarteBearbeitenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.KarteBearbeitenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KarteBearbeitenButton.FlatAppearance.BorderSize = 0;
            this.KarteBearbeitenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.KarteBearbeitenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.KarteBearbeitenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KarteBearbeitenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KarteBearbeitenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.KarteBearbeitenButton.Location = new System.Drawing.Point(158, 6);
            this.KarteBearbeitenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KarteBearbeitenButton.Name = "KarteBearbeitenButton";
            this.KarteBearbeitenButton.Size = new System.Drawing.Size(188, 37);
            this.KarteBearbeitenButton.TabIndex = 2;
            this.KarteBearbeitenButton.Text = "Karten bearbeiten";
            this.KarteBearbeitenButton.UseVisualStyleBackColor = false;
            this.KarteBearbeitenButton.Click += new System.EventHandler(this.KarteBearbeitenButton_Click);
            // 
            // ÜbersichtButton
            // 
            this.ÜbersichtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))), ((int)(((byte)(204)))));
            this.ÜbersichtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ÜbersichtButton.FlatAppearance.BorderSize = 0;
            this.ÜbersichtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.ÜbersichtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.ÜbersichtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ÜbersichtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ÜbersichtButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.ÜbersichtButton.Location = new System.Drawing.Point(26, 6);
            this.ÜbersichtButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ÜbersichtButton.Name = "ÜbersichtButton";
            this.ÜbersichtButton.Size = new System.Drawing.Size(112, 37);
            this.ÜbersichtButton.TabIndex = 1;
            this.ÜbersichtButton.Text = "Übersicht";
            this.ÜbersichtButton.UseVisualStyleBackColor = false;
            this.ÜbersichtButton.Click += new System.EventHandler(this.ÜbersichtButton_Click);
            // 
            // InhaltPanel
            // 
            this.InhaltPanel.Controls.Add(this.listBoxStapel);
            this.InhaltPanel.Controls.Add(this.textBoxStapelName);
            this.InhaltPanel.Controls.Add(this.stapelLöschen);
            this.InhaltPanel.Controls.Add(this.stapelAnlegen);
            this.InhaltPanel.Controls.Add(this.dateiAuswählen);
            this.InhaltPanel.Controls.Add(this.stapelAktualisieren);
            this.InhaltPanel.Controls.Add(this.StapelExportieren);
            this.InhaltPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InhaltPanel.Location = new System.Drawing.Point(0, 48);
            this.InhaltPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InhaltPanel.Name = "InhaltPanel";
            this.InhaltPanel.Size = new System.Drawing.Size(1050, 561);
            this.InhaltPanel.TabIndex = 14;
            // 
            // StapelBearbeitenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 609);
            this.Controls.Add(this.InhaltPanel);
            this.Controls.Add(this.dachPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.Name = "StapelBearbeitenView";
            this.Text = "StapelBearbeitenView";
            this.Load += new System.EventHandler(this.StapelBearbeitenView_Load);
            this.dachPanel.ResumeLayout(false);
            this.InhaltPanel.ResumeLayout(false);
            this.InhaltPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStapelName;
        private System.Windows.Forms.Button stapelAnlegen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button dateiAuswählen;
        private System.Windows.Forms.Button StapelExportieren;
        private System.Windows.Forms.Button stapelAktualisieren;
        private System.Windows.Forms.ListBox listBoxStapel;
        private System.Windows.Forms.Button stapelLöschen;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button StapelBearbeitenButton;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button JetztLernenButton;
        private System.Windows.Forms.Button KarteBearbeitenButton;
        private System.Windows.Forms.Button ÜbersichtButton;
        private System.Windows.Forms.Panel InhaltPanel;
    }
}