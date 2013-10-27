using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Collections; // pour IEnumerator

namespace ECOLE_CRM
{
    public partial class InscriptionNewEtudiant_C_Update : Form
    {
        private Data_Etudiant de;
        private Stack<CheckBox> s;

        public InscriptionNewEtudiant_C_Update(Data_Etudiant etudiant)
        {
            this.de = etudiant;
            InitializeComponent();
            lbl_etudiant.Text = de.prenom + " " + de.nom;

            insertEtudiantAndGetId();
            generateCoursChoices();
            
        }

        /*********************************************************
         *                      DATA
         ********************************************************/

        /// <summary>
        /// Insère un nouvel étudiant puis prend son id
        /// On part du principe que deux étudiants n'ont pas le même nom et prénom
        /// </summary>
        /// <returns></returns>
        private void insertEtudiantAndGetId(){
            //------------------ INSERE L'ETUDIANT
            SqlConnection con = new SqlConnection(Splash.STR_CON);
            con.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            String str_cmd_beg = "INSERT INTO Etudiant(nom,prénom,ddn,adr) VALUES(";
            String str_cmd_end = ")";
            String str_cmd = str_cmd_beg;
            str_cmd += "'" + de.nom + "','" + de.prenom + "','" + de.ddn.ToShortDateString() +"','" + de.adr + "'";
            //str_cmd += "'" + de.nom + "','" + de.prenom + "','" + de.adr + "'";
            str_cmd += str_cmd_end;
            cmd.CommandText = str_cmd;

            tbx_debug.Text = str_cmd;
            
            cmd.ExecuteNonQuery();

            
            //------------------ RECUPERE ENSUITE SON ID
            str_cmd = "SELECT * FROM Etudiant";
            cmd.CommandText = str_cmd;

            SqlDataReader r = cmd.ExecuteReader();
            
            // même si on a plusieurs couples non - prénom 
            // on prend le dernier dans ce cas (donc le dernier inséré, ce qui nous intéresse ici)
            while (r.Read())
            {
                if ((r["nom"].ToString() == de.nom) && (r["prénom"].ToString() == de.prenom))
                {
                    de.id = int.Parse(r["idEtud"].ToString());
                }
            }
            r.Close();
            
            con.Close();
            tbx_debug.Text += "ID = " + de.id.ToString();
        }

        private void insertIntoInscription()
        {
            SqlConnection con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            DateTime date = new DateTime();
            int year = date.Year;
            //////////////////////////////////////
            year = 2010;
            //////////////////////////////////////
            
            String str_cmd_beg = "INSERT INTO Inscription VALUES(";
            String str_cmd_end = ")";
            String str_cmd = "";

            IEnumerator en = s.GetEnumerator();
            CheckBox cbx_current;

            while (en.MoveNext())
            {
                cbx_current = (CheckBox)en.Current;
                // 1) Le nom de la CheckBox (cbx_current.Nam) 
                //    est en fait un moyen pratique pour stocker l'id du Cours
                // 2) Si la ChecBox est Checked, on fait l'insertion
                if (cbx_current.Checked == true)
                {
                    str_cmd = str_cmd_beg;
                    str_cmd += cbx_current.Name + "," + de.id + "," + year.ToString();
                    str_cmd += str_cmd_end;
                    cmd.CommandText = str_cmd;
                    cmd.ExecuteNonQuery();
                } 
            }

            con.Close();

            this.Close();

        }


        /*********************************************************
         *                      GUI
         ********************************************************/
        /// <summary>
        /// Crée et affiche une CheckBox
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        private void createCheckBox(String id, String label, int xPos, int yPos)
        {
            CheckBox cbx = new CheckBox();

            s.Push(cbx);

            cbx.AutoSize = true;
            cbx.Location = new System.Drawing.Point(xPos, yPos);
            cbx.Name = id;
            cbx.Size = new System.Drawing.Size(180, 17);
            cbx.TabIndex = 2;
            cbx.Text = label;
            cbx.UseVisualStyleBackColor = true;

            this.Controls.Add(cbx);
        }

        /// <summary>
        /// Affiche une liste de CheckBox selon les Cours disponibles
        /// </summary>
        private void generateCoursChoices()
        {
            SqlConnection con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            String qry = "SELECT * FROM Cours C JOIN Prof P ON P.idProf = C.numProf";
            cmd.CommandText = qry;

            SqlDataReader r = cmd.ExecuteReader();

            //--------

            s = new Stack<CheckBox>();
       
            // positionnement des CheckBox
            int INI_X = 17;
            int INI_Y = 80;
            int GAP_X = 190;
            int GAP_Y = 20;
            int N_LINES = 7;

            int xPos = INI_X;
            int yPos = INI_Y;

            int cpt = 0;

            while (r.Read())
            {
                createCheckBox(r["idCours"].ToString(),
                               r["Titre"].ToString() + " (" + r["nom"].ToString() + ")",
                               xPos, yPos);
                // lignes
                yPos += GAP_Y;
                cpt++;
                // colonnes
                if (cpt % N_LINES == 0) { yPos = INI_Y; xPos += GAP_X; }
            }
            
        }

        private void btn_inscrire_Click(object sender, EventArgs e)
        {
            insertIntoInscription();
        }

    }
}
