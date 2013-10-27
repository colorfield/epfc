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
using System.Collections; // A FAIRE : package exact

namespace ECOLE_CRM
{
    public partial class Etudiant_View : Form
    {
        public Etudiant_View()
        {
            InitializeComponent();
        }

        private void EtudiantView_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'ecoleDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etudiantTableAdapter.Fill(this.ecoleDataSet.Etudiant);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.etudiantTableAdapter.FillByNomOrPrenom(this.ecoleDataSet.Etudiant, tbx_search.Text, tbx_search.Text);
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            this.etudiantTableAdapter.Fill(this.ecoleDataSet.Etudiant);
        }

        private void dgv_etudiantSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupérer la ligne d'une cellule
            DataGridViewRow r;
            r = dgv_etudiantSelect.Rows[e.RowIndex];
            int etudiantId = int.Parse(r.Cells[0].Value.ToString());

            EtudiantCours_View frm_EtudiantCours = new EtudiantCours_View();
            frm_EtudiantCours.etudiantId = etudiantId;
            this.passDetails(frm_EtudiantCours);
            frm_EtudiantCours.ShowDialog();
        }

        /// <summary>
        /// A FAIRE : On passe les détails ici... pas mieux ??
        /// </summary>
        /// <param name="frm_EtudiantCours"></param>
        private void passDetails(EtudiantCours_View frm_EtudiantCours)
        {
            IEnumerator en = this.ecoleDataSet.Etudiant.Rows.GetEnumerator();
            // IEnumerator en = this.ecoleDataSet.Tables["Etudiant"].Rows.GetEnumerator();
            //se placer au début par sécurité
            en.Reset();
            Boolean founded = false;

            while (!founded && en.MoveNext())
            {
                if (int.Parse(((DataRow)en.Current)["idEtud"].ToString()) == frm_EtudiantCours.etudiantId)
                {
                    founded = true;
                }
            }

            DataRow curRow = ((DataRow)en.Current);

            frm_EtudiantCours.etudiantNom = curRow["nom"].ToString();
            frm_EtudiantCours.etudiantPrenom = curRow["prénom"].ToString();
            frm_EtudiantCours.etudiantAdr = curRow["adr"].ToString();
            frm_EtudiantCours.etudiantDDN = curRow["ddn"].ToString();
        }

        private void Etudiant_View_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'ecoleDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etudiantTableAdapter.Fill(this.ecoleDataSet.Etudiant);

        }


    }
}
