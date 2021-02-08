
namespace AnsichtsFenster.Fenster
{
    partial class ChallengeView
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
            this.lbl_ZeitAngabe = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.lbl_Frage = new System.Windows.Forms.Label();
            this.radioButtonAntwort1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort4 = new System.Windows.Forms.RadioButton();
            this.pnl_FrageAntwort = new System.Windows.Forms.Panel();
            this.lbl_Auswertung = new System.Windows.Forms.Label();
            this.pnl_FrageAntwort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ZeitAngabe
            // 
            this.lbl_ZeitAngabe.AutoSize = true;
            this.lbl_ZeitAngabe.Location = new System.Drawing.Point(623, 49);
            this.lbl_ZeitAngabe.Name = "lbl_ZeitAngabe";
            this.lbl_ZeitAngabe.Size = new System.Drawing.Size(62, 13);
            this.lbl_ZeitAngabe.TabIndex = 0;
            this.lbl_ZeitAngabe.Text = "ZeitAngabe";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(341, 203);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Nächste";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(626, 385);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(75, 23);
            this.btn_finish.TabIndex = 5;
            this.btn_finish.Text = "Abgeben";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // lbl_Frage
            // 
            this.lbl_Frage.AutoSize = true;
            this.lbl_Frage.Location = new System.Drawing.Point(9, 6);
            this.lbl_Frage.Name = "lbl_Frage";
            this.lbl_Frage.Size = new System.Drawing.Size(34, 13);
            this.lbl_Frage.TabIndex = 2;
            this.lbl_Frage.Text = "Frage";
            // 
            // radioButtonAntwort1
            // 
            this.radioButtonAntwort1.AutoSize = true;
            this.radioButtonAntwort1.Location = new System.Drawing.Point(12, 60);
            this.radioButtonAntwort1.Name = "radioButtonAntwort1";
            this.radioButtonAntwort1.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAntwort1.TabIndex = 6;
            this.radioButtonAntwort1.TabStop = true;
            this.radioButtonAntwort1.Text = "Antwort1";
            this.radioButtonAntwort1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort2
            // 
            this.radioButtonAntwort2.AutoSize = true;
            this.radioButtonAntwort2.Location = new System.Drawing.Point(12, 84);
            this.radioButtonAntwort2.Name = "radioButtonAntwort2";
            this.radioButtonAntwort2.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAntwort2.TabIndex = 7;
            this.radioButtonAntwort2.TabStop = true;
            this.radioButtonAntwort2.Text = "Antwort2";
            this.radioButtonAntwort2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort3
            // 
            this.radioButtonAntwort3.AutoSize = true;
            this.radioButtonAntwort3.Location = new System.Drawing.Point(12, 108);
            this.radioButtonAntwort3.Name = "radioButtonAntwort3";
            this.radioButtonAntwort3.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAntwort3.TabIndex = 8;
            this.radioButtonAntwort3.TabStop = true;
            this.radioButtonAntwort3.Text = "Antwort3";
            this.radioButtonAntwort3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort4
            // 
            this.radioButtonAntwort4.AutoSize = true;
            this.radioButtonAntwort4.Location = new System.Drawing.Point(12, 132);
            this.radioButtonAntwort4.Name = "radioButtonAntwort4";
            this.radioButtonAntwort4.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAntwort4.TabIndex = 9;
            this.radioButtonAntwort4.TabStop = true;
            this.radioButtonAntwort4.Text = "Antwort4";
            this.radioButtonAntwort4.UseVisualStyleBackColor = true;
            // 
            // pnl_FrageAntwort
            // 
            this.pnl_FrageAntwort.Controls.Add(this.radioButtonAntwort4);
            this.pnl_FrageAntwort.Controls.Add(this.radioButtonAntwort3);
            this.pnl_FrageAntwort.Controls.Add(this.btn_Next);
            this.pnl_FrageAntwort.Controls.Add(this.radioButtonAntwort2);
            this.pnl_FrageAntwort.Controls.Add(this.radioButtonAntwort1);
            this.pnl_FrageAntwort.Controls.Add(this.lbl_Frage);
            this.pnl_FrageAntwort.Location = new System.Drawing.Point(188, 73);
            this.pnl_FrageAntwort.Name = "pnl_FrageAntwort";
            this.pnl_FrageAntwort.Size = new System.Drawing.Size(462, 239);
            this.pnl_FrageAntwort.TabIndex = 14;
            // 
            // lbl_Auswertung
            // 
            this.lbl_Auswertung.AutoSize = true;
            this.lbl_Auswertung.Location = new System.Drawing.Point(129, 123);
            this.lbl_Auswertung.Name = "lbl_Auswertung";
            this.lbl_Auswertung.Size = new System.Drawing.Size(63, 13);
            this.lbl_Auswertung.TabIndex = 15;
            this.lbl_Auswertung.Text = "Auswertung";
            // 
            // ChallengeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Auswertung);
            this.Controls.Add(this.pnl_FrageAntwort);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.lbl_ZeitAngabe);
            this.Name = "ChallengeView";
            this.Text = "ChallengeView";
            this.pnl_FrageAntwort.ResumeLayout(false);
            this.pnl_FrageAntwort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ZeitAngabe;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label lbl_Frage;
        private System.Windows.Forms.RadioButton radioButtonAntwort1;
        private System.Windows.Forms.RadioButton radioButtonAntwort2;
        private System.Windows.Forms.RadioButton radioButtonAntwort3;
        private System.Windows.Forms.RadioButton radioButtonAntwort4;
        private System.Windows.Forms.Panel pnl_FrageAntwort;
        private System.Windows.Forms.Label lbl_Auswertung;
    }
}