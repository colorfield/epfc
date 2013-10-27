using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECOLE_CRM
{
    /// <summary>
    /// -------------------------------------------------------------
    /// Méthode la plus simple
    /// -------------------------------------------------------------
    /// Drag and Drop de la Table Etudiant sur la Form
    /// depuis la fenêtre "Sources de données"
    /// et modification des entêtes des colonnes depuis l'IDE
    /// </summary>
    public partial class Etudiant_Update : Form
    {
        
        public Etudiant_Update()
        {
            InitializeComponent();
        }

        private void etudiantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoleDataSet);
        }

        private void Etudiant_Update_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'ecoleDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etudiantTableAdapter.Fill(this.ecoleDataSet.Etudiant);

        }
    }
}
