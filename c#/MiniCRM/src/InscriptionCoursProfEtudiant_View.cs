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
    public partial class InscriptionCoursProfEtudiant_View : Form
    {
        /// <summary>
        /// Ici, dans le XSD, la méthode fill prend un paramètre (id de l'étudiant)
        /// ce qui permet d'obtenir automatiquement, dans le BindingNavigator,
        /// un outil permettant d'appeller Fill avec ce paramètre.
        /// 
        /// Par défaut, lors du Load, on préférera toutefois voir apparaître tous les 
        /// Etudiants, donc on appellera FillByDefault
        /// </summary>
        public InscriptionCoursProfEtudiant_View()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inscriptionCoursProfEtudiantTableAdapter.Fill(this.ecoleDataSet.InscriptionCoursProfEtudiant, ((int)(System.Convert.ChangeType(numEToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void InscriptionCoursProfEtudiant_View_Load(object sender, EventArgs e)
        {
            this.inscriptionCoursProfEtudiantTableAdapter.FillByDefault(this.ecoleDataSet.InscriptionCoursProfEtudiant);
        }




    }
}
