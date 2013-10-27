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
    public partial class ProfCoursEtudiant_View : Form
    {
        public int profId;
        public int coursId;
        public String profNom;
        public String profPrenom;
        public String coursTitre;

        public ProfCoursEtudiant_View()
        {
            InitializeComponent();
        }

        private void ProfCoursEtudiant_View_Load(object sender, EventArgs e)
        {
            // peuple le DGV
            this.etudiantTableAdapter.FillByProfIdCoursId(this.ecoleDataSet.Etudiant, this.profId, this.coursId);

            // titre de la Form
            this.Text += coursId + "(id prof = )" + this.profId;

            // titre de la liste
            this.lbl_etudiantsListTitle.Text += this.coursTitre + " avec " + this.profPrenom + " " + this.profNom;
        }
    }
}
