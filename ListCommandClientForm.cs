/*
Programmeur: Fabrice,Perez, Kayleb
Date: février 2026
but : 
******************************************************************
*afficher les commandes d'un client spécifique
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
    public partial class ListCommandClientForm : Form
    {
        public ListCommandClientForm()
        {
            InitializeComponent();
        }

        #region form load et stylisation du datagridview
        private void ListCommandClientForm_Load(object sender, EventArgs e)
        {
            
          


            try
            {

                /* sql requete utilisée pour afficher les commandes d'un client spécifique
                             * SELECT       [Order Details].ProductID AS [Numéro produit], FORMAT([Order Details].UnitPrice, 'C2', 'en-US') AS [Prix unité], [Order Details].Quantity AS Quantité, Orders.OrderID AS [Numéro commande]
                    FROM            [Order Details] INNER JOIN
                                             Orders ON [Order Details].OrderID = Orders.OrderID
                    ORDER BY [Numéro produit]; 
                    */
              

                this.getOrderDetailAdapterTableAdapter.GetOrderDetails(this.northwindDataSet.GetOrderDetailAdapter);



                /* sql requete utilisée pour afficher les noms de produits 
                            SELECT       ProductName, ProductID
                            FROM            Products
                    */

                this.productsTableAdapter.GetProductName(this.northwindDataSet.Products);


                //Stylisation du DataGridView et form
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                custOrdersOrdersDataGridView.EnableHeadersVisualStyles = false;
                custOrdersOrdersDataGridView.Columns[0].HeaderCell.Style.BackColor =
                custOrdersOrdersDataGridView.Columns[0].DefaultCellStyle.BackColor;

                // Toutes les colonnes prennent tout l'espace et le texte passe à la ligne si nécessaire
                foreach (DataGridViewColumn col in custOrdersOrdersDataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    col.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                }

                foreach (DataGridViewColumn col in getOrderDetailAdapterDataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    col.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                }

                custOrdersOrdersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                custOrdersOrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                  getOrderDetailAdapterDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    getOrderDetailAdapterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Formatage des dates
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                custOrdersOrdersDataGridView.Columns[1].DefaultCellStyle.FormatProvider = culture;
                custOrdersOrdersDataGridView.Columns[1].DefaultCellStyle.Format = "MMMM d, yyyy";
                custOrdersOrdersDataGridView.Columns[2].DefaultCellStyle.FormatProvider = culture;
                custOrdersOrdersDataGridView.Columns[2].DefaultCellStyle.Format = "MMMM d, yyyy";
                custOrdersOrdersDataGridView.Columns[3].DefaultCellStyle.FormatProvider = culture;
                custOrdersOrdersDataGridView.Columns[3].DefaultCellStyle.Format = "MMMM d, yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        #endregion

        #region bouton de recherche client

        /*  Procedure stockée utilisée pour afficher les commandes d'un client spécifique
               * 
               * USE [Northwind]
              GO
             // Object:  StoredProcedure [dbo].[CustOrdersOrders]    Script Date: 2026-02-08 06:02:43 
              SET ANSI_NULLS ON
                      GO
                          SET QUOTED_IDENTIFIER ON
                          GO

                      ALTER PROCEDURE[dbo].[CustOrdersOrders]
                      @CustomerID nchar(5)
                  AS
                  SELECT OrderID, 
                      OrderDate,
                      RequiredDate,
                      ShippedDate
                  FROM Orders
                  WHERE CustomerID = @CustomerID
                  ORDER BY OrderID 

                  *************************
                  */



        private void getCustomerOrderDetailsToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.custOrdersOrdersTableAdapter.GetCustomerOrderDetails(this.northwindDataSet.CustOrdersOrders, customerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        #endregion

        private void getCustomerOrderDetailsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.custOrdersOrdersTableAdapter.GetCustomerOrderDetails(this.northwindDataSet.CustOrdersOrders, customerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getCustomerOrderDetailsToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.custOrdersOrdersTableAdapter.GetCustomerOrderDetails(this.northwindDataSet.CustOrdersOrders, customerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
