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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btn_Hinzufuegen.Location = new System.Drawing.Point(206, 219);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_Hinzufuegen.TabIndex = 4;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_Hinzufuegen.Click += new System.EventHandler(this.btn_Hinzufuegen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Hinzufuegen);
            this.panel1.Controls.Add(this.lbl_Rueckseite);
            this.panel1.Controls.Add(this.lbl_Vorderseite);
            this.panel1.Controls.Add(this.richTxt_Rueckseite);
            this.panel1.Controls.Add(this.richTxt_Vorderseite);
            this.panel1.Location = new System.Drawing.Point(147, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 284);
            this.panel1.TabIndex = 5;
            // 
            // HinzufuegenKarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "HinzufuegenKarten";
            this.Text = "HinzufuegenKarten";
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
        private System.Windows.Forms.Panel panel1;
    }
}