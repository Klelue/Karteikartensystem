
namespace AnsichtsFenster.Fenster
{
    partial class KartenUebersicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartenUebersicht));
            this.btn_home = new System.Windows.Forms.Button();
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.InhaltPanel = new System.Windows.Forms.Panel();
            this.lblAuswertungOben = new System.Windows.Forms.Label();
            this.lblAuswertungUnten = new System.Windows.Forms.Label();
            this.btnStapelErneutLernen = new System.Windows.Forms.Button();
            this.btnNichtNochmal = new System.Windows.Forms.Button();
            this.btnEinfach = new System.Windows.Forms.Button();
            this.btn_Antwort = new System.Windows.Forms.Button();
            this.btnGut = new System.Windows.Forms.Button();
            this.btnNochmal = new System.Windows.Forms.Button();
            this.lbl_StapelName = new System.Windows.Forms.Label();
            this.dachPanel = new System.Windows.Forms.Panel();
            this.StapelWählenButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.imgParty = new System.Windows.Forms.PictureBox();
            this.InhaltPanel.SuspendLayout();
            this.dachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgParty)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btn_home.Location = new System.Drawing.Point(990, 7);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(260, 45);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Lernen beenden";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // richTxt
            // 
            this.richTxt.BackColor = System.Drawing.Color.White;
            this.richTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTxt.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTxt.Location = new System.Drawing.Point(150, 45);
            this.richTxt.Margin = new System.Windows.Forms.Padding(4);
            this.richTxt.Name = "richTxt";
            this.richTxt.ReadOnly = true;
            this.richTxt.Size = new System.Drawing.Size(1100, 520);
            this.richTxt.TabIndex = 4;
            this.richTxt.Text = "";
            // 
            // InhaltPanel
            // 
            this.InhaltPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InhaltPanel.Controls.Add(this.imgParty);
            this.InhaltPanel.Controls.Add(this.lblAuswertungOben);
            this.InhaltPanel.Controls.Add(this.lblAuswertungUnten);
            this.InhaltPanel.Controls.Add(this.btnStapelErneutLernen);
            this.InhaltPanel.Controls.Add(this.btnNichtNochmal);
            this.InhaltPanel.Controls.Add(this.btnEinfach);
            this.InhaltPanel.Controls.Add(this.btn_Antwort);
            this.InhaltPanel.Controls.Add(this.btnGut);
            this.InhaltPanel.Controls.Add(this.richTxt);
            this.InhaltPanel.Controls.Add(this.btnNochmal);
            this.InhaltPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InhaltPanel.Location = new System.Drawing.Point(0, 60);
            this.InhaltPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InhaltPanel.Name = "InhaltPanel";
            this.InhaltPanel.Size = new System.Drawing.Size(1400, 690);
            this.InhaltPanel.TabIndex = 5;
            // 
            // lblAuswertungOben
            // 
            this.lblAuswertungOben.AutoSize = true;
            this.lblAuswertungOben.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuswertungOben.Location = new System.Drawing.Point(518, 24);
            this.lblAuswertungOben.Name = "lblAuswertungOben";
            this.lblAuswertungOben.Size = new System.Drawing.Size(283, 41);
            this.lblAuswertungOben.TabIndex = 16;
            this.lblAuswertungOben.Text = "lblAuswertungOben";
            this.lblAuswertungOben.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAuswertungUnten
            // 
            this.lblAuswertungUnten.AutoSize = true;
            this.lblAuswertungUnten.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuswertungUnten.Location = new System.Drawing.Point(368, 75);
            this.lblAuswertungUnten.Name = "lblAuswertungUnten";
            this.lblAuswertungUnten.Size = new System.Drawing.Size(290, 41);
            this.lblAuswertungUnten.TabIndex = 15;
            this.lblAuswertungUnten.Text = "lblAuswertungUnten";
            this.lblAuswertungUnten.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStapelErneutLernen
            // 
            this.btnStapelErneutLernen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnStapelErneutLernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStapelErneutLernen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnStapelErneutLernen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnStapelErneutLernen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnStapelErneutLernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStapelErneutLernen.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStapelErneutLernen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStapelErneutLernen.Location = new System.Drawing.Point(1000, 590);
            this.btnStapelErneutLernen.Margin = new System.Windows.Forms.Padding(4);
            this.btnStapelErneutLernen.Name = "btnStapelErneutLernen";
            this.btnStapelErneutLernen.Size = new System.Drawing.Size(250, 45);
            this.btnStapelErneutLernen.TabIndex = 12;
            this.btnStapelErneutLernen.Text = "Stapel erneut lernen";
            this.btnStapelErneutLernen.UseVisualStyleBackColor = false;
            this.btnStapelErneutLernen.Click += new System.EventHandler(this.btnErneutLernen);
            // 
            // btnNichtNochmal
            // 
            this.btnNichtNochmal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnNichtNochmal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNichtNochmal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnNichtNochmal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNichtNochmal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnNichtNochmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNichtNochmal.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNichtNochmal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNichtNochmal.Location = new System.Drawing.Point(1000, 590);
            this.btnNichtNochmal.Margin = new System.Windows.Forms.Padding(4);
            this.btnNichtNochmal.Name = "btnNichtNochmal";
            this.btnNichtNochmal.Size = new System.Drawing.Size(180, 45);
            this.btnNichtNochmal.TabIndex = 11;
            this.btnNichtNochmal.Text = "Nicht nochmal ";
            this.btnNichtNochmal.UseVisualStyleBackColor = false;
            this.btnNichtNochmal.Click += new System.EventHandler(this.btn_nichtNochmal);
            // 
            // btnEinfach
            // 
            this.btnEinfach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEinfach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEinfach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnEinfach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEinfach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEinfach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEinfach.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinfach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEinfach.Location = new System.Drawing.Point(740, 590);
            this.btnEinfach.Margin = new System.Windows.Forms.Padding(4);
            this.btnEinfach.Name = "btnEinfach";
            this.btnEinfach.Size = new System.Drawing.Size(180, 45);
            this.btnEinfach.TabIndex = 10;
            this.btnEinfach.Text = "Einfach";
            this.btnEinfach.UseVisualStyleBackColor = false;
            this.btnEinfach.Click += new System.EventHandler(this.btn_Einfach);
            // 
            // btn_Antwort
            // 
            this.btn_Antwort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_Antwort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Antwort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_Antwort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Antwort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_Antwort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Antwort.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Antwort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Antwort.Location = new System.Drawing.Point(572, 590);
            this.btn_Antwort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Antwort.Name = "btn_Antwort";
            this.btn_Antwort.Size = new System.Drawing.Size(250, 45);
            this.btn_Antwort.TabIndex = 6;
            this.btn_Antwort.Text = "Antwort anzeigen";
            this.btn_Antwort.UseVisualStyleBackColor = false;
            this.btn_Antwort.Click += new System.EventHandler(this.btn_Antwort_Click);
            // 
            // btnGut
            // 
            this.btnGut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnGut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnGut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGut.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGut.Location = new System.Drawing.Point(480, 590);
            this.btnGut.Margin = new System.Windows.Forms.Padding(4);
            this.btnGut.Name = "btnGut";
            this.btnGut.Size = new System.Drawing.Size(180, 45);
            this.btnGut.TabIndex = 9;
            this.btnGut.Text = "Gut";
            this.btnGut.UseVisualStyleBackColor = false;
            this.btnGut.Click += new System.EventHandler(this.btn_Gut_Click);
            // 
            // btnNochmal
            // 
            this.btnNochmal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnNochmal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNochmal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnNochmal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNochmal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnNochmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNochmal.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNochmal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNochmal.Location = new System.Drawing.Point(220, 590);
            this.btnNochmal.Margin = new System.Windows.Forms.Padding(4);
            this.btnNochmal.Name = "btnNochmal";
            this.btnNochmal.Size = new System.Drawing.Size(180, 45);
            this.btnNochmal.TabIndex = 8;
            this.btnNochmal.Text = "Nochmal";
            this.btnNochmal.UseVisualStyleBackColor = false;
            this.btnNochmal.Click += new System.EventHandler(this.btn_Nochmal);
            // 
            // lbl_StapelName
            // 
            this.lbl_StapelName.AutoSize = true;
            this.lbl_StapelName.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StapelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_StapelName.Location = new System.Drawing.Point(39, 15);
            this.lbl_StapelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StapelName.Name = "lbl_StapelName";
            this.lbl_StapelName.Size = new System.Drawing.Size(148, 31);
            this.lbl_StapelName.TabIndex = 2;
            this.lbl_StapelName.Text = "StapelName";
            // 
            // dachPanel
            // 
            this.dachPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.dachPanel.Controls.Add(this.StapelWählenButton);
            this.dachPanel.Controls.Add(this.MinimierenButton);
            this.dachPanel.Controls.Add(this.CloseButton);
            this.dachPanel.Controls.Add(this.lbl_StapelName);
            this.dachPanel.Controls.Add(this.btn_home);
            this.dachPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dachPanel.Location = new System.Drawing.Point(0, 0);
            this.dachPanel.Name = "dachPanel";
            this.dachPanel.Size = new System.Drawing.Size(1400, 60);
            this.dachPanel.TabIndex = 7;
            this.dachPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dachPanel_MouseDown);
            this.dachPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dachPanel_MouseMove);
            // 
            // StapelWählenButton
            // 
            this.StapelWählenButton.BackColor = System.Drawing.Color.Transparent;
            this.StapelWählenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StapelWählenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StapelWählenButton.FlatAppearance.BorderSize = 0;
            this.StapelWählenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.StapelWählenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.StapelWählenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StapelWählenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StapelWählenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.StapelWählenButton.Location = new System.Drawing.Point(750, 7);
            this.StapelWählenButton.Margin = new System.Windows.Forms.Padding(4);
            this.StapelWählenButton.Name = "StapelWählenButton";
            this.StapelWählenButton.Size = new System.Drawing.Size(220, 45);
            this.StapelWählenButton.TabIndex = 11;
            this.StapelWählenButton.Text = "Stapel wählen";
            this.StapelWählenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StapelWählenButton.UseVisualStyleBackColor = false;
            this.StapelWählenButton.Click += new System.EventHandler(this.StapelWählenButton_Click);
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
            this.MinimierenButton.Location = new System.Drawing.Point(1325, 0);
            this.MinimierenButton.Name = "MinimierenButton";
            this.MinimierenButton.Size = new System.Drawing.Size(45, 35);
            this.MinimierenButton.TabIndex = 10;
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
            this.CloseButton.Location = new System.Drawing.Point(1365, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // imgParty
            // 
            this.imgParty.Image = global::AnsichtsFenster.Properties.Resources.celebration;
            this.imgParty.Location = new System.Drawing.Point(62, 162);
            this.imgParty.Name = "imgParty";
            this.imgParty.Size = new System.Drawing.Size(690, 485);
            this.imgParty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgParty.TabIndex = 17;
            this.imgParty.TabStop = false;
            // 
            // KartenUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.dachPanel);
            this.Controls.Add(this.InhaltPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KartenUebersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Karten lernen";
            this.InhaltPanel.ResumeLayout(false);
            this.InhaltPanel.PerformLayout();
            this.dachPanel.ResumeLayout(false);
            this.dachPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgParty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.RichTextBox richTxt;
        private System.Windows.Forms.Panel InhaltPanel;
        private System.Windows.Forms.Button btn_Antwort;
        private System.Windows.Forms.Button btnGut;
        private System.Windows.Forms.Button btnNochmal;
        private System.Windows.Forms.Label lbl_StapelName;
        private System.Windows.Forms.Button btnEinfach;
        private System.Windows.Forms.Button btnNichtNochmal;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button btnStapelErneutLernen;
        private System.Windows.Forms.Label lblAuswertungUnten;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StapelWählenButton;
        private System.Windows.Forms.Label lblAuswertungOben;
        private System.Windows.Forms.PictureBox imgParty;
    }
}