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
    public partial class InscriptionEtudiant_C_Update : Form
    {
       
        private SqlConnection con;
        private Stack<Data_Cours> lst_toInsert;
        private Stack<Data_Cours> lst_toRemove;
        private int curYear;
        
        public InscriptionEtudiant_C_Update()
        {
            InitializeComponent();
            
            // année courante de l'inscription
            this.curYear = 2010;
            this.lbl_year.Text += curYear.ToString();

            // récupère tous les étudiants pour peupler la ComboBox
            fetchEtudiants();

        }

        /****************************************************************
         *                      DATA
         ***************************************************************/

        /// <summary>
        /// Récupère la liste des Etudiants
        /// </summary>
        private void fetchEtudiants()
        {
            con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            String qry = "SELECT * FROM Etudiant";
            cmd.CommandText = qry;

            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                // !! attention au cast de la date si null !!
                cbx_etudiants.Items.Add(new Data_Etudiant(int.Parse(r["idEtud"].ToString()), r["nom"].ToString(),
                                        r["prénom"].ToString(),(DateTime)r["ddn"],r["adr"].ToString()));
            }
        }


        /// <summary>
        /// Récupère la liste des Cours auxquels est inscrit un étudiant
        /// Ainsi que la liste auxquels il n'est pas inscrit
        /// </summary>
        private void fetchEtudiantCours(int idEtudiant)
        {
            // initalisation des ListBox
            initListBoxes();
            // initialisation des piles
            initStacks();

            con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            // ------- Liste des Cours auxquels l'Etudaint est inscrit
            String qry = "SELECT * FROM Cours C JOIN Inscription I ON I.numCours = C.idCours ";
            qry += "WHERE I.numEtud = "+ idEtudiant + " AND I.année=" + this.curYear.ToString();
            cmd.CommandText = qry;
            
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                lbx_inscrit.Items.Add(new Data_Cours(int.Parse(r["idCours"].ToString()),
                                                     int.Parse(r["année"].ToString()),
                                                     r["Titre"].ToString()));
            }
            r.Close();

            //-------- Liste des Cours auxquels l'Etudiant n'est pas inscrit
            // par défaut, on leur assigne l'année courante (en prévision d'une inscription potentielle)

            DateTime date = new DateTime();
            int year = date.Year;

            qry = "SELECT * FROM Cours C ";
            qry += "WHERE C.idCours NOT IN (SELECT C2.idCours FROM Cours C2 JOIN Inscription I2 ON I2.numCours = C2.idCours ";
            qry += "WHERE I2.numEtud = "+ idEtudiant +")";
            
            cmd.CommandText = qry;
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                lbx_nonInscrit.Items.Add(new Data_Cours(int.Parse(r["idCours"].ToString()),
                                                        year,
                                                        r["Titre"].ToString()));
            }
            r.Close();
            
            con.Close();
        }

        /// <summary>
        /// Insertion d'un record dans la table des inscriptions
        /// </summary>
        /// <param name="cmd"></param>
        private void insertIntoInscription()
        {
            SqlConnection con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            String str_cmd_beg = "INSERT INTO Inscription VALUES(";
            String str_cmd_end = ")";
            String str_cmd = "";

            Data_Etudiant de = (Data_Etudiant)cbx_etudiants.SelectedItem;
            
            IEnumerator en = lst_toInsert.GetEnumerator();
            Data_Cours dc_current;

            
            while (en.MoveNext())
            {
                dc_current = (Data_Cours)en.Current;
                ////////////////////////////////////////////////////
                dc_current.year = this.curYear;
                ///////////////////////////////////////////////////
                str_cmd = str_cmd_beg;
                str_cmd += dc_current.id + "," + de.id +","+ dc_current.year;
                str_cmd += str_cmd_end;
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        /// <summary>
        /// Supprime un record de la tables des Inscriptions
        /// </summary>
        /// <param name="cmd"></param>
        private void deleteFromCours()
        {

            SqlConnection con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            String str_cmd_beg = "DELETE FROM Inscription WHERE ";
            String str_cmd = "";

            Data_Etudiant de = (Data_Etudiant)cbx_etudiants.SelectedItem;

            IEnumerator en = lst_toRemove.GetEnumerator();
            Data_Cours dc_current;

            while (en.MoveNext())
            {
                dc_current = (Data_Cours)en.Current;
                str_cmd = str_cmd_beg;
                str_cmd += "numCours=" + dc_current.id + " AND numEtud=" + de.id;
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }



        //----------- Représentation des données dans la RAM ----------------


        private void initStacks()
        {
            // pour ne pas compter sur le garbage collector (??)
            lst_toInsert = null;
            lst_toRemove = null;

            lst_toInsert = new Stack<Data_Cours>();
            lst_toRemove = new Stack<Data_Cours>();
        }

        /// <summary>
        /// Suppression d'un Cours 
        /// dans une des piles de modification (toInsert ou toDelete)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dc_toRemove"></param>
        private void removeFromStack(Stack<Data_Cours> s, Data_Cours dc_toModify)
        {
            IEnumerator en = s.GetEnumerator();
            Data_Cours dc_current;

            en.Reset();
            
            // !!!!!!! l'énumérateur ne supporte pas que la collection soit modifiée !
            if (dc_toModify != null)
            {
                while (en.MoveNext())
                {
                    dc_current = (Data_Cours)en.Current;
                    // si dans la pile, on le supprime
                    if (dc_current.id == dc_toModify.id)
                    {
                        s.Pop();
                    }
                }
            }
        }


        /// <summary>
        /// Affichage d'une pile dans un TextBox de debug
        /// </summary>
        /// <param name="s"></param>
        private void debug_displayStack(Stack<Data_Cours> s)
        {
            IEnumerator en = s.GetEnumerator();
            Data_Cours dc_current;
            en.Reset();
            while (en.MoveNext())
            {
                dc_current = (Data_Cours)en.Current;
                if (dc_current != null)
                {
                    tbx_debug.Text += dc_current.ToString() + "\t | ";
                }
            }
        }

        /****************************************************************
         *                      GUI
         ***************************************************************/

        //--------------------- LISTBOX ----------------------------------

        /// <summary>
        /// (Ré)initialise les ListBox
        /// </summary>
        private void initListBoxes()
        {
            lbx_inscrit.Items.Clear();
            lbx_nonInscrit.Items.Clear();
        }

        /// <summary>
        /// Sélection d'un Cours auquel l'Etudiant est inscrit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_inscrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DataCoursEtudiant dce = (DataCoursEtudiant)lbx_nonInscrit.SelectedItem;
            lbl_coursData.Text = dce.Titre + " (" + dce.idCours + ")";
            */
        }

        private void lbx_nonInscrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DataCoursEtudiant dce = (DataCoursEtudiant)lbx_nonInscrit.SelectedItem;
            lbl_coursData.Text = dce.Titre + " (" + dce.idCours + ")";
            */
        }


        //--------------------- COMBOBOX ----------------------------------
        /// <summary>
        /// Sélection d'un étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_etudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_Etudiant de = (Data_Etudiant)cbx_etudiants.SelectedItem;
            fetchEtudiantCours(de.id);
        }

        //--------------------- BUTTONS ----------------------------------
        /// <summary>
        /// Ajout d'un Cours pour un Etudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            // A FAIRE : tester si ListBox pas vide, faire les enabled / disabled, ...
            lbx_inscrit.Items.Add(lbx_nonInscrit.SelectedItem);
            
            // le cloner avant de le supprimer (??) => en tout cas, on a besoin d'une nouvelle référence
            // Data_Cours dc_toInsert = (Data_Cours)lbx_inscrit.SelectedItem;
            Data_Cours dc_tmp = (Data_Cours)lbx_nonInscrit.SelectedItem;
            Data_Cours dc_toInsert = new Data_Cours(dc_tmp.id, dc_tmp.year, dc_tmp.titre);
            
            lbx_nonInscrit.Items.Remove(lbx_nonInscrit.SelectedItem);

            // vérifier d'abord si était dans la pile toRemove (changement d'avis)
            // et si oui, on le supprime
            removeFromStack(lst_toRemove, dc_toInsert);

            // empiler dans toInsert
            lst_toInsert.Push(dc_toInsert);
            debug_displayStack(lst_toInsert);
        }

        /// <summary>
        /// Suppression d'un Cours pour un Etudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_remove_Click(object sender, EventArgs e)
        {
            // A FAIRE : tester si ListBox pas vide, faire les enabled / disabled, ...
            lbx_nonInscrit.Items.Add(lbx_inscrit.SelectedItem);

            // le cloner avant de le supprimer (??) => en tout cas, on a besoin d'une nouvelle référence
            // Data_Cours dc_toInsert = (Data_Cours)lbx_inscrit.SelectedItem;
            Data_Cours dc_tmp = (Data_Cours)lbx_inscrit.SelectedItem;
            Data_Cours dc_toRemove = new Data_Cours(dc_tmp.id, dc_tmp.year, dc_tmp.titre);

            lbx_inscrit.Items.Remove(lbx_inscrit.SelectedItem);

            // vérifier d'abord si le Cours était dans la pile toInsert (changement d'avis)
            // et si oui, on le supprime
            removeFromStack(lst_toInsert, dc_toRemove);

            // empiler dans toRemove
            lst_toRemove.Push(dc_toRemove);
            debug_displayStack(lst_toRemove);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // debug
            tbx_debug.Text = "Inscriptions à supprimer : ";
            debug_displayStack(lst_toRemove);
            tbx_debug.Text += "  ----- ||| Inscriptions à insérer : ";
            debug_displayStack(lst_toInsert);
               
            //-------- faire les insertions en fonction de la pile toInsert
            if (lst_toInsert.Count() > 0)
            {
                insertIntoInscription();
            }
            //-------- faire les suppressions en fonction de la pile toDelete
            if (lst_toRemove.Count() > 0)
            {    
                deleteFromCours();
             }

            tbx_debug.Text += "Modification effectué";

            this.Close();
        }

        

    }
}
