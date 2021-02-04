namespace AnsichtsFenster.Fenster
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
            this.pnl_hinzufuegen = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnl_hinzufuegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_eingabe
            // 
            this.txt_eingabe.Location = new System.Drawing.Point(46, 83);
            this.txt_eingabe.Name = "txt_eingabe";
            this.txt_eingabe.Size = new System.Drawing.Size(309, 20);
            this.txt_eingabe.TabIndex = 0;
            // 
            // lbl_Eingabe
            // 
            this.lbl_Eingabe.AutoSize = true;
            this.lbl_Eingabe.Location = new System.Drawing.Point(107, 49);
            this.lbl_Eingabe.Name = "lbl_Eingabe";
            this.lbl_Eingabe.Size = new System.Drawing.Size(187, 13);
            this.lbl_Eingabe.TabIndex = 1;
            this.lbl_Eingabe.Text = "Gib den Namen des neuen Stapels an";
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(163, 132);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_Speichern.TabIndex = 2;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(btn_Speichern_Click);
            // 
            // pnl_hinzufuegen
            // 
            this.pnl_hinzufuegen.Controls.Add(this.btn_Speichern);
            this.pnl_hinzufuegen.Controls.Add(this.txt_eingabe);
            this.pnl_hinzufuegen.Controls.Add(this.lbl_Eingabe);
            this.pnl_hinzufuegen.Location = new System.Drawing.Point(215, 83);
            this.pnl_hinzufuegen.Name = "pnl_hinzufuegen";
            this.pnl_hinzufuegen.Size = new System.Drawing.Size(396, 203);
            this.pnl_hinzufuegen.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // HinzufuegenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_hinzufuegen);
            this.Name = "HinzufuegenView";
            this.Text = "Hinzufügen";
            this.pnl_hinzufuegen.ResumeLayout(false);
            this.pnl_hinzufuegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_eingabe;
        private System.Windows.Forms.Label lbl_Eingabe;
        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Panel pnl_hinzufuegen;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}