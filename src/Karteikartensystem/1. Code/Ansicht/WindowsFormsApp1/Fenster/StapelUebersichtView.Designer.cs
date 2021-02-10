
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
            this.StapelBearbeitenButton = new System.Windows.Forms.Button();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.JetztLernenButton = new System.Windows.Forms.Button();
            this.KarteBearbeitenButton = new System.Windows.Forms.Button();
            this.ÜbersichtButton = new System.Windows.Forms.Button();
            this.txt_StapelSuche = new System.Windows.Forms.TextBox();
            this.listView_Ausgabe = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InhaltPanel = new System.Windows.Forms.Panel();
            this.dachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InhaltPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.dachPanel.TabIndex = 7;
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
            // txt_StapelSuche
            // 
            this.txt_StapelSuche.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StapelSuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_StapelSuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StapelSuche.Location = new System.Drawing.Point(112, 37);
            this.txt_StapelSuche.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txt_StapelSuche.Name = "txt_StapelSuche";
            this.txt_StapelSuche.Size = new System.Drawing.Size(768, 21);
            this.txt_StapelSuche.TabIndex = 4;
            this.txt_StapelSuche.Enter += new System.EventHandler(this.txt_StapelSuche_Enter);
            this.txt_StapelSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_StapelSuche_KeyDown);
            this.txt_StapelSuche.Leave += new System.EventHandler(this.txt_StapelSuche_Leave);
            // 
            // listView_Ausgabe
            // 
            this.listView_Ausgabe.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Ausgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Ausgabe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_Ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Ausgabe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listView_Ausgabe.GridLines = true;
            this.listView_Ausgabe.HideSelection = false;
            this.listView_Ausgabe.Location = new System.Drawing.Point(112, 106);
            this.listView_Ausgabe.Name = "listView_Ausgabe";
            this.listView_Ausgabe.Size = new System.Drawing.Size(825, 406);
            this.listView_Ausgabe.TabIndex = 1;
            this.listView_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listView_Ausgabe.View = System.Windows.Forms.View.Details;
            this.listView_Ausgabe.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.listView_Ausgabe.DoubleClick += new System.EventHandler(this.listView_Ausgabe_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(914, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InhaltPanel
            // 
            this.InhaltPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InhaltPanel.Controls.Add(this.pictureBox1);
            this.InhaltPanel.Controls.Add(this.listView_Ausgabe);
            this.InhaltPanel.Controls.Add(this.txt_StapelSuche);
            this.InhaltPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InhaltPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InhaltPanel.Location = new System.Drawing.Point(0, 48);
            this.InhaltPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InhaltPanel.Name = "InhaltPanel";
            this.InhaltPanel.Size = new System.Drawing.Size(1050, 561);
            this.InhaltPanel.TabIndex = 3;
            // 
            // StapelUebersichtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 609);
            this.Controls.Add(this.InhaltPanel);
            this.Controls.Add(this.dachPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StapelUebersichtView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stapel Übersicht";
            this.dachPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InhaltPanel.ResumeLayout(false);
            this.InhaltPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button JetztLernenButton;
        private System.Windows.Forms.Button KarteBearbeitenButton;
        private System.Windows.Forms.Button ÜbersichtButton;
        private System.Windows.Forms.TextBox txt_StapelSuche;
        private System.Windows.Forms.ListView listView_Ausgabe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel InhaltPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button StapelBearbeitenButton;
    }
}

