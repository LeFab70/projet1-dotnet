namespace Projet1
{
    partial class VenteParAnneeForm
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
            System.Windows.Forms.Label valeurLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenteParAnneeForm));
            this.northwindDataSet = new Projet1.NorthwindDataSet();
            this.dataTableVentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableVentesTableAdapter = new Projet1.NorthwindDataSetTableAdapters.DataTableVentesTableAdapter();
            this.dataTableVentesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.obtenirVentesTotalToolStrip = new System.Windows.Forms.ToolStrip();
            this.paysToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paysToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dDDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dDDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dDFToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dDFToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.obtenirVentesTotalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.valeurTextBox = new System.Windows.Forms.TextBox();
            valeurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVentesBindingNavigator)).BeginInit();
            this.dataTableVentesBindingNavigator.SuspendLayout();
            this.obtenirVentesTotalToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // valeurLabel
            // 
            valeurLabel.AutoSize = true;
            valeurLabel.Location = new System.Drawing.Point(31, 161);
            valeurLabel.Name = "valeurLabel";
            valeurLabel.Size = new System.Drawing.Size(80, 25);
            valeurLabel.TabIndex = 2;
            valeurLabel.Text = "Valeur:";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableVentesBindingSource
            // 
            this.dataTableVentesBindingSource.DataMember = "DataTableVentes";
            this.dataTableVentesBindingSource.DataSource = this.northwindDataSet;
            // 
            // dataTableVentesTableAdapter
            // 
            this.dataTableVentesTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableVentesBindingNavigator
            // 
            this.dataTableVentesBindingNavigator.AddNewItem = null;
            this.dataTableVentesBindingNavigator.BindingSource = this.dataTableVentesBindingSource;
            this.dataTableVentesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTableVentesBindingNavigator.DeleteItem = null;
            this.dataTableVentesBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.dataTableVentesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.dataTableVentesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTableVentesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTableVentesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTableVentesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTableVentesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTableVentesBindingNavigator.Name = "dataTableVentesBindingNavigator";
            this.dataTableVentesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTableVentesBindingNavigator.Size = new System.Drawing.Size(1038, 50);
            this.dataTableVentesBindingNavigator.TabIndex = 0;
            this.dataTableVentesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // obtenirVentesTotalToolStrip
            // 
            this.obtenirVentesTotalToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.obtenirVentesTotalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paysToolStripLabel,
            this.paysToolStripTextBox,
            this.dDDToolStripLabel,
            this.dDDToolStripTextBox,
            this.dDFToolStripLabel,
            this.dDFToolStripTextBox,
            this.obtenirVentesTotalToolStripButton});
            this.obtenirVentesTotalToolStrip.Location = new System.Drawing.Point(0, 50);
            this.obtenirVentesTotalToolStrip.Name = "obtenirVentesTotalToolStrip";
            this.obtenirVentesTotalToolStrip.Size = new System.Drawing.Size(1038, 50);
            this.obtenirVentesTotalToolStrip.TabIndex = 1;
            this.obtenirVentesTotalToolStrip.Text = "obtenirVentesTotalToolStrip";
            // 
            // paysToolStripLabel
            // 
            this.paysToolStripLabel.Name = "paysToolStripLabel";
            this.paysToolStripLabel.Size = new System.Drawing.Size(65, 44);
            this.paysToolStripLabel.Text = "Pays:";
            // 
            // paysToolStripTextBox
            // 
            this.paysToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paysToolStripTextBox.Name = "paysToolStripTextBox";
            this.paysToolStripTextBox.Size = new System.Drawing.Size(100, 50);
            // 
            // dDDToolStripLabel
            // 
            this.dDDToolStripLabel.Name = "dDDToolStripLabel";
            this.dDDToolStripLabel.Size = new System.Drawing.Size(173, 44);
            this.dDDToolStripLabel.Text = "Date de debut:";
            // 
            // dDDToolStripTextBox
            // 
            this.dDDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dDDToolStripTextBox.Name = "dDDToolStripTextBox";
            this.dDDToolStripTextBox.Size = new System.Drawing.Size(100, 50);
            // 
            // dDFToolStripLabel
            // 
            this.dDFToolStripLabel.Name = "dDFToolStripLabel";
            this.dDFToolStripLabel.Size = new System.Drawing.Size(138, 44);
            this.dDFToolStripLabel.Text = "Date de fin:";
            // 
            // dDFToolStripTextBox
            // 
            this.dDFToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dDFToolStripTextBox.Name = "dDFToolStripTextBox";
            this.dDFToolStripTextBox.Size = new System.Drawing.Size(100, 50);
            // 
            // obtenirVentesTotalToolStripButton
            // 
            this.obtenirVentesTotalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.obtenirVentesTotalToolStripButton.Name = "obtenirVentesTotalToolStripButton";
            this.obtenirVentesTotalToolStripButton.Size = new System.Drawing.Size(196, 44);
            this.obtenirVentesTotalToolStripButton.Text = "Obtenir la valeur";
            this.obtenirVentesTotalToolStripButton.Click += new System.EventHandler(this.obtenirVentesTotalToolStripButton_Click);
            // 
            // valeurTextBox
            // 
            this.valeurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableVentesBindingSource, "Valeur", true));
            this.valeurTextBox.Location = new System.Drawing.Point(129, 158);
            this.valeurTextBox.Name = "valeurTextBox";
            this.valeurTextBox.Size = new System.Drawing.Size(243, 31);
            this.valeurTextBox.TabIndex = 3;
            // 
            // VenteParAnneeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 494);
            this.Controls.Add(valeurLabel);
            this.Controls.Add(this.valeurTextBox);
            this.Controls.Add(this.obtenirVentesTotalToolStrip);
            this.Controls.Add(this.dataTableVentesBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "VenteParAnneeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente par année";
            this.Load += new System.EventHandler(this.VenteParAnneeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVentesBindingNavigator)).EndInit();
            this.dataTableVentesBindingNavigator.ResumeLayout(false);
            this.dataTableVentesBindingNavigator.PerformLayout();
            this.obtenirVentesTotalToolStrip.ResumeLayout(false);
            this.obtenirVentesTotalToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource dataTableVentesBindingSource;
        private NorthwindDataSetTableAdapters.DataTableVentesTableAdapter dataTableVentesTableAdapter;
        private System.Windows.Forms.BindingNavigator dataTableVentesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip obtenirVentesTotalToolStrip;
        private System.Windows.Forms.ToolStripLabel paysToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paysToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dDDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dDDToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dDFToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dDFToolStripTextBox;
        private System.Windows.Forms.ToolStripButton obtenirVentesTotalToolStripButton;
        private System.Windows.Forms.TextBox valeurTextBox;
    }
}