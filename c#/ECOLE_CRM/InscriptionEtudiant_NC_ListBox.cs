using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ECOLE_CRM
{
    public partial class InscriptionEtudiant_NC_ListBox : Form
    {
        private String STR_CON = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\LAOG\autoinc\Ecole.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private SqlConnection con;
        private DataSet ds;
        private SqlDataAdapter da;
        private DataTable dtNonInscrit;

        public InscriptionEtudiant_NC_ListBox()
        {
            InitializeComponent();
            initDataSet();
        }

        private void initDataSet()
        {
            con = new SqlConnection(STR_CON);
            //créer une instance de DataSet
            ds = new DataSet();

            // Créer un objet Command lié à l'objet Connection
            // avec la requête chargée de sélectionner des données dans la BD
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Cours";

            // Créer une instance de DataAdapter
            da = new SqlDataAdapter();

            // Initialiser la propriété SelectCommand du DataAdapter
            // avec l'objet Command
            da.SelectCommand = cmd;

            // remplir un DataTable du DataSet avec le SqlDataAdapter 
            // précédent (La méthode Fill de la classe SqlDataAdapter 
            // attend 2 paramètres, le DataSet qu'elle doit remplir
            // et une chaîne de caractères utilisée pour nommer le DataTable
            // dans la collection des DataTables du DataSet 
            // (ou simplement 1  paramètre qui soit un objet Datatable
            // (méthode surchargée))
            da.Fill(ds, "LesCours");
            dtNonInscrit = (DataTable)ds.Tables["LesCours"];
            this.displayNonInscrit();
        }


        private void displayNonInscrit()
        {
            lbx_nonInscrit.DataSource = dtNonInscrit;
            // Champ du DataTable
            // !!!! idCours => nécessairement idCours ci-dessous
            lbx_nonInscrit.DisplayMember = "idCours";
        }

        private void lbx_nonInscrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
