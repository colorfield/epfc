using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// import complémentaire
using System.Data.SqlClient;
using System.Collections; // A FAIRE : pour enumerator => quel package exact ?

namespace ECOLE_CRM
{
    public partial class CoursEtudiant_View : Form
    {

        public String coursTitre;
        private String FORM_TITLE = "Etudiants du Cours de";

        public CoursEtudiant_View()
        {
            InitializeComponent();
        }

        private void CoursEtudiantView_Load(object sender, EventArgs e)
        {
            // titre de la Form
            this.Text = FORM_TITLE + " " + this.coursTitre;

            // titre
            this.lbl_etudiantsListTitle.Text += this.coursTitre;

            // peuple le DGV
            this.etudiantTableAdapter.FillByCoursTitre(this.ecoleDataSet.Etudiant, this.coursTitre);

            // affiche les détails du premier étudiant
            DataGridViewRow r = dgv_etudiantSelect.Rows[0];
            this.showEtudiantDetails(r);
        }


        /// <summary>
        /// Affiche le détail d'un étudiant en fonction d'une DataGridViewRow
        /// Appellé à l'init (row = 0) ou lors du clic sur une row
        /// </summary>
        /// <param name="r"></param>
        private void showEtudiantDetails(DataGridViewRow r)
        {

            // récupérer le contenu d'un cellule, particulière lors du clic sur une ligne
            int etudiant_id = int.Parse(r.Cells[0].Value.ToString());

            /*
            this.ecoleDataSet.Tables["Etudiant"].Rows.Find(this.ecoleDataSet ...
                //.Remove(ds.Tables["LesEtudiants"].Rows[4]));
            */

            // A FAIRE
            //============== autre méthode ? normalement, les données sont déjà là !
            /* ---> affichage des colonnes */
            /*
            foreach (DataColumn dc in this.ecoleDataSet.Tables["Etudiant"].Columns)
            {
                tbx_debug.Text += dc.ColumnName + " - ";
            }
            */
            // si on ne voulait garder que l'étudiant courant dans le DGV
            // this.etudiantTableAdapter.FillByEtudiantId(this.ecoleDataSet.Etudiant, int_etudiant_id);

            // énumérateur
            IEnumerator en = this.ecoleDataSet.Etudiant.Rows.GetEnumerator();
            //IEnumerator en = this.ecoleDataSet.Tables["Etudiant"].Rows.GetEnumerator();
            //se placer au début par sécurité
            en.Reset();
            Boolean founded = false;
            // Boucler tant que pas trouvé et qu'il est possible d'obtenir la ligne suivante
            // Attention, ici, on compte sur l'évaluation optimisée afin d'éviter l'effet de bord
            // qu'aurait alors MoveNext (!founded DOIT se trouver avant)
            while (!founded && en.MoveNext())
            {
                if (int.Parse(((DataRow)en.Current)["idEtud"].ToString()) == etudiant_id)
                {
                    founded = true;
                }
                //tbx_debug.Text += ((DataRow)en.Current)["nom"] + " - ";
            }

            DataRow curRow = ((DataRow)en.Current);

            this.lbl_etudiantAdresse_Data.Text = curRow["adr"].ToString();
            this.lbl_etudiantDDN_Data.Text = curRow["ddn"].ToString();
        }


        /// <summary>
        /// Gestionnaire d'événement lors du clic sur une cellule du DGV
        /// Affiche les détails de l'étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_etudiantSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_etudiantSelect.Rows[e.RowIndex];
            this.showEtudiantDetails(r);
        }
    }
}
