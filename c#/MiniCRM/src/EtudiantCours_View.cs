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
using System.Collections; // A FAIRE :pour enumerator => quel package exact ?

namespace ECOLE_CRM
{
    public partial class EtudiantCours_View : Form
    {
        public int etudiantId;
        public String etudiantNom;
        public String etudiantPrenom;
        public String etudiantDDN;
        public String etudiantAdr;

        public EtudiantCours_View()
        {
            InitializeComponent();
        }

        private void EtudiantCours_Load(object sender, EventArgs e)
        {
            // titre de la Form
            this.Text += this.etudiantId;
            this.lbl_etudiantDetailsTitle.Text += this.etudiantId;

            // cours auxquels un étudiant est inscrit
            this.coursTableAdapter.FillByEtudiantId(this.ecoleDataSet.Cours, this.etudiantId);

            // les détails...
            showEtudiantDetails();
        }

        /// <summary>
        /// Affiche les détails d'un étudiant
        /// </summary>
        private void showEtudiantDetails()
        {

            this.lbl_nom_Data.Text = this.etudiantNom;
            this.lbl_prenom_Data.Text = this.etudiantPrenom;
            this.lbl_adr_Data.Text = this.etudiantAdr;
            this.lbl_ddn_Data.Text = this.etudiantDDN;

            /* 
             * Déplacé dans EtudiantView.passDetails()...
             * ===> pour le faire ici
             * aurait-on besoin d'un binding source / table adapter complémentaire ?
             * 
            IEnumerator en = this.ecoleDataSet.Etudiant.Rows.GetEnumerator();
            // IEnumerator en = this.ecoleDataSet.Tables["Etudiant"].Rows.GetEnumerator();
            //se placer au début par sécurité
            en.Reset();
            Boolean founded = false;

            this.lbl_adr_Data.Text += "avant : " + ((DataRow)en.Current)["idEtud"].ToString();
            this.lbl_ddn_Data.Text += "avant : " + this.etudiantId;

            while (!founded)
            {
                this.lbl_adr_Data.Text += "boucle : " + ((DataRow)en.Current)["idEtud"].ToString();
                this.lbl_ddn_Data.Text += "boucle : " + this.etudiantId;

                if (int.Parse(((DataRow)en.Current)["idEtud"].ToString()) == this.etudiantId)
                {
                    this.lbl_nom_Data.Text = "trouvé";
                    founded = true;
                }
                else
                {
                    en.MoveNext();
                }
            }

            DataRow curRow = ((DataRow)en.Current);

            this.lbl_nom_Data.Text = curRow["nom"].ToString();
            this.lbl_prenom_Data.Text = curRow["prénom"].ToString();
            this.lbl_adr_Data.Text = curRow["adr"].ToString();
            this.lbl_ddn_Data.Text = curRow["ddn"].ToString();
            */
        }


    }
}
