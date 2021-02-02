
namespace WindowsFormsApp1.Fenster
{
    partial class HinzufuegenView
    {
        //// <summary>
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
            this.txt_eingabe = new System.Windows.Forms.TextBox();
            this.lbl_Eingabe = new System.Windows.Forms.Label();
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_eingabe
            // 
            this.txt_eingabe.Location = new System.Drawing.Point(45, 79);
            this.txt_eingabe.Name = "txt_eingabe";
            this.txt_eingabe.Size = new System.Drawing.Size(309, 20);
            this.txt_eingabe.TabIndex = 0;
            // 
            // lbl_Eingabe
            // 
            this.lbl_Eingabe.AutoSize = true;
            this.lbl_Eingabe.Location = new System.Drawing.Point(141, 47);
            this.lbl_Eingabe.Name = "lbl_Eingabe";
            this.lbl_Eingabe.Size = new System.Drawing.Size(99, 13);
            this.lbl_Eingabe.TabIndex = 1;
            this.lbl_Eingabe.Text = "Gib dein Scheiß ein";
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(153, 128);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_Speichern.TabIndex = 2;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Speichern);
            this.panel1.Controls.Add(this.txt_eingabe);
            this.panel1.Controls.Add(this.lbl_Eingabe);
            this.panel1.Location = new System.Drawing.Point(199, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 203);
            this.panel1.TabIndex = 3;
            // 
            // HinzufügenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "HinzufügenView";
            this.Text = "Hinzufügen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_eingabe;
        private System.Windows.Forms.Label lbl_Eingabe;
        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Panel panel1;
    }
}