namespace AnsichtsFenster.Fenster
{
    partial class HinzufuegenKarten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HinzufuegenKarten));
            this.richTxt_Vorderseite = new System.Windows.Forms.RichTextBox();
            this.richTxt_Rueckseite = new System.Windows.Forms.RichTextBox();
            this.lbl_Vorderseite = new System.Windows.Forms.Label();
            this.lbl_Rueckseite = new System.Windows.Forms.Label();
            this.btn_Hinzufuegen = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_KartenSuche = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView_KartenAnzeige = new System.Windows.Forms.ListView();
            this.InhaltPanel = new System.Windows.Forms.Panel();
            this.fackeAntwort3 = new System.Windows.Forms.RichTextBox();
            this.fackeAntwort2 = new System.Windows.Forms.RichTextBox();
            this.fackeAntwort1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dachPanel = new System.Windows.Forms.Panel();
            this.StapelBearbeitenButton = new System.Windows.Forms.Button();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.JetztLernenButton = new System.Windows.Forms.Button();
            this.KarteBearbeitenButton = new System.Windows.Forms.Button();
            this.ÜbersichtButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InhaltPanel.SuspendLayout();
            this.dachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxt_Vorderseite
            // 
            this.richTxt_Vorderseite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxt_Vorderseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt_Vorderseite.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.richTxt_Vorderseite.Location = new System.Drawing.Point(364, 52);
            this.richTxt_Vorderseite.Name = "richTxt_Vorderseite";
            this.richTxt_Vorderseite.Size = new System.Drawing.Size(322, 403);
            this.richTxt_Vorderseite.TabIndex = 100;
            this.richTxt_Vorderseite.Text = "";
            this.richTxt_Vorderseite.Enter += new System.EventHandler(this.richTxt_Vorderseite_Enter);
            this.richTxt_Vorderseite.Leave += new System.EventHandler(this.richTxt_Vorderseite_Leave);
            // 
            // richTxt_Rueckseite
            // 
            this.richTxt_Rueckseite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxt_Rueckseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt_Rueckseite.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.richTxt_Rueckseite.Location = new System.Drawing.Point(705, 52);
            this.richTxt_Rueckseite.Name = "richTxt_Rueckseite";
            this.richTxt_Rueckseite.Size = new System.Drawing.Size(322, 89);
            this.richTxt_Rueckseite.TabIndex = 1;
            this.richTxt_Rueckseite.Text = "";
            this.richTxt_Rueckseite.Enter += new System.EventHandler(this.richTxt_Rueckseite_Enter);
            this.richTxt_Rueckseite.Leave += new System.EventHandler(this.richTxt_Rueckseite_Leave);
            // 
            // lbl_Vorderseite
            // 
            this.lbl_Vorderseite.AutoSize = true;
            this.lbl_Vorderseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vorderseite.Location = new System.Drawing.Point(495, 16);
            this.lbl_Vorderseite.Name = "lbl_Vorderseite";
            this.lbl_Vorderseite.Size = new System.Drawing.Size(56, 20);
            this.lbl_Vorderseite.TabIndex = 2;
            this.lbl_Vorderseite.Text = "Frage";
            // 
            // lbl_Rueckseite
            // 
            this.lbl_Rueckseite.AutoSize = true;
            this.lbl_Rueckseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rueckseite.Location = new System.Drawing.Point(795, 16);
            this.lbl_Rueckseite.Name = "lbl_Rueckseite";
            this.lbl_Rueckseite.Size = new System.Drawing.Size(142, 20);
            this.lbl_Rueckseite.TabIndex = 3;
            this.lbl_Rueckseite.Text = "Richtige Antwort";
            // 
            // btn_Hinzufuegen
            // 
            this.btn_Hinzufuegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_Hinzufuegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hinzufuegen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_Hinzufuegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Hinzufuegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Hinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hinzufuegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Hinzufuegen.Location = new System.Drawing.Point(627, 479);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new System.Drawing.Size(112, 37);
            this.btn_Hinzufuegen.TabIndex = 4;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = false;
            this.btn_Hinzufuegen.Click += new System.EventHandler(this.btn_Hinzufuegen_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Save.Location = new System.Drawing.Point(401, 479);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 37);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Editieren";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_editieren_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Delete.Location = new System.Drawing.Point(851, 479);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 37);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Löschen";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_KartenSuche
            // 
            this.txt_KartenSuche.BackColor = System.Drawing.SystemColors.Window;
            this.txt_KartenSuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KartenSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KartenSuche.Location = new System.Drawing.Point(19, 52);
            this.txt_KartenSuche.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_KartenSuche.Multiline = true;
            this.txt_KartenSuche.Name = "txt_KartenSuche";
            this.txt_KartenSuche.Size = new System.Drawing.Size(276, 25);
            this.txt_KartenSuche.TabIndex = 9;
            this.txt_KartenSuche.Enter += new System.EventHandler(this.txt_KartenSuche_Enter);
            this.txt_KartenSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KartenSuche_KeyDown);
            this.txt_KartenSuche.Leave += new System.EventHandler(this.txt_KartenSuche_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 25);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // listView_KartenAnzeige
            // 
            this.listView_KartenAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_KartenAnzeige.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_KartenAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_KartenAnzeige.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listView_KartenAnzeige.GridLines = true;
            this.listView_KartenAnzeige.HideSelection = false;
            this.listView_KartenAnzeige.Location = new System.Drawing.Point(19, 89);
            this.listView_KartenAnzeige.Name = "listView_KartenAnzeige";
            this.listView_KartenAnzeige.Size = new System.Drawing.Size(322, 366);
            this.listView_KartenAnzeige.TabIndex = 1;
            this.listView_KartenAnzeige.UseCompatibleStateImageBehavior = false;
            this.listView_KartenAnzeige.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_KartenAnzeige_ColumnClick);
            this.listView_KartenAnzeige.Click += new System.EventHandler(this.listView_KartenAnzeige_Click);
            // 
            // InhaltPanel
            // 
            this.InhaltPanel.Controls.Add(this.fackeAntwort3);
            this.InhaltPanel.Controls.Add(this.fackeAntwort2);
            this.InhaltPanel.Controls.Add(this.fackeAntwort1);
            this.InhaltPanel.Controls.Add(this.label1);
            this.InhaltPanel.Controls.Add(this.listView_KartenAnzeige);
            this.InhaltPanel.Controls.Add(this.pictureBox1);
            this.InhaltPanel.Controls.Add(this.txt_KartenSuche);
            this.InhaltPanel.Controls.Add(this.richTxt_Vorderseite);
            this.InhaltPanel.Controls.Add(this.richTxt_Rueckseite);
            this.InhaltPanel.Controls.Add(this.comboBox1);
            this.InhaltPanel.Controls.Add(this.btn_Save);
            this.InhaltPanel.Controls.Add(this.btn_Hinzufuegen);
            this.InhaltPanel.Controls.Add(this.btn_Delete);
            this.InhaltPanel.Controls.Add(this.lbl_Vorderseite);
            this.InhaltPanel.Controls.Add(this.lbl_Rueckseite);
            this.InhaltPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InhaltPanel.Location = new System.Drawing.Point(0, 48);
            this.InhaltPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InhaltPanel.Name = "InhaltPanel";
            this.InhaltPanel.Size = new System.Drawing.Size(1050, 561);
            this.InhaltPanel.TabIndex = 7;
            // 
            // fackeAntwort3
            // 
            this.fackeAntwort3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fackeAntwort3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fackeAntwort3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fackeAntwort3.Location = new System.Drawing.Point(705, 374);
            this.fackeAntwort3.Name = "fackeAntwort3";
            this.fackeAntwort3.Size = new System.Drawing.Size(322, 81);
            this.fackeAntwort3.TabIndex = 13;
            this.fackeAntwort3.Text = "";
            this.fackeAntwort3.Enter += new System.EventHandler(this.fackeAntwort3_Enter);
            this.fackeAntwort3.Leave += new System.EventHandler(this.fackeAntwort3_Leave);
            // 
            // fackeAntwort2
            // 
            this.fackeAntwort2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fackeAntwort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fackeAntwort2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fackeAntwort2.Location = new System.Drawing.Point(705, 280);
            this.fackeAntwort2.Name = "fackeAntwort2";
            this.fackeAntwort2.Size = new System.Drawing.Size(322, 81);
            this.fackeAntwort2.TabIndex = 12;
            this.fackeAntwort2.Text = "";
            this.fackeAntwort2.Enter += new System.EventHandler(this.fackeAntwort2_Enter);
            this.fackeAntwort2.Leave += new System.EventHandler(this.fackeAntwort2_Leave);
            // 
            // fackeAntwort1
            // 
            this.fackeAntwort1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fackeAntwort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fackeAntwort1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fackeAntwort1.Location = new System.Drawing.Point(705, 187);
            this.fackeAntwort1.Name = "fackeAntwort1";
            this.fackeAntwort1.Size = new System.Drawing.Size(322, 81);
            this.fackeAntwort1.TabIndex = 11;
            this.fackeAntwort1.Text = "";
            this.fackeAntwort1.Enter += new System.EventHandler(this.fackeAntwort1_Enter);
            this.fackeAntwort1.Leave += new System.EventHandler(this.fackeAntwort1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Falsche Antworten";
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
            this.dachPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dachPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dachPanel.Location = new System.Drawing.Point(0, 0);
            this.dachPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dachPanel.Name = "dachPanel";
            this.dachPanel.Size = new System.Drawing.Size(1050, 49);
            this.dachPanel.TabIndex = 8;
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
            this.StapelBearbeitenButton.TabIndex = 11;
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
            this.ChallengeButton.Text = "Challenge Modus";
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
            // HinzufuegenKarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 609);
            this.Controls.Add(this.dachPanel);
            this.Controls.Add(this.InhaltPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HinzufuegenKarten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Karten Verwalten";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InhaltPanel.ResumeLayout(false);
            this.InhaltPanel.PerformLayout();
            this.dachPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt_Vorderseite;
        private System.Windows.Forms.RichTextBox richTxt_Rueckseite;
        private System.Windows.Forms.Label lbl_Vorderseite;
        private System.Windows.Forms.Label lbl_Rueckseite;
        private System.Windows.Forms.Button btn_Hinzufuegen;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListView listView_KartenAnzeige;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel InhaltPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_KartenSuche;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button JetztLernenButton;
        private System.Windows.Forms.Button KarteBearbeitenButton;
        private System.Windows.Forms.Button ÜbersichtButton;
        private System.Windows.Forms.Button StapelBearbeitenButton;
        private System.Windows.Forms.RichTextBox fackeAntwort3;
        private System.Windows.Forms.RichTextBox fackeAntwort2;
        private System.Windows.Forms.RichTextBox fackeAntwort1;
        private System.Windows.Forms.Label label1;
    }
}