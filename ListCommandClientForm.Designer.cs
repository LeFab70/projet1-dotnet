namespace Projet1
{
    partial class ListCommandClientForm
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
            System.Windows.Forms.Label productNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCommandClientForm));
            this.custOrdersOrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.custOrdersOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Projet1.NorthwindDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.getCustomerOrderDetailsToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.getCustomerOrderDetailsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.custOrdersOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOrderDetailAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getOrderDetailAdapterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custOrdersOrdersTableAdapter = new Projet1.NorthwindDataSetTableAdapters.CustOrdersOrdersTableAdapter();
            this.tableAdapterManager = new Projet1.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.getOrderDetailAdapterTableAdapter = new Projet1.NorthwindDataSetTableAdapters.GetOrderDetailAdapterTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Projet1.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.productNameLabelLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersOrdersBindingNavigator)).BeginInit();
            this.custOrdersOrdersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.getCustomerOrderDetailsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersOrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailAdapterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(24, 963);
            productNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(164, 25);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "Nom du produit:";
            // 
            // custOrdersOrdersBindingNavigator
            // 
            this.custOrdersOrdersBindingNavigator.AddNewItem = null;
            this.custOrdersOrdersBindingNavigator.BindingSource = this.custOrdersOrdersBindingSource;
            this.custOrdersOrdersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.custOrdersOrdersBindingNavigator.DeleteItem = null;
            this.custOrdersOrdersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.custOrdersOrdersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.custOrdersOrdersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.custOrdersOrdersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.custOrdersOrdersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.custOrdersOrdersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.custOrdersOrdersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.custOrdersOrdersBindingNavigator.Name = "custOrdersOrdersBindingNavigator";
            this.custOrdersOrdersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.custOrdersOrdersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.custOrdersOrdersBindingNavigator.Size = new System.Drawing.Size(1198, 42);
            this.custOrdersOrdersBindingNavigator.TabIndex = 0;
            this.custOrdersOrdersBindingNavigator.Text = "bindingNavigator1";
            // 
            // custOrdersOrdersBindingSource
            // 
            this.custOrdersOrdersBindingSource.DataMember = "CustOrdersOrders";
            this.custOrdersOrdersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 39);
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
            // getCustomerOrderDetailsToolStrip
            // 
            this.getCustomerOrderDetailsToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.getCustomerOrderDetailsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.getCustomerOrderDetailsToolStripButton});
            this.getCustomerOrderDetailsToolStrip.Location = new System.Drawing.Point(0, 42);
            this.getCustomerOrderDetailsToolStrip.Name = "getCustomerOrderDetailsToolStrip";
            this.getCustomerOrderDetailsToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.getCustomerOrderDetailsToolStrip.Size = new System.Drawing.Size(1198, 42);
            this.getCustomerOrderDetailsToolStrip.TabIndex = 1;
            this.getCustomerOrderDetailsToolStrip.Text = "getCustomerOrderDetailsToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(167, 44);
            this.customerIDToolStripLabel.Text = "Numéro client";
            // 
            // customerIDToolStripTextBox
            // 
            this.customerIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
            this.customerIDToolStripTextBox.Size = new System.Drawing.Size(196, 50);
            // 
            // getCustomerOrderDetailsToolStripButton
            // 
            this.getCustomerOrderDetailsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getCustomerOrderDetailsToolStripButton.Name = "getCustomerOrderDetailsToolStripButton";
            this.getCustomerOrderDetailsToolStripButton.Size = new System.Drawing.Size(174, 44);
            this.getCustomerOrderDetailsToolStripButton.Text = "Obtenir la liste";
            this.getCustomerOrderDetailsToolStripButton.Click += new System.EventHandler(this.getCustomerOrderDetailsToolStripButton_Click);
            // 
            // custOrdersOrdersDataGridView
            // 
            this.custOrdersOrdersDataGridView.AllowUserToAddRows = false;
            this.custOrdersOrdersDataGridView.AllowUserToDeleteRows = false;
            this.custOrdersOrdersDataGridView.AutoGenerateColumns = false;
            this.custOrdersOrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custOrdersOrdersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.custOrdersOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custOrdersOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.custOrdersOrdersDataGridView.DataSource = this.custOrdersOrdersBindingSource;
            this.custOrdersOrdersDataGridView.Location = new System.Drawing.Point(15, 125);
            this.custOrdersOrdersDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custOrdersOrdersDataGridView.Name = "custOrdersOrdersDataGridView";
            this.custOrdersOrdersDataGridView.ReadOnly = true;
            this.custOrdersOrdersDataGridView.RowHeadersWidth = 82;
            this.custOrdersOrdersDataGridView.Size = new System.Drawing.Size(1146, 423);
            this.custOrdersOrdersDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro commande";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date commade";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RequiredDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date requise";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ShippedDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date livraison";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // getOrderDetailAdapterBindingSource
            // 
            this.getOrderDetailAdapterBindingSource.DataMember = "fk_CustOrdersOrders_GetOrderDetailAdapter";
            this.getOrderDetailAdapterBindingSource.DataSource = this.custOrdersOrdersBindingSource;
            // 
            // getOrderDetailAdapterDataGridView
            // 
            this.getOrderDetailAdapterDataGridView.AllowUserToAddRows = false;
            this.getOrderDetailAdapterDataGridView.AllowUserToDeleteRows = false;
            this.getOrderDetailAdapterDataGridView.AutoGenerateColumns = false;
            this.getOrderDetailAdapterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getOrderDetailAdapterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.getOrderDetailAdapterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getOrderDetailAdapterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.getOrderDetailAdapterDataGridView.DataSource = this.getOrderDetailAdapterBindingSource;
            this.getOrderDetailAdapterDataGridView.Location = new System.Drawing.Point(24, 606);
            this.getOrderDetailAdapterDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.getOrderDetailAdapterDataGridView.Name = "getOrderDetailAdapterDataGridView";
            this.getOrderDetailAdapterDataGridView.ReadOnly = true;
            this.getOrderDetailAdapterDataGridView.RowHeadersWidth = 82;
            this.getOrderDetailAdapterDataGridView.Size = new System.Drawing.Size(1042, 323);
            this.getOrderDetailAdapterDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numéro produit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Numéro produit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prix unité";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prix unité";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quantité";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // custOrdersOrdersTableAdapter
            // 
            this.custOrdersOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Projet1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getOrderDetailAdapterTableAdapter
            // 
            this.getOrderDetailAdapterTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Fk_GetOrderDetailAdapter_Products";
            this.productsBindingSource.DataSource = this.getOrderDetailAdapterBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productNameLabelLabel
            // 
            this.productNameLabelLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productNameLabelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameLabelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameLabelLabel.Location = new System.Drawing.Point(190, 962);
            this.productNameLabelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productNameLabelLabel.Name = "productNameLabelLabel";
            this.productNameLabelLabel.Size = new System.Drawing.Size(750, 42);
            this.productNameLabelLabel.TabIndex = 5;
            // 
            // ListCommandClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 1065);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameLabelLabel);
            this.Controls.Add(this.getOrderDetailAdapterDataGridView);
            this.Controls.Add(this.custOrdersOrdersDataGridView);
            this.Controls.Add(this.getCustomerOrderDetailsToolStrip);
            this.Controls.Add(this.custOrdersOrdersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "ListCommandClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des commandes d\'un client spécifique";
            this.Load += new System.EventHandler(this.ListCommandClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersOrdersBindingNavigator)).EndInit();
            this.custOrdersOrdersBindingNavigator.ResumeLayout(false);
            this.custOrdersOrdersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.getCustomerOrderDetailsToolStrip.ResumeLayout(false);
            this.getCustomerOrderDetailsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersOrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailAdapterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource custOrdersOrdersBindingSource;
        private NorthwindDataSetTableAdapters.CustOrdersOrdersTableAdapter custOrdersOrdersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator custOrdersOrdersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip getCustomerOrderDetailsToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton getCustomerOrderDetailsToolStripButton;
        private System.Windows.Forms.DataGridView custOrdersOrdersDataGridView;
        private System.Windows.Forms.BindingSource getOrderDetailAdapterBindingSource;
        private NorthwindDataSetTableAdapters.GetOrderDetailAdapterTableAdapter getOrderDetailAdapterTableAdapter;
        private System.Windows.Forms.DataGridView getOrderDetailAdapterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label productNameLabelLabel;
    }
}