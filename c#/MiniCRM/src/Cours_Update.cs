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
    public partial class Cours_Update : Form
    {
        /// <summary>
        /// -----------------------------------------------------------------
        ///                         Moins "automatique"
        /// -----------------------------------------------------------------
        /// 1) Modification préalable de EcoleDataSet.CoursTableAdapter.Fill()
        ///    afin d'afficher le nom et le prénom du Prof
        /// 2) Drag and Drop de la DataTable Cours sur la Form
        /// 3) Appel de la méthode Fill lors de Form.Load()
        /// 4) Ajout d'un BindingNavigator + configuration de sa propriété BindingSource
        /// 5) Ajout du bouton Save + configuration de l'événement Click()
        /// 6) Le Behavior des colonnes Prof.prénom et Prof.nom a été placé en readOnly
        /// </summary>
        public Cours_Update()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoleDataSet);
        }

        private void Cours_Update_Load(object sender, EventArgs e)
        {
            this.coursTableAdapter.Fill(ecoleDataSet.Cours);
        }

    }
}
