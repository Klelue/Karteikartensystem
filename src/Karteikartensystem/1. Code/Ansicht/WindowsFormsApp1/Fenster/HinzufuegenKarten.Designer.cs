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
            this.richTxt_Vorderseite = new System.Windows.Forms.RichTextBox();
            this.richTxt_Rueckseite = new System.Windows.Forms.RichTextBox();
            this.lbl_Vorderseite = new System.Windows.Forms.Label();
            this.lbl_Rueckseite = new System.Windows.Forms.Label();
            this.btn_Hinzufuegen = new System.Windows.Forms.Button();
            this.pnl_KartenVerwalten = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_StapelName = new System.Windows.Forms.Label();
            this.listView_KartenAnzeige = new System.Windows.Forms.ListView();
            this.txt_KartenSuche = new System.Windows.Forms.TextBox();
            this.pnl_KartenVerwalten.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxt_Vorderseite
            // 
            this.richTxt_Vorderseite.Location = new System.Drawing.Point(56, 50);
            this.richTxt_Vorderseite.Name = "richTxt_Vorderseite";
            this.richTxt_Vorderseite.Size = new System.Drawing.Size(152, 141);
            this.richTxt_Vorderseite.TabIndex = 0;
            this.richTxt_Vorderseite.Text = "";
            // 
            // richTxt_Rueckseite
            // 
            this.richTxt_Rueckseite.Location = new System.Drawing.Point(307, 50);
            this.richTxt_Rueckseite.Name = "richTxt_Rueckseite";
            this.richTxt_Rueckseite.Size = new System.Drawing.Size(153, 141);
            this.richTxt_Rueckseite.TabIndex = 1;
            this.richTxt_Rueckseite.Text = "";
            // 
            // lbl_Vorderseite
            // 
            this.lbl_Vorderseite.AutoSize = true;
            this.lbl_Vorderseite.Location = new System.Drawing.Point(67, 15);
            this.lbl_Vorderseite.Name = "lbl_Vorderseite";
            this.lbl_Vorderseite.Size = new System.Drawing.Size(103, 13);
            this.lbl_Vorderseite.TabIndex = 2;
            this.lbl_Vorderseite.Text = "Voderseite der Karte";
            // 
            // lbl_Rueckseite
            // 
            this.lbl_Rueckseite.AutoSize = true;
            this.lbl_Rueckseite.Location = new System.Drawing.Point(329, 15);
            this.lbl_Rueckseite.Name = "lbl_Rueckseite";
            this.lbl_Rueckseite.Size = new System.Drawing.Size(101, 13);
            this.lbl_Rueckseite.TabIndex = 3;
            this.lbl_Rueckseite.Text = "Rückseite der Karte";
            // 
            // btn_Hinzufuegen
            // 
            this.btn_Hinzufuegen.Location = new System.Drawing.Point(218, 219);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_Hinzufuegen.TabIndex = 4;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_Hinzufuegen.Click += new System.EventHandler(this.btn_Hinzufuegen_Click);
            // 
            // pnl_KartenVerwalten
            // 
            this.pnl_KartenVerwalten.Controls.Add(this.btn_Save);
            this.pnl_KartenVerwalten.Controls.Add(this.btn_Delete);
            this.pnl_KartenVerwalten.Controls.Add(this.btn_Hinzufuegen);
            this.pnl_KartenVerwalten.Controls.Add(this.lbl_Rueckseite);
            this.pnl_KartenVerwalten.Controls.Add(this.lbl_Vorderseite);
            this.pnl_KartenVerwalten.Controls.Add(this.richTxt_Rueckseite);
            this.pnl_KartenVerwalten.Controls.Add(this.richTxt_Vorderseite);
            this.pnl_KartenVerwalten.Location = new System.Drawing.Point(267, 81);
            this.pnl_KartenVerwalten.Name = "pnl_KartenVerwalten";
            this.pnl_KartenVerwalten.Size = new System.Drawing.Size(499, 284);
            this.pnl_KartenVerwalten.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(384, 218);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Editieren";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(56, 219);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Löschen";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_StapelName);
            this.panel1.Controls.Add(this.listView_KartenAnzeige);
            this.panel1.Controls.Add(this.txt_KartenSuche);
            this.panel1.Location = new System.Drawing.Point(33, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 332);
            this.panel1.TabIndex = 6;
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
            this.listView_KartenAnzeige.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_KartenAnzeige_ColumnClick);
            this.listView_KartenAnzeige.Click += new System.EventHandler(this.listView_KartenAnzeige_Click);
            // 
            // txt_KartenSuche
            // 
            this.txt_KartenSuche.Location = new System.Drawing.Point(29, 57);
            this.txt_KartenSuche.Name = "txt_KartenSuche";
            this.txt_KartenSuche.Size = new System.Drawing.Size(138, 20);
            this.txt_KartenSuche.TabIndex = 0;
            this.txt_KartenSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KartenSuche_KeyDown);
            // 
            // HinzufuegenKarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_KartenVerwalten);
            this.Name = "HinzufuegenKarten";
            this.Text = "Karten Verwalten";
            this.pnl_KartenVerwalten.ResumeLayout(false);
            this.pnl_KartenVerwalten.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt_Vorderseite;
        private System.Windows.Forms.RichTextBox richTxt_Rueckseite;
        private System.Windows.Forms.Label lbl_Vorderseite;
        private System.Windows.Forms.Label lbl_Rueckseite;
        private System.Windows.Forms.Button btn_Hinzufuegen;
        private System.Windows.Forms.Panel pnl_KartenVerwalten;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_StapelName;
        private System.Windows.Forms.ListView listView_KartenAnzeige;
        private System.Windows.Forms.TextBox txt_KartenSuche;
    }
}