
namespace AnsichtsFenster.Fenster
{
    partial class ChallengeAbfrageView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxStapel = new System.Windows.Forms.ListBox();
            this.textBoxAnzahlKarten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZeit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnsichtsFenster.Properties.Resources.award;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxStapel
            // 
            this.listBoxStapel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStapel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStapel.FormattingEnabled = true;
            this.listBoxStapel.ItemHeight = 28;
            this.listBoxStapel.Location = new System.Drawing.Point(355, 31);
            this.listBoxStapel.Name = "listBoxStapel";
            this.listBoxStapel.Size = new System.Drawing.Size(284, 364);
            this.listBoxStapel.TabIndex = 4;
            // 
            // textBoxAnzahlKarten
            // 
            this.textBoxAnzahlKarten.Location = new System.Drawing.Point(659, 95);
            this.textBoxAnzahlKarten.Name = "textBoxAnzahlKarten";
            this.textBoxAnzahlKarten.Size = new System.Drawing.Size(227, 22);
            this.textBoxAnzahlKarten.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anzahl  der Karten";
            // 
            // textBoxZeit
            // 
            this.textBoxZeit.Location = new System.Drawing.Point(659, 177);
            this.textBoxZeit.Name = "textBoxZeit";
            this.textBoxZeit.Size = new System.Drawing.Size(227, 22);
            this.textBoxZeit.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(656, 146);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(32, 17);
            this.lblZeit.TabIndex = 9;
            this.lblZeit.Text = "Zeit";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(659, 252);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(209, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "jetzt starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ChallengeAbfrageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 550);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxZeit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnzahlKarten);
            this.Controls.Add(this.listBoxStapel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChallengeAbfrageView";
            this.Text = "ChallengeAbfrageView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxStapel;
        private System.Windows.Forms.TextBox textBoxAnzahlKarten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZeit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Button btnStart;
    }
}