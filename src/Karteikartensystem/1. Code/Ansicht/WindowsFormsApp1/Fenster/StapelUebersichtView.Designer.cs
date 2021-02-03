
using System;

namespace WindowsFormsApp1
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
            this.txt_StapelSuche = new System.Windows.Forms.TextBox();
            this.listView_Ausgabe = new System.Windows.Forms.ListView();
            this.lbl_SuchInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Hinzufuegen = new System.Windows.Forms.Button();
            this.btn_Statisken = new System.Windows.Forms.Button();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_StapelSuche
            // 
            this.txt_StapelSuche.Location = new System.Drawing.Point(17, 72);
            this.txt_StapelSuche.Name = "txt_StapelSuche";
            this.txt_StapelSuche.Size = new System.Drawing.Size(306, 20);
            this.txt_StapelSuche.TabIndex = 0;
            this.txt_StapelSuche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_StapelSuche_KeyDown);
            // 
            // listView_Ausgabe
            // 
            this.listView_Ausgabe.HideSelection = false;
            this.listView_Ausgabe.Location = new System.Drawing.Point(17, 115);
            this.listView_Ausgabe.Name = "listView_Ausgabe";
            this.listView_Ausgabe.Size = new System.Drawing.Size(306, 292);
            this.listView_Ausgabe.TabIndex = 1;
            this.listView_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listView_Ausgabe.Click += new System.EventHandler(this.listView_Ausgabe_Click);
            this.listView_Ausgabe.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(ListViewColumnClick);
            // 
            // lbl_SuchInfo
            // 
            this.lbl_SuchInfo.AutoSize = true;
            this.lbl_SuchInfo.Location = new System.Drawing.Point(14, 38);
            this.lbl_SuchInfo.Name = "lbl_SuchInfo";
            this.lbl_SuchInfo.Size = new System.Drawing.Size(162, 13);
            this.lbl_SuchInfo.TabIndex = 2;
            this.lbl_SuchInfo.Text = "Stabelsuche mit Enter bestätigen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_Ausgabe);
            this.panel1.Controls.Add(this.lbl_SuchInfo);
            this.panel1.Controls.Add(this.txt_StapelSuche);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 426);
            this.panel1.TabIndex = 3;
            // 
            // btn_Hinzufuegen
            // 
            this.btn_Hinzufuegen.Location = new System.Drawing.Point(18, 72);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new System.Drawing.Size(184, 38);
            this.btn_Hinzufuegen.TabIndex = 4;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_Hinzufuegen.Click += new System.EventHandler(this.btn_Hinzufuegen_Click);
            // 
            // btn_Statisken
            // 
            this.btn_Statisken.Location = new System.Drawing.Point(18, 15);
            this.btn_Statisken.Name = "btn_Statisken";
            this.btn_Statisken.Size = new System.Drawing.Size(184, 36);
            this.btn_Statisken.TabIndex = 5;
            this.btn_Statisken.Text = "Statistiken";
            this.btn_Statisken.UseVisualStyleBackColor = true;
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_Statisken);
            this.pnl_btn.Controls.Add(this.btn_Hinzufuegen);
            this.pnl_btn.Location = new System.Drawing.Point(452, 309);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(226, 128);
            this.pnl_btn.TabIndex = 6;
            // 
            // StapelUebersichtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_btn);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btn_Hinzufuegen;
        private System.Windows.Forms.Button btn_Statisken;
        private System.Windows.Forms.Panel pnl_btn;
    }
}

