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
    public partial class ProfCours_View : Form
    {

        public int profId;
        public String profNom;
        public String profPrenom;

        public ProfCours_View()
        {
            InitializeComponent();
        }

        private void ProfCoursView_Load(object sender, EventArgs e)
        {
            // cours d'un prof (peuple DGV)
            this.coursTableAdapter.FillByProfId(this.ecoleDataSet.Cours, this.profId);

            // titre de la Form
            this.Text += this.profId;

            // titre de la liste
            this.lbl_coursListTitle.Text += this.profPrenom + " " + this.profNom;
        }

        private void dgv_coursProf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r;
            r = dgv_coursProf.Rows[e.RowIndex];
            int coursId = int.Parse(r.Cells[0].Value.ToString());
            String coursTitre = r.Cells[1].Value.ToString();

            ProfCoursEtudiant_View frm_profCoursEtudiant = new ProfCoursEtudiant_View();
            frm_profCoursEtudiant.coursId = coursId;
            frm_profCoursEtudiant.profId = this.profId;

            frm_profCoursEtudiant.profNom = this.profNom;
            frm_profCoursEtudiant.profPrenom = this.profPrenom;
            frm_profCoursEtudiant.coursTitre = coursTitre;

            frm_profCoursEtudiant.ShowDialog();
        }
    }
}
