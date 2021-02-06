
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
            this.btn_home = new System.Windows.Forms.Button();
            this.richTxt_Antwort = new System.Windows.Forms.RichTextBox();
            this.pnl_Antwort = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_Anwort = new System.Windows.Forms.Label();
            this.btn_Antwort = new System.Windows.Forms.Button();
            this.lbl_Frage = new System.Windows.Forms.Label();
            this.lbl_StapelName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_Antwort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(286, 13);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(245, 28);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Zurück zur Stapelübersicht";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // richTxt_Antwort
            // 
            this.richTxt_Antwort.Location = new System.Drawing.Point(37, 44);
            this.richTxt_Antwort.Margin = new System.Windows.Forms.Padding(4);
            this.richTxt_Antwort.Name = "richTxt_Antwort";
            this.richTxt_Antwort.Size = new System.Drawing.Size(612, 232);
            this.richTxt_Antwort.TabIndex = 4;
            this.richTxt_Antwort.Text = "";
            // 
            // pnl_Antwort
            // 
            this.pnl_Antwort.Controls.Add(this.button2);
            this.pnl_Antwort.Controls.Add(this.button1);
            this.pnl_Antwort.Controls.Add(this.btn_Random);
            this.pnl_Antwort.Controls.Add(this.btn_Next);
            this.pnl_Antwort.Controls.Add(this.lbl_Anwort);
            this.pnl_Antwort.Controls.Add(this.richTxt_Antwort);
            this.pnl_Antwort.Location = new System.Drawing.Point(161, 119);
            this.pnl_Antwort.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Antwort.Name = "pnl_Antwort";
            this.pnl_Antwort.Size = new System.Drawing.Size(722, 379);
            this.pnl_Antwort.TabIndex = 5;
            this.pnl_Antwort.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Einfach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Einfach);
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(172, 296);
            this.btn_Random.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(128, 28);
            this.btn_Random.TabIndex = 9;
            this.btn_Random.Text = "Gut";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Gut_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(37, 296);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(100, 28);
            this.btn_Next.TabIndex = 8;
            this.btn_Next.Text = "Nochmal";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Nochmal);
            // 
            // lbl_Anwort
            // 
            this.lbl_Anwort.AutoSize = true;
            this.lbl_Anwort.Location = new System.Drawing.Point(94, 23);
            this.lbl_Anwort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Anwort.Name = "lbl_Anwort";
            this.lbl_Anwort.Size = new System.Drawing.Size(59, 17);
            this.lbl_Anwort.TabIndex = 7;
            this.lbl_Anwort.Text = "Antwort:";
            // 
            // btn_Antwort
            // 
            this.btn_Antwort.Location = new System.Drawing.Point(443, 513);
            this.btn_Antwort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Antwort.Name = "btn_Antwort";
            this.btn_Antwort.Size = new System.Drawing.Size(151, 28);
            this.btn_Antwort.TabIndex = 6;
            this.btn_Antwort.Text = "Antwort anzeigen";
            this.btn_Antwort.UseVisualStyleBackColor = true;
            this.btn_Antwort.Click += new System.EventHandler(this.btn_Antwort_Click);
            // 
            // lbl_Frage
            // 
            this.lbl_Frage.AutoSize = true;
            this.lbl_Frage.Location = new System.Drawing.Point(464, 87);
            this.lbl_Frage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Frage.Name = "lbl_Frage";
            this.lbl_Frage.Size = new System.Drawing.Size(53, 17);
            this.lbl_Frage.TabIndex = 5;
            this.lbl_Frage.Text = "Frage: ";
            // 
            // lbl_StapelName
            // 
            this.lbl_StapelName.AutoSize = true;
            this.lbl_StapelName.Location = new System.Drawing.Point(158, 50);
            this.lbl_StapelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StapelName.Name = "lbl_StapelName";
            this.lbl_StapelName.Size = new System.Drawing.Size(85, 17);
            this.lbl_StapelName.TabIndex = 2;
            this.lbl_StapelName.Text = "StapelName";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Nicht nochmal anzeigen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_nichtNochmal);
            // 
            // KartenUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_StapelName);
            this.Controls.Add(this.pnl_Antwort);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_Antwort);
            this.Controls.Add(this.lbl_Frage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KartenUebersicht";
            this.Text = "b";
            this.pnl_Antwort.ResumeLayout(false);
            this.pnl_Antwort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.RichTextBox richTxt_Antwort;
        private System.Windows.Forms.Panel pnl_Antwort;
        private System.Windows.Forms.Label lbl_Frage;
        private System.Windows.Forms.Label lbl_Anwort;
        private System.Windows.Forms.Button btn_Antwort;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_StapelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}