/*
Programmeur: Fabrice,Perez, Kayleb
Date: février 2026
but : 
******************************************************************
*afficher les ventes par année
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class VenteParAnneeForm : Form
    {
        #region Constructeur
        public VenteParAnneeForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Load
        private void VenteParAnneeForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Clique du bouton de recherche
        private void obtenirVentesTotalToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTableVentesTableAdapter.ObtenirVentesTotal(this.northwindDataSet.DataTableVentes, paysToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dDDToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dDFToolStripTextBox.Text, typeof(System.DateTime))))));
                decimal.TryParse(valeurTextBox.Text, out decimal valeur);
                valeurTextBox.Text = valeur.ToString("C2");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        #endregion

    }
}