/*
Programmeur: Fabrice,Perez, Kayleb
Date: février 2026
Solution: projet1.sln
Projet: projet1.csproj
Classe: VentesForm.cs
But : 
******************************************************************
Créer une solution qui contient trois formulaires :
o Formulaire principal
o Liste de commandes pour un client spécifique
(Procédure stockée, mode simplex et mode complexe)
o Un sommaire des ventes pour une période donnée retournant une seule valeur(Fonction agrégée)

*************** Consignes Base de données :
o Un seul DataSet pour la solution.
o NorthWind locale est utilisée pour tous les formulaires
o Mise à jour : Aucune dans toutes les situations.
o Générer seulement le « Fill » dans toutes les situations
 
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
    public partial class VentesForm : Form
    {
        #region Constructeur
        public VentesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Load
        private void VentesForm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ouverture des formulaires enfants
        //liste des commandes pour un client spécifique
        private void listCommadClientSpecButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListCommandClientForm listCommandClientForm = new ListCommandClientForm();
                listCommandClientForm.MinimumSize = new Size(600, 650);
                listCommandClientForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the form liste commande: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listVenteButton_Click(object sender, EventArgs e)
        {
            try
            {
               VenteParAnneeForm venteParAnneeForm = new VenteParAnneeForm();
               venteParAnneeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the form liste vente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

    }
}