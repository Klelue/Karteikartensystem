
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
            this.lblZeit = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnsichtsFenster.Properties.Resources.award;

            this.pictureBox1.Location = new System.Drawing.Point(9, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxStapel
            // 
            this.listBoxStapel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStapel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStapel.FormattingEnabled = true;

            this.listBoxStapel.ItemHeight = 19;
            this.listBoxStapel.Location = new System.Drawing.Point(252, 24);
            this.listBoxStapel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.listBoxStapel.Name = "listBoxStapel";
            this.listBoxStapel.Size = new System.Drawing.Size(224, 342);
            this.listBoxStapel.TabIndex = 4;
            this.listBoxStapel.Click += new System.EventHandler(this.listBoxStapel_Click);
            // 
            // textBoxAnzahlKarten
            // 
            this.textBoxAnzahlKarten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnzahlKarten.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.textBoxAnzahlKarten.Location = new System.Drawing.Point(494, 77);
            this.textBoxAnzahlKarten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAnzahlKarten.Name = "textBoxAnzahlKarten";
            this.textBoxAnzahlKarten.Size = new System.Drawing.Size(213, 19);

            this.textBoxAnzahlKarten.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(492, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anzahl  der Karten";
            // 
            // textBoxZeit
            // 
            this.textBoxZeit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZeit.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.textBoxZeit.Location = new System.Drawing.Point(494, 144);
            this.textBoxZeit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxZeit.Name = "textBoxZeit";
            this.textBoxZeit.Size = new System.Drawing.Size(213, 19);

            this.textBoxZeit.TabIndex = 7;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;

            this.lblZeit.Location = new System.Drawing.Point(660, 131);

            this.lblZeit.Location = new System.Drawing.Point(492, 119);
            this.lblZeit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(25, 13);
            this.lblZeit.TabIndex = 9;
            this.lblZeit.Text = "Zeit";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnStart.Location = new System.Drawing.Point(514, 206);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 39);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "jetzt starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.listBoxStapel);
            this.panel1.Controls.Add(this.lblZeit);
            this.panel1.Controls.Add(this.textBoxAnzahlKarten);
            this.panel1.Controls.Add(this.textBoxZeit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 503);
            this.panel1.TabIndex = 11;
            // 
            // ChallengeAbfrageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(764, 441);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.textBoxZeit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnzahlKarten);
            this.Controls.Add(this.listBoxStapel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.Name = "ChallengeAbfrageView";
            this.Text = "ChallengeAbfrageView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxStapel;
        private System.Windows.Forms.TextBox textBoxAnzahlKarten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZeit;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
    }
}