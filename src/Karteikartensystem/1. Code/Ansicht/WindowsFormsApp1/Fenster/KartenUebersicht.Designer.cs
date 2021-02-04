
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
            this.panel1.SuspendLayout();
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
            this.listView_KartenAnzeige.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(ListViewColumnClick);
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
            // KartenUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.panel1);
            this.Name = "KartenUebersicht";
            this.Text = "KartenUebersicht";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_StapelName;
        private System.Windows.Forms.ListView listView_KartenAnzeige;
        private System.Windows.Forms.TextBox txt_KartenSuche;
        private System.Windows.Forms.Button btn_home;


    }
}