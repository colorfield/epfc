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
    public partial class Cours_View : Form
    {
        public Cours_View()
        {
            InitializeComponent();
        }

        private void Cours_View_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'ecoleDataSet.Cours'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.coursTableAdapter.Fill(this.ecoleDataSet.Cours);
        }

        /****************** GESTIONNAIRES D'EVENEMENTS ****************************/


        private void btn_search_Click(object sender, EventArgs e)
        {
            // A FAIRE : un test dans le range possible de valeurs
            this.coursTableAdapter.FillByCoursTitre(this.ecoleDataSet.Cours, tbx_search.Text);
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            this.coursTableAdapter.FillByProfNom(this.ecoleDataSet.Cours);
        }

        private void dgv_coursSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupérer la ligne d'une cellule
            DataGridViewRow r;
            r = dgv_coursSelect.Rows[e.RowIndex];
            String coursTitre = r.Cells[1].Value.ToString();

            CoursEtudiant_View frm = new CoursEtudiant_View();
            frm.coursTitre = coursTitre;
            frm.ShowDialog();

            // si on souhaite mettre à jour le DGV en n'affichant que l'étudiant courant
            // this.coursTableAdapter.FillByCoursTitre(this.ecoleDataSet.Cours, str_titre_cours);

            // récupérer le contenu d'une cellule
            //tbx_debug.Text += " Cell click " + dgv_cours.CurrentCell.Value.ToString();

        }
    }
}
