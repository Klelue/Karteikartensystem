
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_StapelName = new System.Windows.Forms.Label();
            this.listView_KartenAnzeige = new System.Windows.Forms.ListView();
            this.txt_KartenSuche = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.richTxt_Antwort = new System.Windows.Forms.RichTextBox();
            this.pnl_Antwort = new System.Windows.Forms.Panel();
            this.lbl_Frage = new System.Windows.Forms.Label();
            this.btn_Antwort = new System.Windows.Forms.Button();
            this.lbl_Anwort = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_Antwort.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_StapelName);
            this.panel1.Controls.Add(this.listView_KartenAnzeige);
            this.panel1.Controls.Add(this.txt_KartenSuche);
            this.panel1.Location = new System.Drawing.Point(91, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 332);
            this.panel1.TabIndex = 0;
            // 
            // lbl_StapelName
            // 
            this.lbl_StapelName.AutoSize = true;
            this.lbl_StapelName.Location = new System.Drawing.Point(26, 23);
            this.lbl_StapelName.Name = "lbl_StapelName";
            this.lbl_StapelName.Size = new System.Drawing.Size(65, 13);
            this.lbl_StapelName.TabIndex = 2;
            this.lbl_StapelName.Text = "StapelName";
            // 
            // listView_KartenAnzeige
            // 
            this.listView_KartenAnzeige.HideSelection = false;
            this.listView_KartenAnzeige.Location = new System.Drawing.Point(29, 113);
            this.listView_KartenAnzeige.Name = "listView_KartenAnzeige";
            this.listView_KartenAnzeige.Size = new System.Drawing.Size(138, 190);
            this.listView_KartenAnzeige.TabIndex = 1;
            this.listView_KartenAnzeige.UseCompatibleStateImageBehavior = false;
            this.listView_KartenAnzeige.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.listView_KartenAnzeige.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_KartenAnzeige_MouseClick);
            // 
            // txt_KartenSuche
            // 
            this.txt_KartenSuche.Location = new System.Drawing.Point(29, 57);
            this.txt_KartenSuche.Name = "txt_KartenSuche";
            this.txt_KartenSuche.Size = new System.Drawing.Size(138, 20);
            this.txt_KartenSuche.TabIndex = 0;
            this.txt_KartenSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KartenSuche_KeyDown);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(341, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(184, 23);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Zurück zur Stapelübersicht";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // richTxt_Antwort
            // 
            this.richTxt_Antwort.Location = new System.Drawing.Point(37, 64);
            this.richTxt_Antwort.Name = "richTxt_Antwort";
            this.richTxt_Antwort.Size = new System.Drawing.Size(297, 189);
            this.richTxt_Antwort.TabIndex = 4;
            this.richTxt_Antwort.Text = "";
            // 
            // pnl_Antwort
            // 
            this.pnl_Antwort.Controls.Add(this.btn_Random);
            this.pnl_Antwort.Controls.Add(this.btn_Next);
            this.pnl_Antwort.Controls.Add(this.lbl_Anwort);
            this.pnl_Antwort.Controls.Add(this.btn_Antwort);
            this.pnl_Antwort.Controls.Add(this.lbl_Frage);
            this.pnl_Antwort.Controls.Add(this.richTxt_Antwort);
            this.pnl_Antwort.Location = new System.Drawing.Point(347, 80);
            this.pnl_Antwort.Name = "pnl_Antwort";
            this.pnl_Antwort.Size = new System.Drawing.Size(413, 311);
            this.pnl_Antwort.TabIndex = 5;
            // 
            // lbl_Frage
            // 
            this.lbl_Frage.AutoSize = true;
            this.lbl_Frage.Location = new System.Drawing.Point(34, 14);
            this.lbl_Frage.Name = "lbl_Frage";
            this.lbl_Frage.Size = new System.Drawing.Size(40, 13);
            this.lbl_Frage.TabIndex = 5;
            this.lbl_Frage.Text = "Frage: ";
            // 
            // btn_Antwort
            // 
            this.btn_Antwort.Location = new System.Drawing.Point(37, 259);
            this.btn_Antwort.Name = "btn_Antwort";
            this.btn_Antwort.Size = new System.Drawing.Size(113, 23);
            this.btn_Antwort.TabIndex = 6;
            this.btn_Antwort.Text = "Antwort anzeigen";
            this.btn_Antwort.UseVisualStyleBackColor = true;
            this.btn_Antwort.Click += new System.EventHandler(this.btn_Antwort_Click);
            // 
            // lbl_Anwort
            // 
            this.lbl_Anwort.AutoSize = true;
            this.lbl_Anwort.Location = new System.Drawing.Point(37, 45);
            this.lbl_Anwort.Name = "lbl_Anwort";
            this.lbl_Anwort.Size = new System.Drawing.Size(46, 13);
            this.lbl_Anwort.TabIndex = 7;
            this.lbl_Anwort.Text = "Antwort:";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(156, 260);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 8;
            this.btn_Next.Text = "Nächste";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(238, 259);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(96, 23);
            this.btn_Random.TabIndex = 9;
            this.btn_Random.Text = "Zufällig";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // KartenUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Antwort);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.panel1);
            this.Name = "KartenUebersicht";
            this.Text = "KartenUebersicht";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Antwort.ResumeLayout(false);
            this.pnl_Antwort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_StapelName;
        private System.Windows.Forms.ListView listView_KartenAnzeige;
        private System.Windows.Forms.TextBox txt_KartenSuche;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.RichTextBox richTxt_Antwort;
        private System.Windows.Forms.Panel pnl_Antwort;
        private System.Windows.Forms.Label lbl_Frage;
        private System.Windows.Forms.Label lbl_Anwort;
        private System.Windows.Forms.Button btn_Antwort;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_Next;
    }
}