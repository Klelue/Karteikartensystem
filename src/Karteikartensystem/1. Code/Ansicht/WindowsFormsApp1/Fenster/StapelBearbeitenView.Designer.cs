
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
            this.textBoxStapelName = new System.Windows.Forms.TextBox();
            this.stapelAnlegen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateiAuswählen = new System.Windows.Forms.Button();
            this.StapelExportieren = new System.Windows.Forms.Button();
            this.dachPanel = new System.Windows.Forms.Panel();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stapelAktualisieren = new System.Windows.Forms.Button();
            this.listBoxStapel = new System.Windows.Forms.ListBox();
            this.stapelLöschen = new System.Windows.Forms.Button();
            this.dachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStapelName
            // 
            this.textBoxStapelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStapelName.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStapelName.Location = new System.Drawing.Point(434, 93);
            this.textBoxStapelName.Name = "textBoxStapelName";
            this.textBoxStapelName.Size = new System.Drawing.Size(448, 23);
            this.textBoxStapelName.TabIndex = 0;
            // 
            // stapelAnlegen
            // 
            this.stapelAnlegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stapelAnlegen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelAnlegen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelAnlegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelAnlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stapelAnlegen.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapelAnlegen.Location = new System.Drawing.Point(434, 141);
            this.stapelAnlegen.Name = "stapelAnlegen";
            this.stapelAnlegen.Size = new System.Drawing.Size(165, 43);
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
            this.dateiAuswählen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dateiAuswählen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dateiAuswählen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dateiAuswählen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateiAuswählen.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateiAuswählen.Location = new System.Drawing.Point(364, 547);
            this.dateiAuswählen.Name = "dateiAuswählen";
            this.dateiAuswählen.Size = new System.Drawing.Size(363, 35);
            this.dateiAuswählen.TabIndex = 2;
            this.dateiAuswählen.Text = "Stapel importieren";
            this.dateiAuswählen.UseVisualStyleBackColor = true;
            this.dateiAuswählen.Click += new System.EventHandler(this.dateiAuswählen_Click);
            // 
            // StapelExportieren
            // 
            this.StapelExportieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StapelExportieren.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.StapelExportieren.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.StapelExportieren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.StapelExportieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StapelExportieren.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StapelExportieren.Location = new System.Drawing.Point(61, 547);
            this.StapelExportieren.Name = "StapelExportieren";
            this.StapelExportieren.Size = new System.Drawing.Size(297, 37);
            this.StapelExportieren.TabIndex = 3;
            this.StapelExportieren.Text = "Stapel exportieren";
            this.StapelExportieren.UseVisualStyleBackColor = true;
            this.StapelExportieren.Click += new System.EventHandler(this.StapelExportieren_Click);
            // 
            // dachPanel
            // 
            this.dachPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.dachPanel.Controls.Add(this.ChallengeButton);
            this.dachPanel.Controls.Add(this.MinimierenButton);
            this.dachPanel.Controls.Add(this.CloseButton);
            this.dachPanel.Controls.Add(this.button3);
            this.dachPanel.Controls.Add(this.button2);
            this.dachPanel.Controls.Add(this.button1);
            this.dachPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dachPanel.Location = new System.Drawing.Point(0, 0);
            this.dachPanel.Name = "dachPanel";
            this.dachPanel.Size = new System.Drawing.Size(1212, 55);
            this.dachPanel.TabIndex = 8;
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ChallengeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChallengeButton.FlatAppearance.BorderSize = 0;
            this.ChallengeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.ChallengeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.ChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChallengeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.ChallengeButton.Location = new System.Drawing.Point(547, 7);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(150, 40);
            this.ChallengeButton.TabIndex = 9;
            this.ChallengeButton.Text = "Challenge";
            this.ChallengeButton.UseVisualStyleBackColor = false;
            // 
            // MinimierenButton
            // 
            this.MinimierenButton.FlatAppearance.BorderSize = 0;
            this.MinimierenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.MinimierenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.MinimierenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimierenButton.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimierenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.MinimierenButton.Location = new System.Drawing.Point(1135, 0);
            this.MinimierenButton.Name = "MinimierenButton";
            this.MinimierenButton.Size = new System.Drawing.Size(35, 31);
            this.MinimierenButton.TabIndex = 8;
            this.MinimierenButton.Text = "__";
            this.MinimierenButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CloseButton.Location = new System.Drawing.Point(1164, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 31);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button3.Location = new System.Drawing.Point(380, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Jetzt lernen";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button2.Location = new System.Drawing.Point(159, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Karte bearbeiten";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(29, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Übersicht";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // stapelAktualisieren
            // 
            this.stapelAktualisieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stapelAktualisieren.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelAktualisieren.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelAktualisieren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stapelAktualisieren.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapelAktualisieren.Location = new System.Drawing.Point(630, 141);
            this.stapelAktualisieren.Name = "stapelAktualisieren";
            this.stapelAktualisieren.Size = new System.Drawing.Size(263, 43);
            this.stapelAktualisieren.TabIndex = 10;
            this.stapelAktualisieren.Text = "Stapelname aktualisieren";
            this.stapelAktualisieren.UseVisualStyleBackColor = true;
            this.stapelAktualisieren.Click += new System.EventHandler(this.stapelAktualisieren_Click);
            // 
            // listBoxStapel
            // 
            this.listBoxStapel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStapel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStapel.FormattingEnabled = true;
            this.listBoxStapel.ItemHeight = 28;
            this.listBoxStapel.Location = new System.Drawing.Point(61, 93);
            this.listBoxStapel.Name = "listBoxStapel";
            this.listBoxStapel.Size = new System.Drawing.Size(313, 392);
            this.listBoxStapel.TabIndex = 11;
            // 
            // stapelLöschen
            // 
            this.stapelLöschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stapelLöschen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelLöschen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelLöschen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.stapelLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stapelLöschen.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapelLöschen.Location = new System.Drawing.Point(402, 442);
            this.stapelLöschen.Name = "stapelLöschen";
            this.stapelLöschen.Size = new System.Drawing.Size(165, 43);
            this.stapelLöschen.TabIndex = 12;
            this.stapelLöschen.Text = "löschen";
            this.stapelLöschen.UseVisualStyleBackColor = true;
            this.stapelLöschen.Click += new System.EventHandler(this.stapelLöschen_Click);
            // 
            // StapelBearbeitenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 675);
            this.Controls.Add(this.stapelLöschen);
            this.Controls.Add(this.listBoxStapel);
            this.Controls.Add(this.stapelAktualisieren);
            this.Controls.Add(this.dachPanel);
            this.Controls.Add(this.StapelExportieren);
            this.Controls.Add(this.dateiAuswählen);
            this.Controls.Add(this.stapelAnlegen);
            this.Controls.Add(this.textBoxStapelName);
            this.Name = "StapelBearbeitenView";
            this.Text = "StapelBearbeitenView";
            this.Load += new System.EventHandler(this.StapelBearbeitenView_Load);
            this.dachPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStapelName;
        private System.Windows.Forms.Button stapelAnlegen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button dateiAuswählen;
        private System.Windows.Forms.Button StapelExportieren;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stapelAktualisieren;
        private System.Windows.Forms.ListBox listBoxStapel;
        private System.Windows.Forms.Button stapelLöschen;
    }
}