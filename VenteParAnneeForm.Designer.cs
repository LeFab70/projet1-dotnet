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
            System.Windows.Forms.Label valeurLabel1;
            this.northwindDataSet = new Projet1.NorthwindDataSet();
            this.dataTableVentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableVentesTableAdapter = new Projet1.NorthwindDataSetTableAdapters.DataTableVentesTableAdapter();
            this.obtenirVentesTotalToolStrip = new System.Windows.Forms.ToolStrip();
            this.paysToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paysToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dDDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dDDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dDFToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dDFToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.obtenirVentesTotalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new Projet1.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.valeurLabelLabel = new System.Windows.Forms.Label();
            valeurLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVentesBindingSource)).BeginInit();
            this.obtenirVentesTotalToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.obtenirVentesTotalToolStrip.Location = new System.Drawing.Point(0, 0);
            this.obtenirVentesTotalToolStrip.Name = "obtenirVentesTotalToolStrip";
            this.obtenirVentesTotalToolStrip.Size = new System.Drawing.Size(1038, 42);
            this.obtenirVentesTotalToolStrip.TabIndex = 1;
            this.obtenirVentesTotalToolStrip.Text = "obtenirVentesTotalToolStrip";
            // 
            // paysToolStripLabel
            // 
            this.paysToolStripLabel.Name = "paysToolStripLabel";
            this.paysToolStripLabel.Size = new System.Drawing.Size(65, 36);
            this.paysToolStripLabel.Text = "Pays:";
            // 
            // paysToolStripTextBox
            // 
            this.paysToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paysToolStripTextBox.Name = "paysToolStripTextBox";
            this.paysToolStripTextBox.Size = new System.Drawing.Size(100, 42);
            // 
            // dDDToolStripLabel
            // 
            this.dDDToolStripLabel.Name = "dDDToolStripLabel";
            this.dDDToolStripLabel.Size = new System.Drawing.Size(173, 36);
            this.dDDToolStripLabel.Text = "Date de debut:";
            // 
            // dDDToolStripTextBox
            // 
            this.dDDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dDDToolStripTextBox.Name = "dDDToolStripTextBox";
            this.dDDToolStripTextBox.Size = new System.Drawing.Size(100, 42);
            // 
            // dDFToolStripLabel
            // 
            this.dDFToolStripLabel.Name = "dDFToolStripLabel";
            this.dDFToolStripLabel.Size = new System.Drawing.Size(138, 36);
            this.dDFToolStripLabel.Text = "Date de fin:";
            // 
            // dDFToolStripTextBox
            // 
            this.dDFToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dDFToolStripTextBox.Name = "dDFToolStripTextBox";
            this.dDFToolStripTextBox.Size = new System.Drawing.Size(100, 42);
            // 
            // obtenirVentesTotalToolStripButton
            // 
            this.obtenirVentesTotalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.obtenirVentesTotalToolStripButton.Name = "obtenirVentesTotalToolStripButton";
            this.obtenirVentesTotalToolStripButton.Size = new System.Drawing.Size(196, 36);
            this.obtenirVentesTotalToolStripButton.Text = "Obtenir la valeur";
            this.obtenirVentesTotalToolStripButton.Click += new System.EventHandler(this.obtenirVentesTotalToolStripButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Projet1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // valeurLabel1
            // 
            valeurLabel1.AutoSize = true;
            valeurLabel1.Location = new System.Drawing.Point(48, 115);
            valeurLabel1.Name = "valeurLabel1";
            valeurLabel1.Size = new System.Drawing.Size(80, 25);
            valeurLabel1.TabIndex = 3;
            valeurLabel1.Text = "Valeur:";
            // 
            // valeurLabelLabel
            // 
            this.valeurLabelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valeurLabelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableVentesBindingSource, "Valeur", true));
            this.valeurLabelLabel.Location = new System.Drawing.Point(148, 115);
            this.valeurLabelLabel.Name = "valeurLabelLabel";
            this.valeurLabelLabel.Size = new System.Drawing.Size(158, 35);
            this.valeurLabelLabel.TabIndex = 4;
            this.valeurLabelLabel.Text = "label1";
            this.valeurLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VenteParAnneeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 494);
            this.Controls.Add(valeurLabel1);
            this.Controls.Add(this.valeurLabelLabel);
            this.Controls.Add(this.obtenirVentesTotalToolStrip);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "VenteParAnneeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente par année";
            this.Load += new System.EventHandler(this.VenteParAnneeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVentesBindingSource)).EndInit();
            this.obtenirVentesTotalToolStrip.ResumeLayout(false);
            this.obtenirVentesTotalToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource dataTableVentesBindingSource;
        private NorthwindDataSetTableAdapters.DataTableVentesTableAdapter dataTableVentesTableAdapter;
        private System.Windows.Forms.ToolStrip obtenirVentesTotalToolStrip;
        private System.Windows.Forms.ToolStripLabel paysToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paysToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dDDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dDDToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dDFToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dDFToolStripTextBox;
        private System.Windows.Forms.ToolStripButton obtenirVentesTotalToolStripButton;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label valeurLabelLabel;
    }
}