
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
            this.imgLampe = new System.Windows.Forms.PictureBox();
            this.dachPanel = new System.Windows.Forms.Panel();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLampe)).BeginInit();
            this.dachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLampe
            // 
            this.listBoxLampe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLampe.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLampe.FormattingEnabled = true;
            this.listBoxLampe.ItemHeight = 28;
            this.listBoxLampe.Location = new System.Drawing.Point(589, 187);
            this.listBoxLampe.Name = "listBoxLampe";
            this.listBoxLampe.Size = new System.Drawing.Size(358, 392);
            this.listBoxLampe.TabIndex = 3;
            this.listBoxLampe.Click += new System.EventHandler(this.StapelBoxClick);
            // 
            // lblJetztLernen
            // 
            this.lblJetztLernen.AutoSize = true;
            this.lblJetztLernen.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJetztLernen.Location = new System.Drawing.Point(583, 114);
            this.lblJetztLernen.Name = "lblJetztLernen";
            this.lblJetztLernen.Size = new System.Drawing.Size(316, 31);
            this.lblJetztLernen.TabIndex = 4;
            this.lblJetztLernen.Text = "Wähle ein Stapelund leg los";
            // 
            // imgLampe
            // 
            this.imgLampe.Image = global::AnsichtsFenster.Properties.Resources.study__3_;
            this.imgLampe.Location = new System.Drawing.Point(12, 114);
            this.imgLampe.Name = "imgLampe";
            this.imgLampe.Size = new System.Drawing.Size(524, 465);
            this.imgLampe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLampe.TabIndex = 1;
            this.imgLampe.TabStop = false;
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
            this.dachPanel.TabIndex = 8;
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
            // JetztLernenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.dachPanel);
            this.Controls.Add(this.lblJetztLernen);
            this.Controls.Add(this.listBoxLampe);
            this.Controls.Add(this.imgLampe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JetztLernenView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JetztLernenView";
            ((System.ComponentModel.ISupportInitialize)(this.imgLampe)).EndInit();
            this.dachPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLampe;
        private System.Windows.Forms.ListBox listBoxLampe;
        private System.Windows.Forms.Label lblJetztLernen;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}