
namespace AnsichtsFenster.Fenster
{
    partial class StapelUebersichtView
    {

        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StapelUebersichtView));
            this.dachPanel = new System.Windows.Forms.Panel();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_StapelSuche = new System.Windows.Forms.TextBox();
            this.listView_Ausgabe = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_KartenHinzufuegen = new System.Windows.Forms.Button();
            this.btn_Entfernen = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btn_Challenge = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
=======
            this.InhaltPanel = new System.Windows.Forms.Panel();
            this.dachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> develop
            this.pnl_btn.SuspendLayout();
            this.InhaltPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.dachPanel.Size = new System.Drawing.Size(1200, 55);
            this.dachPanel.TabIndex = 7;
            this.dachPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dachPanel_MouseDown);
            this.dachPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dachPanel_MouseMove);
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
            this.ChallengeButton.Location = new System.Drawing.Point(535, 7);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(150, 40);
            this.ChallengeButton.TabIndex = 9;
            this.ChallengeButton.Text = "Challenge";
            this.ChallengeButton.UseVisualStyleBackColor = false;
            this.ChallengeButton.Click += new System.EventHandler(this.ChallengeButton_Click);
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
            this.MinimierenButton.Click += new System.EventHandler(this.MinimierenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CloseButton.Location = new System.Drawing.Point(1165, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 31);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_StapelSuche
            // 
<<<<<<< HEAD
            this.txt_StapelSuche.Location = new System.Drawing.Point(17, 72);
            this.txt_StapelSuche.Name = "txt_StapelSuche";
            this.txt_StapelSuche.Size = new System.Drawing.Size(306, 20);
=======
            this.txt_StapelSuche.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StapelSuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_StapelSuche.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StapelSuche.Location = new System.Drawing.Point(357, 30);
            this.txt_StapelSuche.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.txt_StapelSuche.Name = "txt_StapelSuche";
            this.txt_StapelSuche.Size = new System.Drawing.Size(698, 31);
>>>>>>> develop
            this.txt_StapelSuche.TabIndex = 0;
            this.txt_StapelSuche.Enter += new System.EventHandler(this.txt_StapelSuche_Enter);
            this.txt_StapelSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_StapelSuche_KeyDown);
            this.txt_StapelSuche.Leave += new System.EventHandler(this.txt_StapelSuche_Leave);
            // 
            // listView_Ausgabe
            // 
            this.listView_Ausgabe.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Ausgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Ausgabe.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Ausgabe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listView_Ausgabe.GridLines = true;
            this.listView_Ausgabe.HideSelection = false;
<<<<<<< HEAD
            this.listView_Ausgabe.Location = new System.Drawing.Point(17, 115);
            this.listView_Ausgabe.Name = "listView_Ausgabe";
            this.listView_Ausgabe.Size = new System.Drawing.Size(306, 292);
=======
            this.listView_Ausgabe.Location = new System.Drawing.Point(357, 121);
            this.listView_Ausgabe.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Ausgabe.Name = "listView_Ausgabe";
            this.listView_Ausgabe.Size = new System.Drawing.Size(755, 414);
>>>>>>> develop
            this.listView_Ausgabe.TabIndex = 1;
            this.listView_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listView_Ausgabe.View = System.Windows.Forms.View.Details;
            this.listView_Ausgabe.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.listView_Ausgabe.Click += new System.EventHandler(this.listView_Ausgabe_Click);
            this.listView_Ausgabe.DoubleClick += new System.EventHandler(this.listView_Ausgabe_DoubleClick);
            // 
<<<<<<< HEAD
            // lbl_SuchInfo
            // 
            this.lbl_SuchInfo.AutoSize = true;
            this.lbl_SuchInfo.Location = new System.Drawing.Point(14, 38);
            this.lbl_SuchInfo.Name = "lbl_SuchInfo";
            this.lbl_SuchInfo.Size = new System.Drawing.Size(162, 13);
            this.lbl_SuchInfo.TabIndex = 2;
            this.lbl_SuchInfo.Text = "Stabelsuche mit Enter bestätigen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_Ausgabe);
            this.panel1.Controls.Add(this.lbl_SuchInfo);
            this.panel1.Controls.Add(this.txt_StapelSuche);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 426);
            this.panel1.TabIndex = 3;
            // 
            // btn_StapelHinzufuegen
            // 
            this.btn_StapelHinzufuegen.Location = new System.Drawing.Point(4, 133);
            this.btn_StapelHinzufuegen.Name = "btn_StapelHinzufuegen";
            this.btn_StapelHinzufuegen.Size = new System.Drawing.Size(180, 35);
            this.btn_StapelHinzufuegen.TabIndex = 4;
            this.btn_StapelHinzufuegen.Text = "Stapel Hinzufügen";
            this.btn_StapelHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_StapelHinzufuegen.Click += new System.EventHandler(this.btn_StapelHinzufuegen_Click);
            // 
            // btn_Statisken
            // 
            this.btn_Statisken.Location = new System.Drawing.Point(4, 15);
            this.btn_Statisken.Name = "btn_Statisken";
            this.btn_Statisken.Size = new System.Drawing.Size(180, 35);
            this.btn_Statisken.TabIndex = 5;
            this.btn_Statisken.Text = "Statistiken";
            this.btn_Statisken.UseVisualStyleBackColor = true;
            this.btn_Statisken.Click += new System.EventHandler(this.JetztLernenEvent);
=======
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1080, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
>>>>>>> develop
            // 
            // pnl_btn
            // 
            this.pnl_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_btn.Controls.Add(this.btn_KartenHinzufuegen);
            this.pnl_btn.Controls.Add(this.btn_Entfernen);
<<<<<<< HEAD
            this.pnl_btn.Controls.Add(this.btn_StapelHinzufuegen);
            this.pnl_btn.Controls.Add(this.btn_Statisken);
            this.pnl_btn.Location = new System.Drawing.Point(551, 196);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(193, 242);
=======
            this.pnl_btn.Location = new System.Drawing.Point(37, 89);
            this.pnl_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(262, 158);
>>>>>>> develop
            this.pnl_btn.TabIndex = 6;
            // 
            // btn_KartenHinzufuegen
            // 
<<<<<<< HEAD
            this.btn_KartenHinzufuegen.Location = new System.Drawing.Point(4, 73);
            this.btn_KartenHinzufuegen.Name = "btn_KartenHinzufuegen";
            this.btn_KartenHinzufuegen.Size = new System.Drawing.Size(180, 35);
=======
            this.btn_KartenHinzufuegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.btn_KartenHinzufuegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KartenHinzufuegen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.btn_KartenHinzufuegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_KartenHinzufuegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_KartenHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KartenHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KartenHinzufuegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_KartenHinzufuegen.Location = new System.Drawing.Point(18, 32);
            this.btn_KartenHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KartenHinzufuegen.Name = "btn_KartenHinzufuegen";
            this.btn_KartenHinzufuegen.Size = new System.Drawing.Size(222, 43);
>>>>>>> develop
            this.btn_KartenHinzufuegen.TabIndex = 8;
            this.btn_KartenHinzufuegen.Text = "Karten Hinzufügen";
            this.btn_KartenHinzufuegen.UseVisualStyleBackColor = false;
            this.btn_KartenHinzufuegen.Click += new System.EventHandler(this.btn_KartenHinzufuegen_Click);
            // 
            // btn_Entfernen
            // 
<<<<<<< HEAD
            this.btn_Entfernen.Location = new System.Drawing.Point(4, 188);
            this.btn_Entfernen.Name = "btn_Entfernen";
            this.btn_Entfernen.Size = new System.Drawing.Size(180, 35);
=======
            this.btn_Entfernen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.btn_Entfernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entfernen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.btn_Entfernen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Entfernen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Entfernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entfernen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Entfernen.Location = new System.Drawing.Point(22, 93);
            this.btn_Entfernen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Entfernen.Name = "btn_Entfernen";
            this.btn_Entfernen.Size = new System.Drawing.Size(218, 43);
>>>>>>> develop
            this.btn_Entfernen.TabIndex = 7;
            this.btn_Entfernen.Text = "Entfernen";
            this.btn_Entfernen.UseVisualStyleBackColor = false;
            this.btn_Entfernen.Click += new System.EventHandler(this.btn_Entfernen_Click);
            // 
<<<<<<< HEAD
            // btn_Challenge
            // 
            this.btn_Challenge.Location = new System.Drawing.Point(555, 137);
            this.btn_Challenge.Name = "btn_Challenge";
            this.btn_Challenge.Size = new System.Drawing.Size(154, 23);
            this.btn_Challenge.TabIndex = 7;
            this.btn_Challenge.Text = "Challenge";
            this.btn_Challenge.UseVisualStyleBackColor = true;
            this.btn_Challenge.Click += new System.EventHandler(this.btn_Challenge_Click);
=======
            // InhaltPanel
            // 
            this.InhaltPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InhaltPanel.Controls.Add(this.pnl_btn);
            this.InhaltPanel.Controls.Add(this.pictureBox1);
            this.InhaltPanel.Controls.Add(this.listView_Ausgabe);
            this.InhaltPanel.Controls.Add(this.txt_StapelSuche);
            this.InhaltPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InhaltPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InhaltPanel.Location = new System.Drawing.Point(0, 55);
            this.InhaltPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InhaltPanel.Name = "InhaltPanel";
            this.InhaltPanel.Size = new System.Drawing.Size(1200, 595);
            this.InhaltPanel.TabIndex = 3;
>>>>>>> develop
            // 
            // StapelUebersichtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Challenge);
            this.Controls.Add(this.pnl_btn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
=======
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.InhaltPanel);
            this.Controls.Add(this.dachPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> develop
            this.Name = "StapelUebersichtView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stapel Übersicht";
            this.dachPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_btn.ResumeLayout(false);
            this.InhaltPanel.ResumeLayout(false);
            this.InhaltPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_StapelSuche;
        private System.Windows.Forms.ListView listView_Ausgabe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_btn;
        private System.Windows.Forms.Button btn_KartenHinzufuegen;
<<<<<<< HEAD
        private System.Windows.Forms.Button btn_Challenge;
=======
        private System.Windows.Forms.Button btn_Entfernen;
        private System.Windows.Forms.Panel InhaltPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button ChallengeButton;
>>>>>>> develop
    }
}

