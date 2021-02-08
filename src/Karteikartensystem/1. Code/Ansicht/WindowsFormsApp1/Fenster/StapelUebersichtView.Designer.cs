
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
            this.txt_StapelSuche = new System.Windows.Forms.TextBox();
            this.listView_Ausgabe = new System.Windows.Forms.ListView();
            this.lbl_SuchInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_StapelHinzufuegen = new System.Windows.Forms.Button();
            this.btn_Statisken = new System.Windows.Forms.Button();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_KartenHinzufuegen = new System.Windows.Forms.Button();
            this.btn_Entfernen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_StapelSuche
            // 
            this.txt_StapelSuche.Location = new System.Drawing.Point(23, 89);
            this.txt_StapelSuche.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StapelSuche.Name = "txt_StapelSuche";
            this.txt_StapelSuche.Size = new System.Drawing.Size(407, 22);
            this.txt_StapelSuche.TabIndex = 0;
            this.txt_StapelSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_StapelSuche_KeyDown);
            // 
            // listView_Ausgabe
            // 
            this.listView_Ausgabe.HideSelection = false;
            this.listView_Ausgabe.Location = new System.Drawing.Point(23, 142);
            this.listView_Ausgabe.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Ausgabe.Name = "listView_Ausgabe";
            this.listView_Ausgabe.Size = new System.Drawing.Size(407, 358);
            this.listView_Ausgabe.TabIndex = 1;
            this.listView_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listView_Ausgabe.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.listView_Ausgabe.Click += new System.EventHandler(this.listView_Ausgabe_Click);
            this.listView_Ausgabe.DoubleClick += new System.EventHandler(this.listView_Ausgabe_DoubleClick);
            // 
            // lbl_SuchInfo
            // 
            this.lbl_SuchInfo.AutoSize = true;
            this.lbl_SuchInfo.Location = new System.Drawing.Point(19, 47);
            this.lbl_SuchInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SuchInfo.Name = "lbl_SuchInfo";
            this.lbl_SuchInfo.Size = new System.Drawing.Size(216, 17);
            this.lbl_SuchInfo.TabIndex = 2;
            this.lbl_SuchInfo.Text = "Stabelsuche mit Enter bestätigen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_Ausgabe);
            this.panel1.Controls.Add(this.lbl_SuchInfo);
            this.panel1.Controls.Add(this.txt_StapelSuche);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 524);
            this.panel1.TabIndex = 3;
            // 
            // btn_StapelHinzufuegen
            // 
            this.btn_StapelHinzufuegen.Location = new System.Drawing.Point(5, 164);
            this.btn_StapelHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StapelHinzufuegen.Name = "btn_StapelHinzufuegen";
            this.btn_StapelHinzufuegen.Size = new System.Drawing.Size(240, 43);
            this.btn_StapelHinzufuegen.TabIndex = 4;
            this.btn_StapelHinzufuegen.Text = "Stapel Hinzufügen";
            this.btn_StapelHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_StapelHinzufuegen.Click += new System.EventHandler(this.btn_StapelHinzufuegen_Click);
            // 
            // btn_Statisken
            // 
            this.btn_Statisken.Location = new System.Drawing.Point(5, 18);
            this.btn_Statisken.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Statisken.Name = "btn_Statisken";
            this.btn_Statisken.Size = new System.Drawing.Size(240, 43);
            this.btn_Statisken.TabIndex = 5;
            this.btn_Statisken.Text = "Statistiken";
            this.btn_Statisken.UseVisualStyleBackColor = true;
            this.btn_Statisken.Click += new System.EventHandler(this.JetztLernenEvent);
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_KartenHinzufuegen);
            this.pnl_btn.Controls.Add(this.btn_Entfernen);
            this.pnl_btn.Controls.Add(this.btn_StapelHinzufuegen);
            this.pnl_btn.Controls.Add(this.btn_Statisken);
            this.pnl_btn.Location = new System.Drawing.Point(735, 241);
            this.pnl_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(257, 298);
            this.pnl_btn.TabIndex = 6;
            // 
            // btn_KartenHinzufuegen
            // 
            this.btn_KartenHinzufuegen.Location = new System.Drawing.Point(5, 90);
            this.btn_KartenHinzufuegen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KartenHinzufuegen.Name = "btn_KartenHinzufuegen";
            this.btn_KartenHinzufuegen.Size = new System.Drawing.Size(240, 43);
            this.btn_KartenHinzufuegen.TabIndex = 8;
            this.btn_KartenHinzufuegen.Text = "Karten Editieren";
            this.btn_KartenHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_KartenHinzufuegen.Click += new System.EventHandler(this.btn_KartenHinzufuegen_Click);
            // 
            // btn_Entfernen
            // 
            this.btn_Entfernen.Location = new System.Drawing.Point(5, 231);
            this.btn_Entfernen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Entfernen.Name = "btn_Entfernen";
            this.btn_Entfernen.Size = new System.Drawing.Size(240, 43);
            this.btn_Entfernen.TabIndex = 7;
            this.btn_Entfernen.Text = "Stapel Entfernen";
            this.btn_Entfernen.UseVisualStyleBackColor = true;
            this.btn_Entfernen.Click += new System.EventHandler(this.btn_Entfernen_Click);
            // 
            // StapelUebersichtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnl_btn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StapelUebersichtView";
            this.Text = "Stapel Übersicht";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_StapelSuche;
        private System.Windows.Forms.ListView listView_Ausgabe;
        private System.Windows.Forms.Label lbl_SuchInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StapelHinzufuegen;
        private System.Windows.Forms.Button btn_Statisken;
        private System.Windows.Forms.Panel pnl_btn;
        private System.Windows.Forms.Button btn_Entfernen;
        private System.Windows.Forms.Button btn_KartenHinzufuegen;
    }
}

