
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
            this.components = new System.ComponentModel.Container();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.lbl_Frage = new System.Windows.Forms.Label();
            this.radioButtonAntwort1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAntwort4 = new System.Windows.Forms.RadioButton();
            this.pnl_FrageAntwort = new System.Windows.Forms.Panel();
            this.lbl_Auswertung = new System.Windows.Forms.Label();
            this.lbl_Zeit = new System.Windows.Forms.Label();
            this.timer_Anzeige = new System.Windows.Forms.Timer(this.components);
            this.dachPanel = new System.Windows.Forms.Panel();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.MinimierenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_FrageAntwort.SuspendLayout();
            this.dachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(455, 250);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(100, 28);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Nächste";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finish.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.Location = new System.Drawing.Point(380, 479);
            this.btn_finish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(218, 40);
            this.btn_finish.TabIndex = 5;
            this.btn_finish.Text = "Abgeben";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // lbl_Frage
            // 
            this.lbl_Frage.AutoSize = true;
            this.lbl_Frage.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Frage.Location = new System.Drawing.Point(12, 7);
            this.lbl_Frage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Frage.Name = "lbl_Frage";
            this.lbl_Frage.Size = new System.Drawing.Size(91, 40);
            this.lbl_Frage.TabIndex = 2;
            this.lbl_Frage.Text = "Frage";
            // 
            // radioButtonAntwort1
            // 
            this.radioButtonAntwort1.AutoSize = true;
            this.radioButtonAntwort1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAntwort1.Location = new System.Drawing.Point(16, 74);
            this.radioButtonAntwort1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAntwort1.Name = "radioButtonAntwort1";
            this.radioButtonAntwort1.Size = new System.Drawing.Size(110, 29);
            this.radioButtonAntwort1.TabIndex = 6;
            this.radioButtonAntwort1.TabStop = true;
            this.radioButtonAntwort1.Text = "Antwort1";
            this.radioButtonAntwort1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort2
            // 
            this.radioButtonAntwort2.AutoSize = true;
            this.radioButtonAntwort2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAntwort2.Location = new System.Drawing.Point(16, 103);
            this.radioButtonAntwort2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAntwort2.Name = "radioButtonAntwort2";
            this.radioButtonAntwort2.Size = new System.Drawing.Size(110, 29);
            this.radioButtonAntwort2.TabIndex = 7;
            this.radioButtonAntwort2.TabStop = true;
            this.radioButtonAntwort2.Text = "Antwort2";
            this.radioButtonAntwort2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort3
            // 
            this.radioButtonAntwort3.AutoSize = true;
            this.radioButtonAntwort3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAntwort3.Location = new System.Drawing.Point(16, 133);
            this.radioButtonAntwort3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAntwort3.Name = "radioButtonAntwort3";
            this.radioButtonAntwort3.Size = new System.Drawing.Size(110, 29);
            this.radioButtonAntwort3.TabIndex = 8;
            this.radioButtonAntwort3.TabStop = true;
            this.radioButtonAntwort3.Text = "Antwort3";
            this.radioButtonAntwort3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntwort4
            // 
            this.radioButtonAntwort4.AutoSize = true;
            this.radioButtonAntwort4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAntwort4.Location = new System.Drawing.Point(16, 162);
            this.radioButtonAntwort4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAntwort4.Name = "radioButtonAntwort4";
            this.radioButtonAntwort4.Size = new System.Drawing.Size(110, 29);
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
            this.pnl_FrageAntwort.Location = new System.Drawing.Point(207, 101);
            this.pnl_FrageAntwort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_FrageAntwort.Name = "pnl_FrageAntwort";
            this.pnl_FrageAntwort.Size = new System.Drawing.Size(616, 294);
            this.pnl_FrageAntwort.TabIndex = 14;
            // 
            // lbl_Auswertung
            // 
            this.lbl_Auswertung.AutoSize = true;
            this.lbl_Auswertung.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Auswertung.Location = new System.Drawing.Point(52, 101);
            this.lbl_Auswertung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Auswertung.Name = "lbl_Auswertung";
            this.lbl_Auswertung.Size = new System.Drawing.Size(116, 28);
            this.lbl_Auswertung.TabIndex = 15;
            this.lbl_Auswertung.Text = "Auswertung";
            // 
            // lbl_Zeit
            // 
            this.lbl_Zeit.AutoSize = true;
            this.lbl_Zeit.Location = new System.Drawing.Point(888, 46);
            this.lbl_Zeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Zeit.Name = "lbl_Zeit";
            this.lbl_Zeit.Size = new System.Drawing.Size(32, 17);
            this.lbl_Zeit.TabIndex = 16;
            this.lbl_Zeit.Text = "Zeit";
            // 
            // timer_Anzeige
            // 
            this.timer_Anzeige.Interval = 1000;
            this.timer_Anzeige.Tick += new System.EventHandler(this.timer_Anzeige_Tick);
            // 
            // dachPanel
            // 
            this.dachPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.dachPanel.Controls.Add(this.ChallengeButton);
            this.dachPanel.Controls.Add(this.MinimierenButton);
            this.dachPanel.Controls.Add(this.CloseButton);
            this.dachPanel.Controls.Add(this.button3);
            this.dachPanel.Controls.Add(this.button2);
            this.dachPanel.Controls.Add(this.button1);
            this.dachPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dachPanel.Location = new System.Drawing.Point(0, 0);
            this.dachPanel.Name = "dachPanel";
            this.dachPanel.Size = new System.Drawing.Size(1067, 55);
            this.dachPanel.TabIndex = 17;
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.ChallengeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChallengeButton.FlatAppearance.BorderSize = 0;
            this.ChallengeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.ChallengeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.ChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChallengeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.ChallengeButton.Location = new System.Drawing.Point(547, 7);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(150, 40);
            this.ChallengeButton.TabIndex = 9;
            this.ChallengeButton.Text = "Challenge";
            this.ChallengeButton.UseVisualStyleBackColor = false;
            // 
            // MinimierenButton
            // 
            this.MinimierenButton.FlatAppearance.BorderSize = 0;
            this.MinimierenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.MinimierenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.MinimierenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimierenButton.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimierenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.MinimierenButton.Location = new System.Drawing.Point(1135, 0);
            this.MinimierenButton.Name = "MinimierenButton";
            this.MinimierenButton.Size = new System.Drawing.Size(35, 31);
            this.MinimierenButton.TabIndex = 8;
            this.MinimierenButton.Text = "__";
            this.MinimierenButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.CloseButton.Location = new System.Drawing.Point(1164, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 31);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button3.Location = new System.Drawing.Point(380, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Jetzt lernen";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button2.Location = new System.Drawing.Point(159, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Karte bearbeiten";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(29, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Übersicht";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ChallengeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dachPanel);
            this.Controls.Add(this.lbl_Zeit);
            this.Controls.Add(this.lbl_Auswertung);
            this.Controls.Add(this.pnl_FrageAntwort);
            this.Controls.Add(this.btn_finish);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChallengeView";
            this.Text = "ChallengeView";
            this.pnl_FrageAntwort.ResumeLayout(false);
            this.pnl_FrageAntwort.PerformLayout();
            this.dachPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label lbl_Frage;
        private System.Windows.Forms.RadioButton radioButtonAntwort1;
        private System.Windows.Forms.RadioButton radioButtonAntwort2;
        private System.Windows.Forms.RadioButton radioButtonAntwort3;
        private System.Windows.Forms.RadioButton radioButtonAntwort4;
        private System.Windows.Forms.Panel pnl_FrageAntwort;
        private System.Windows.Forms.Label lbl_Auswertung;
        private System.Windows.Forms.Label lbl_Zeit;
        private System.Windows.Forms.Timer timer_Anzeige;
        private System.Windows.Forms.Panel dachPanel;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button MinimierenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}