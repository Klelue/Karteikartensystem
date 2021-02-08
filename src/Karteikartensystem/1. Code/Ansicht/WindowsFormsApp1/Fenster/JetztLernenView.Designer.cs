
namespace AnsichtsFenster.Fenster
{
    partial class JetztLernenView
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
            this.listBoxLampe = new System.Windows.Forms.ListBox();
            this.lblJetztLernen = new System.Windows.Forms.Label();
            this.imgLampe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLampe)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLampe
            // 
            this.listBoxLampe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLampe.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLampe.FormattingEnabled = true;
            this.listBoxLampe.ItemHeight = 28;
            this.listBoxLampe.Location = new System.Drawing.Point(589, 92);
            this.listBoxLampe.Name = "listBoxLampe";
            this.listBoxLampe.Size = new System.Drawing.Size(358, 336);
            this.listBoxLampe.TabIndex = 3;
            this.listBoxLampe.Click += new System.EventHandler(this.StapelBoxClick);
            // 
            // lblJetztLernen
            // 
            this.lblJetztLernen.AutoSize = true;
            this.lblJetztLernen.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJetztLernen.Location = new System.Drawing.Point(583, 30);
            this.lblJetztLernen.Name = "lblJetztLernen";
            this.lblJetztLernen.Size = new System.Drawing.Size(316, 31);
            this.lblJetztLernen.TabIndex = 4;
            this.lblJetztLernen.Text = "Wähle ein Stapelund leg los";
            // 
            // imgLampe
            // 
            this.imgLampe.Image = global::AnsichtsFenster.Properties.Resources.study__3_;
            this.imgLampe.Location = new System.Drawing.Point(21, 12);
            this.imgLampe.Name = "imgLampe";
            this.imgLampe.Size = new System.Drawing.Size(524, 465);
            this.imgLampe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLampe.TabIndex = 1;
            this.imgLampe.TabStop = false;
            // 
            // JetztLernenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(977, 489);
            this.Controls.Add(this.lblJetztLernen);
            this.Controls.Add(this.listBoxLampe);
            this.Controls.Add(this.imgLampe);
            this.Name = "JetztLernenView";
            this.Text = "JetztLernenView";
            ((System.ComponentModel.ISupportInitialize)(this.imgLampe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLampe;
        private System.Windows.Forms.ListBox listBoxLampe;
        private System.Windows.Forms.Label lblJetztLernen;
    }
}