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
        public VentesForm()
        {
            InitializeComponent();
        }

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
    }
}
