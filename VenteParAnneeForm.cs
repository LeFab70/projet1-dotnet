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
            /*
            SELECT SUM(([Order Details].UnitPrice * [Order Details].Quantity) * (1 - [Order Details].Discount)) AS Valeur
            FROM  Employees INNER JOIN
                     Orders ON Employees.EmployeeID = Orders.EmployeeID INNER JOIN
                     [Order Details] ON Orders.OrderID = [Order Details].OrderID
            WHERE (Employees.Country = @Pays) AND (Orders.RequiredDate BETWEEN @DDD AND @DDF)
            GROUP BY Employees.Country
            */
            try
            {
                this.dataTableVentesTableAdapter.ObtenirVentesTotal(this.northwindDataSet.DataTableVentes, paysToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dDDToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dDFToolStripTextBox.Text, typeof(System.DateTime))))));
                decimal.TryParse(valeurLabelLabel.Text, out decimal valeur);
                valeurLabelLabel.Text = valeur.ToString("C2");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        #endregion

    }
}