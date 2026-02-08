namespace Projet1
{
    partial class VentesForm
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
            this.listCommadClientSpecButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.listVenteButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCommadClientSpecButton
            // 
            this.listCommadClientSpecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCommadClientSpecButton.Location = new System.Drawing.Point(135, 12);
            this.listCommadClientSpecButton.Name = "listCommadClientSpecButton";
            this.listCommadClientSpecButton.Size = new System.Drawing.Size(421, 38);
            this.listCommadClientSpecButton.TabIndex = 0;
            this.listCommadClientSpecButton.Text = "Liste des commandes d\'un client spécifique";
            this.listCommadClientSpecButton.UseVisualStyleBackColor = true;
            this.listCommadClientSpecButton.Click += new System.EventHandler(this.listCommadClientSpecButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.listVenteButton);
            this.menuPanel.Controls.Add(this.listCommadClientSpecButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(602, 111);
            this.menuPanel.TabIndex = 1;
            // 
            // listVenteButton
            // 
            this.listVenteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVenteButton.Location = new System.Drawing.Point(135, 56);
            this.listVenteButton.Name = "listVenteButton";
            this.listVenteButton.Size = new System.Drawing.Size(421, 38);
            this.listVenteButton.TabIndex = 1;
            this.listVenteButton.Text = "Liste des ventes par année";
            this.listVenteButton.UseVisualStyleBackColor = true;
            this.listVenteButton.Click += new System.EventHandler(this.listVenteButton_Click);
            // 
            // VentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 111);
            this.Controls.Add(this.menuPanel);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "VentesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventes";
            this.Load += new System.EventHandler(this.VentesForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listCommadClientSpecButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button listVenteButton;
    }
}

