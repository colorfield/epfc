using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Collections;

namespace ECOLE_CRM
{
    public partial class InscriptionEtudiant_NC_DataGridView : Form
    {

        // DataTables complémentaires
        private SqlConnection con;
        private SqlDataAdapter da_Inscr;
        private DataTable dt_Inscr;
        private DataRow [] driToUpdate;
        private DataRow[] driToDelete;
       
        // pour passer un "cours" d'une datagrid à l'autre
        private int coursId = -1; // valeur sentinelle
        private String etudiantId = ""; // valeur sentinelle
        private String coursTitre;
        private String profNom;
        private String profPrenom;
        private String inscrAnnee;
        private int curRow;
        private String curYear;

        // gestion des inscriptions


        public InscriptionEtudiant_NC_DataGridView()
        {
            InitializeComponent();
            fetchEtudiants();
            // on peut passer par ce moyen là pour
            // éviter de redéfinir les update dans le XSD
            // pour les DataTable cours inscrit et non inscrit
            // ce qui offre en fait plus de souplesse
            // (p.ex. si redéfinition d'autres DataTables
            // relatifs aux inscriptions) !
            fetchInscriptions();

            // initInscriptionData();

        }

        /// <summary>
        /// -------------------- TEST ---------------------------
        /// --- A SUPPRIMER ---
        /// </summary>
        private void initInscriptionData()
        {
            SqlConnection cn = new SqlConnection();
            DataSet MesInscriptionsDataSet = new DataSet();
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;
        
            cn.ConnectionString = Splash.STR_CON;
            cn.Open();

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("select * from Inscription", cn);

            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(MesInscriptionsDataSet, "Inscription");
            //Write out the value in the CustName field before updating the data using the DataSet.
            tbx_debug.Text += "Année before Update : " + MesInscriptionsDataSet.Tables["Inscription"].Rows[0]["année"] + "\r\n";

            //Modify the value of the CustName field.
            MesInscriptionsDataSet.Tables["Inscription"].Rows[1]["année"] = "2050" + "\r\n";

            //Post the data modification to the database.
            da.Update(MesInscriptionsDataSet, "Inscription");

            tbx_debug.Text += "Année updated successfully \r\n";

            //Close the database connection.
            cn.Close();
        }




        /// <summary>
        /// Mise à jour des DataGrid cours inscrit / non inscrit
        /// </summary>
        /// <param name="refreshMode"></param>
        private void refreshDataGrid(String refreshMode)
        {
            // un moyen "simple" serait de mettre à jour directement Inscription (insert et delete)
            // puis rappeller Fill pour les deux DataTable
            // mais vu que cela rend absurde l'utilisation du mode non connecté 
            // (le trafic étant plus intense que dans le cadre du simple mode connecté !!) 
            // Dans ce cas également, le bouton "modifier" ne serait plus utile
            // (ou alors suppression en GUI puis réalisation en un coup, ce qui se défendrait plus)
            // ---
            // On se retrouve toutefois dans la situation assez particulière
            // où la structure de données initiale des cours auxquels l'étudiant
            // n'est pas inscrit ne comporte pas d'année d'inscritpion ni l'id de l'étudiant
            // Si un étudiant choisit de se désinscrire, on aura besoin de son id et de 
            // l'année d'inscription pour pouvoir le désinscrire !
            // Ici, on part du principe qu'on modifie toujours l'année courante

            if (etudiantId != "" && coursId != -1)
            {
                // mode par défaut = inscription
                DataTable dtRemove = null; // DataTable où on va supprimer
                DataTable dtAdd = null; // DataTable où on va ajouter
                DataRow dr = null;
                
                if (refreshMode == "INSCR")
                {
                    dtRemove = this.ecoleDataSet.EtudiantCoursNonInscrit;
                    dtAdd = this.ecoleDataSet.EtudiantCoursInscrit;
                    dr = this.ecoleDataSet.EtudiantCoursInscrit.NewRow();
                }else if(refreshMode == "DESINSCR")
                {
                    dtRemove = this.ecoleDataSet.EtudiantCoursInscrit;
                    dtAdd = this.ecoleDataSet.EtudiantCoursNonInscrit;
                    dr = this.ecoleDataSet.EtudiantCoursNonInscrit.NewRow();
                }

                // 1) éléments communs de la row pour les deux DataTable
                dr["idCours"] = this.coursId;
                dr["Titre"] = this.coursTitre;
                dr["prénom"] = this.profPrenom;
                dr["nom"] = this.profNom;
                dr["numEtud"] = this.etudiantId;
                dr["année"] = this.inscrAnnee;
                dtAdd.Rows.Add(dr);

                // 2) suppression (immédiate : via Remove) de la row dans la DataTable du cours
                // !! ne doit pas être nul !!
                dtRemove.Rows.Remove(dtRemove.Rows[this.curRow]);


                //----------------- Gestion du DataTable Inscription
                
                if (refreshMode == "INSCR")
                {
                    DataRow dri = this.ecoleDataSet.Inscription.NewRow();
                    
                    dri["numCours"] = this.coursId;
                    dri["numEtud"] = int.Parse(this.etudiantId);
                    dri["année"] = this.inscrAnnee;
                    this.ecoleDataSet.Inscription.Rows.Add(dri);

                    tbx_debug.Text += "Ajout DataRow : " + coursId + "," + etudiantId + "," + inscrAnnee + "\r\n"; 
                }
                else if (refreshMode == "DESINSCR")
                { 
                    // !!! doit lier  l'id etudiant / année
                    // pour connaître l'id de la row !!!
                    // parcourir le DataTable en quête de l'id de la row...
                    IEnumerator en = this.ecoleDataSet.Inscription.Rows.GetEnumerator();
                    en.Reset();
                    Boolean notFound = true;
                    int curRow = 0;
                    String curNumEtud;
                    int curNumCours;
                    int curAnnee;

                    tbx_debug.Text += "\r\n ---> ROW A TROUVER (" + coursId + "," + etudiantId + "," + inscrAnnee + ")\r\n";

                    while (en.MoveNext() && notFound)
                    { 
                        curNumEtud = ((DataRow)en.Current)["numEtud"].ToString();
                        curNumCours = int.Parse(((DataRow)en.Current)["numCours"].ToString());
                        curAnnee = int.Parse(((DataRow)en.Current)["année"].ToString());
                        // équivalent au parse...
                        // curAnnee = curAnnee.Trim();

                        tbx_debug.Text += "ROW PARCOURU " + curRow + "(" + curNumEtud + "," + curNumCours + "," + curAnnee + ")\r\n";

                        if (curNumEtud == this.etudiantId &&
                           curNumCours == this.coursId &&
                           curAnnee == int.Parse(this.inscrAnnee))
                        {
                            tbx_debug.Text = "--- ROW TROUVE " + curRow + "\r\n"; 
                            // !!!!! ne peut modifier la collection en cours de parcours
                            // par l'énumérateur
                            // ecoleDataSet.Inscription.Rows.Remove(ecoleDataSet.Inscription.Rows[curRow]);
                            // donc marque la ligne pour plus tard
                            ecoleDataSet.Inscription.Rows[curRow].Delete();
                            notFound = false;
                            // mais attention, lors du parcours suivant (si suppression d'un autre cours)
                            // on doit faire un update --- et non un acceptchanges (qui ne refleterait alors en rien les 
                            // modifications souhaitées vu que le deleted serait passé à unchanged !!)
                        }

                        curRow++;
                    }

                    driToDelete = ecoleDataSet.Inscription.Select(null, null, DataViewRowState.Deleted);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da_Inscr);
                    da_Inscr.Update(driToDelete);
                 }
                

            }

        }


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
                cbx_etudiant.Items.Add(new Data_Etudiant(int.Parse(r["idEtud"].ToString()), r["nom"].ToString(),
                                        r["prénom"].ToString(), (DateTime)r["ddn"], r["adr"].ToString()));
            }

        }

        private void fetchInscriptions()
        {
            con = new SqlConnection(Splash.STR_CON);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Inscription";
            da_Inscr = new SqlDataAdapter();
            da_Inscr.SelectCommand = cmd;
            da_Inscr.Fill(ecoleDataSet.Inscription);
            dt_Inscr = (DataTable)ecoleDataSet.Inscription;
        }

        private void fetchAvailableYearsForStudent()
        {

            cbx_etudiantYear.Items.Clear();
            cbx_etudiantYear.Text = "Sélectionner une année";

            con = new SqlConnection(Splash.STR_CON);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            String qry = "SELECT DISTINCT année FROM Inscription WHERE numEtud="+this.etudiantId;
            cmd.CommandText = qry;

            SqlDataReader r = cmd.ExecuteReader();
            int cpt = 0;
            int year = 2010;
            while (r.Read())
            {
                cpt++;
                year = new int();
                year = int.Parse(r["année"].ToString());
                cbx_etudiantYear.Items.Add(year);
            }

            // si le compteur est toujours à 0, c'est qu'aucune année
            // n'a été trouvée, donc il s'agit d'un étudiant qui a été 
            // enregistré dans l'école mais n'a jamais été inscriy
            // donc on ajoute simplement l'année courante
            // et on présume qu'il s'agit du même cas qu'une nouvelle inscription
            if (cpt == 0)
            {
                this.curYear = "2010";
                displayDataGridViewData();
                this.cbx_etudiantYear.Visible = false;
                this.lbl_year.Text = "Aucune année trouvée, utilisation de l'année courante";
            }
            // s'il n'y a qu'une année, on prend celle là...
            else if (cpt == 1) {
                this.curYear = year.ToString();
                displayDataGridViewData();
                this.cbx_etudiantYear.Visible = false;
                this.lbl_year.Text = "Une seule année trouvée (" + this.curYear + ")" ;
            // sinon a besoin du ComboBox pour plusieurs années
            }else
            {
                this.cbx_etudiantYear.Visible = true;
                this.lbl_year.Text = "Année";
            }
        }

        

        // affichage des data dans les DataGridView
        private void displayDataGridViewData()
        {
            this.etudiantCoursInscritTableAdapter.Fill(this.ecoleDataSet.EtudiantCoursInscrit,int.Parse(this.etudiantId),this.curYear);
            this.etudiantCoursNonInscritTableAdapter.FillByCoursDisponibles(this.ecoleDataSet.EtudiantCoursNonInscrit,int.Parse(this.etudiantId),this.curYear);
        }
   

        /******************** GESTIONNAIRES D'EVENEMENTS UTILISATEUR ****************/

        private void btn_add_Click(object sender, EventArgs e)
        {
            refreshDataGrid("INSCR");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            refreshDataGrid("DESINSCR");
        }

        /// <summary>
        /// Récupérer les données de la ligne
        /// d'une cellule d'une DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDGVRowData(object sender, DataGridViewCellEventArgs e)
        {
            // idéalement on mettrait le nom des champs au lieu de leur indice
            // mais si on désactive la modification de l'ordre des colonnes
            // et qu'on ne change pas le fill, pas de problème
            DataGridViewRow r;
            DataGridView dgv = (DataGridView)sender;
            r = dgv.Rows[e.RowIndex];
            this.curRow = e.RowIndex;
            this.coursId = int.Parse(r.Cells[0].Value.ToString());
            //this.inscrAnnee = r.Cells[1].Value.ToString();
            this.inscrAnnee = this.curYear;
            this.coursTitre = r.Cells[2].Value.ToString();
            this.profNom = r.Cells[3].Value.ToString();
            this.profPrenom = r.Cells[4].Value.ToString();

            // debug
            tbx_debug.Text = coursId.ToString() + " | " + coursTitre + " | " + profNom + " | " + profPrenom + " | " + etudiantId.ToString();
            tbx_debug.Text += " --- curRow = " + this.curRow.ToString();

        }

        private void cbx_etudiant_SelectedValueChanged(object sender, EventArgs e)
        {
            Data_Etudiant de = (Data_Etudiant)cbx_etudiant.SelectedItem;
            this.etudiantId = de.id.ToString();
            fetchAvailableYearsForStudent();
        }

        private void cbx_etudiantYear_SelectedValueChanged(object sender, EventArgs e)
        {
            this.curYear = cbx_etudiantYear.SelectedItem.ToString();
            displayDataGridViewData();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            driToUpdate = ecoleDataSet.Inscription.Select(null, null, DataViewRowState.Added);
            // driToDelete = ecoleDataSet.Inscription.Select(null, null, DataViewRowState.Deleted);
            // !!! ne fonctionne pas sans le cmdBuilder !!!
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da_Inscr);
            da_Inscr.Update(driToUpdate);
            // da_Inscr.Update(driToDelete);
            con.Close();

            /*
            String cmd_ins = "INSERT INTO INSCRIPTION(numCours,numEtud,année)";
            cmd_ins += "VALUES(@cours,@etud,@annee)";

            // da_Inscr.DeleteCommand = new SqlCommand("");
            // da_Inscr.UpdateCommand = new SqlCommand("");
            // da_Inscr.InsertCommand = new SqlCommand(cmd_ins);
            
            da_Inscr.Update(driToUpdate);
            con.Close();
            */
            /*
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da_Inscr);
            tbx_debug.Text = "\r\n ++++++++ " + cmdBuilder.GetInsertCommand().CommandText;
            tbx_debug.Text = "\r\n ++++++++ " + cmdBuilder.GetDeleteCommand().CommandText;
            tbx_debug.Text = "\r\n ++++++++ " + cmdBuilder.GetUpdateCommand().CommandText;
            */
           /* 
 +          UPDATE [Inscription] SET 
            [numCours] = @p1, 
            [numEtud] = @p2, 
            [année] = @p3 
            WHERE (([numCours] = @p4) AND ([numEtud] = @p5) AND ([année] = @p6))
            */
            /*
            ecoleDataSet.Inscription.Rows[0]["numCours"] = 4;
            ecoleDataSet.Inscription.Rows[0]["numEtud"] = 8;
            ecoleDataSet.Inscription.Rows[0]["année"] = "2010";
            da_Inscr.Update(ecoleDataSet, "Inscription");
            */
            //Post the data modification to the database.
            // da_Inscr.Update(ecoleDataSet, "Inscription");        

            // da_Inscr.Update(driToUpdate);
            // da_Inscr.Update(ecoleDataSet,"Inscription");

            // con.Close();

            // this.Validate();
            // this.etudiantCoursInscritBindingSource.EndEdit();
            // this.etudiantCoursNonInscritBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.ecoleDataSet);
            this.cbx_etudiantYear.Visible = false;

        }
        

    }
}
