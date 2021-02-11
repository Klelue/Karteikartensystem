
namespace AnsichtsFenster.Fenster
{
    partial class JetztLernenView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JetztLernenView));
            this.listBoxLampe = new System.Windows.Forms.ListBox();
            this.lblJetztLernen = new System.Windows.Forms.Label();
            this.dachPanel = new System.Windows.Forms.Panel();
            this.StapelBearbeitenButton = new System.Windows.Forms.Button();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.JetztLernenButton = new System.Windows.Forms.Button();
            this.KarteBearbeitenButton = new System.Windows.Forms.Button();
            this.ÜbersichtButton = new System.Windows.Forms.Button();
            this.InhaltPanel = new System.Windows.Forms.Panel();
            this.imgLampe = new System.Windows.Forms.PictureBox();
            this.dachPanel.SuspendLayout();
            this.InhaltPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLampe)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLampe
            // 
            this.listBoxLampe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLampe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxLampe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLampe.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBoxLampe.FormattingEnabled = true;
            this.listBoxLampe.HorizontalScrollbar = true;
            this.listBoxLampe.ItemHeight = 29;
            this.listBoxLampe.Location = new System.Drawing.Point(758, 109);
            this.listBoxLampe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLampe.Name = "listBoxLampe";
            this.listBoxLampe.Size = new System.Drawing.Size(410, 493);
            this.listBoxLampe.TabIndex = 3;
            this.listBoxLampe.Click += new System.EventHandler(this.StapelBoxClick);
            // 
            // lblJetztLernen
            // 
            this.lblJetztLernen.AutoSize = true;
            this.lblJetztLernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJetztLernen.Location = new System.Drawing.Point(753, 64);
            this.lblJetztLernen.Name = "lblJetztLernen";
            this.lblJetztLernen.Size = new System.Drawing.Size(156, 29);
            this.lblJetztLernen.TabIndex = 4;
            this.lblJetztLernen.Text = "Wähle Stapel";
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
            this.dachPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dachPanel.Name = "dachPanel";
            this.dachPanel.Size = new System.Drawing.Size(1400, 60);
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
            this.StapelBearbeitenButton.Location = new System.Drawing.Point(469, 7);
            this.StapelBearbeitenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StapelBearbeitenButton.Name = "StapelBearbeitenButton";
            this.StapelBearbeitenButton.Size = new System.Drawing.Size(251, 46);
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
            this.ChallengeButton.Location = new System.Drawing.Point(960, 7);
            this.ChallengeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(253, 46);
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
            this.MinimierenButton.Location = new System.Drawing.Point(1325, 0);
            this.MinimierenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimierenButton.Name = "MinimierenButton";
            this.MinimierenButton.Size = new System.Drawing.Size(45, 34);
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
            this.CloseButton.Location = new System.Drawing.Point(1365, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 34);
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
            this.JetztLernenButton.Location = new System.Drawing.Point(740, 7);
            this.JetztLernenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JetztLernenButton.Name = "JetztLernenButton";
            this.JetztLernenButton.Size = new System.Drawing.Size(200, 46);
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
            this.KarteBearbeitenButton.Location = new System.Drawing.Point(211, 7);
            this.KarteBearbeitenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KarteBearbeitenButton.Name = "KarteBearbeitenButton";
            this.KarteBearbeitenButton.Size = new System.Drawing.Size(251, 46);
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
            this.ÜbersichtButton.Location = new System.Drawing.Point(35, 7);
            this.ÜbersichtButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ÜbersichtButton.Name = "ÜbersichtButton";
            this.ÜbersichtButton.Size = new System.Drawing.Size(149, 46);
            this.ÜbersichtButton.TabIndex = 1;
            this.ÜbersichtButton.Text = "Übersicht";
            this.ÜbersichtButton.UseVisualStyleBackColor = false;
            this.ÜbersichtButton.Click += new System.EventHandler(this.ÜbersichtButton_Click);
            // 
            // InhaltPanel
            // 
            this.InhaltPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InhaltPanel.Controls.Add(this.imgLampe);
            this.InhaltPanel.Controls.Add(this.listBoxLampe);
            this.InhaltPanel.Controls.Add(this.lblJetztLernen);
            this.InhaltPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InhaltPanel.Location = new System.Drawing.Point(0, 60);
            this.InhaltPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InhaltPanel.Name = "InhaltPanel";
            this.InhaltPanel.Size = new System.Drawing.Size(1400, 690);
            this.InhaltPanel.TabIndex = 9;
            // 
            // imgLampe
            // 
            this.imgLampe.Image = global::AnsichtsFenster.Properties.Resources.study__3_;
            this.imgLampe.Location = new System.Drawing.Point(159, 79);
            this.imgLampe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgLampe.Name = "imgLampe";
            this.imgLampe.Size = new System.Drawing.Size(409, 456);
            this.imgLampe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLampe.TabIndex = 1;
            this.imgLampe.TabStop = false;
            // 
            // JetztLernenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.InhaltPanel);
            this.Controls.Add(this.dachPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JetztLernenView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JetztLernenView";
            this.dachPanel.ResumeLayout(false);
            this.InhaltPanel.ResumeLayout(false);
            this.InhaltPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLampe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLampe;
        private System.Windows.Forms.ListBox listBoxLampe;
        private System.Windows.Forms.Label lblJetztLernen;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button JetztLernenButton;
        private System.Windows.Forms.Button KarteBearbeitenButton;
        private System.Windows.Forms.Button ÜbersichtButton;
        private System.Windows.Forms.Panel InhaltPanel;
        private System.Windows.Forms.Button StapelBearbeitenButton;
    }
}