
namespace AnsichtsFenster.Fenster
{
    partial class StapelUebersichtView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.components = new global::System.ComponentModel.Container();
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(StapelUebersichtView));
            this.txt_StapelSuche = new global::System.Windows.Forms.TextBox();
            this.listView_Ausgabe = new global::System.Windows.Forms.ListView();
            this.lbl_SuchInfo = new global::System.Windows.Forms.Label();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.btn_Hinzufuegen = new global::System.Windows.Forms.Button();
            this.btn_Statisken = new global::System.Windows.Forms.Button();
            this.pnl_btn = new global::System.Windows.Forms.Panel();
            this.bindingNavigator1 = new global::System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new global::System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new global::System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new global::System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new global::System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new global::System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new global::System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new global::System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new global::System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new global::System.Windows.Forms.ToolStripButton();
            this.btn_Entfernen = new global::System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_StapelSuche
            // 
            this.txt_StapelSuche.Location = new global::System.Drawing.Point(17, 72);
            this.txt_StapelSuche.Name = "txt_StapelSuche";
            this.txt_StapelSuche.Size = new global::System.Drawing.Size(306, 20);
            this.txt_StapelSuche.TabIndex = 0;
            this.txt_StapelSuche.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txt_StapelSuche_KeyDown);
            // 
            // listView_Ausgabe
            // 
            this.listView_Ausgabe.HideSelection = false;
            this.listView_Ausgabe.Location = new global::System.Drawing.Point(17, 115);
            this.listView_Ausgabe.Name = "listView_Ausgabe";
            this.listView_Ausgabe.Size = new global::System.Drawing.Size(306, 292);
            this.listView_Ausgabe.TabIndex = 1;
            this.listView_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listView_Ausgabe.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.listView_Ausgabe.Click += new global::System.EventHandler(this.listView_Ausgabe_Click);
            // 
            // lbl_SuchInfo
            // 
            this.lbl_SuchInfo.AutoSize = true;
            this.lbl_SuchInfo.Location = new global::System.Drawing.Point(14, 38);
            this.lbl_SuchInfo.Name = "lbl_SuchInfo";
            this.lbl_SuchInfo.Size = new global::System.Drawing.Size(162, 13);
            this.lbl_SuchInfo.TabIndex = 2;
            this.lbl_SuchInfo.Text = "Stabelsuche mit Enter bestätigen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_Ausgabe);
            this.panel1.Controls.Add(this.lbl_SuchInfo);
            this.panel1.Controls.Add(this.txt_StapelSuche);
            this.panel1.Location = new global::System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(346, 426);
            this.panel1.TabIndex = 3;
            // 
            // btn_Hinzufuegen
            // 
            this.btn_Hinzufuegen.Location = new global::System.Drawing.Point(4, 72);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new global::System.Drawing.Size(184, 38);
            this.btn_Hinzufuegen.TabIndex = 4;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_Hinzufuegen.Click += new global::System.EventHandler(this.btn_Hinzufuegen_Click);
            // 
            // btn_Statisken
            // 
            this.btn_Statisken.Location = new global::System.Drawing.Point(4, 15);
            this.btn_Statisken.Name = "btn_Statisken";
            this.btn_Statisken.Size = new global::System.Drawing.Size(184, 36);
            this.btn_Statisken.TabIndex = 5;
            this.btn_Statisken.Text = "Statistiken";
            this.btn_Statisken.UseVisualStyleBackColor = true;
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_Entfernen);
            this.pnl_btn.Controls.Add(this.bindingNavigator1);
            this.pnl_btn.Controls.Add(this.btn_Statisken);
            this.pnl_btn.Controls.Add(this.btn_Hinzufuegen);
            this.pnl_btn.Location = new global::System.Drawing.Point(452, 235);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new global::System.Drawing.Size(226, 202);
            this.pnl_btn.TabIndex = 6;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new global::System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new global::System.Drawing.Size(226, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((global::System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new global::System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((global::System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new global::System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new global::System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new global::System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new global::System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new global::System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new global::System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((global::System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new global::System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((global::System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new global::System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new global::System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((global::System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new global::System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((global::System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new global::System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // btn_Entfernen
            // 
            this.btn_Entfernen.Location = new global::System.Drawing.Point(4, 131);
            this.btn_Entfernen.Name = "btn_Entfernen";
            this.btn_Entfernen.Size = new global::System.Drawing.Size(184, 38);
            this.btn_Entfernen.TabIndex = 7;
            this.btn_Entfernen.Text = "Entfernen";
            this.btn_Entfernen.UseVisualStyleBackColor = true;
            this.btn_Entfernen.Click += new global::System.EventHandler(this.btn_Entfernen_Click);
            // 
            // StapelUebersichtView
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_btn);
            this.Controls.Add(this.panel1);
            this.Name = "StapelUebersichtView";
            this.Text = "Stapel Übersicht";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_btn.ResumeLayout(false);
            this.pnl_btn.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.TextBox txt_StapelSuche;
        private global::System.Windows.Forms.ListView listView_Ausgabe;
        private global::System.Windows.Forms.Label lbl_SuchInfo;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Button btn_Hinzufuegen;
        private global::System.Windows.Forms.Button btn_Statisken;
        private global::System.Windows.Forms.Panel pnl_btn;
        private global::System.Windows.Forms.Button btn_Entfernen;
        private global::System.Windows.Forms.BindingNavigator bindingNavigator1;
        private global::System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private global::System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private global::System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private global::System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private global::System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private global::System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private global::System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private global::System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private global::System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private global::System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private global::System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

