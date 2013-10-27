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
    public partial class Splash : Form
    {

        public const String STR_CON = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\LAOG\autoinc\Ecole.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        
        // constantes à placer dans un .ini ou un .xml pour la localisation (FR_be.xml)
        private const String LABEL_SELECT_TABLE = "Sélectionner une Table";
        private const String ERR_SELECT_TABLE = "Veuillez sélectionner une table d'abord";

        public Splash()
        {
            InitializeComponent();
            cbx_table.Text = LABEL_SELECT_TABLE;
        }

        /// <summary>
        /// Ouvre une nouvelle fenêtre modale en fonction du choix
        /// > du bouton radio
        /// > du bouton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newWindow(object sender, EventArgs e)
        {

            //------------------- TABLE SIMPLE
            if (sender == btn_singleValidate)
            {
                //---- MODE VISUALISATION
                // Si rien n'est sélectionné...
                if (cbx_table.Text == LABEL_SELECT_TABLE)
                {
                    Errors frm_err = new Errors(ERR_SELECT_TABLE);
                    frm_err.ShowDialog();
                }
                // ... sinon on peut y aller
                // ---- MODE VISUALISATION
                else if (rbn_viewMode.Checked == true)
                {
                    switch (cbx_table.SelectedItem.ToString())
                    {
                        // des constantes seraient tout de même mieux
                        // pour la comparaison (et la localisation > L10n)
                        case "Cours":
                            Cours_View frm_coursView = new Cours_View();
                            frm_coursView.ShowDialog();
                            break;
                        case "Etudiant":
                            Etudiant_View frm_etudiantView = new Etudiant_View();
                            frm_etudiantView.ShowDialog();
                            break;
                        case "Prof":
                            Prof_View frm_profView = new Prof_View();
                            frm_profView.ShowDialog();
                            break;
                    }
                }
                //---- MODE UPDATE
                else if (rbn_updateMode.Checked == true)
                {
                    switch (cbx_table.SelectedItem.ToString())
                    {
                        case "Cours":
                            Cours_Update frm_coursUpdate = new Cours_Update();
                            frm_coursUpdate.ShowDialog();
                            break;
                        case "Etudiant":
                            Etudiant_Update frm_etudiantUpdate = new Etudiant_Update();
                            frm_etudiantUpdate.ShowDialog();
                            break;
                        case "Prof":
                            Prof_Update frm_profUpdate = new Prof_Update();
                            frm_profUpdate.ShowDialog();
                            break;
                    }
                }
               
            }
            //------------------- GESTION DES INSCRIPTIONS EN MODE CONNECTE
            else if (sender == btn_inscriptionValidate)
            {
                //---- NOUVEL ETUDIANT
                if (rbn_isNew.Checked == true)
                {
                    Eudiant_New frm_etudiantNew = new Eudiant_New();
                    frm_etudiantNew.ShowDialog();
                }
                //---- ETUDIANT EXISTANT
                else if (rbn_isNotNew.Checked == true)
                {
                    InscriptionEtudiant_C_Update frm_inscriptionUpdate = new InscriptionEtudiant_C_Update();
                    //Inscription_Update_NonConnecte frm_inscriptionUpdate = new Inscription_Update_NonConnecte();
                    frm_inscriptionUpdate.ShowDialog();
                }
            }
            //------------------- VISUALISATION DES INSCRIPTIONS - COURS - PROF - ETUDIANT
            //                    EN MODE NON-CONNECTE
            else if (sender == btn_viewInscription)
            {
                InscriptionCoursProfEtudiant_View frm_inscr = new InscriptionCoursProfEtudiant_View();
                frm_inscr.ShowDialog();
            }
            //------------------- EDITION DES INSCRIPTIONS EN MODE NON-CONNECTE
            // Inscription : mode non-connecté --- debug uniquement
            else if (sender == btn_inscrUpdateNC)
            {
                Inscription_NC_Update frm_inscrNC = new Inscription_NC_Update();
                frm_inscrNC.ShowDialog();
            }
            // Inscription - Etudiant : par ListBox (équivalent du mode connecté)
            else if (sender == btn_inscriptionUpdateNC_ListBox)
            {
                InscriptionEtudiant_NC_ListBox frm_inscrNC_LBX = new InscriptionEtudiant_NC_ListBox();
                frm_inscrNC_LBX.ShowDialog();
            }
            // Inscription - Etudiant : par DataGridView
            else if (sender == btn_inscriptionUpdateNC_DataGrid)
            {
                InscriptionEtudiant_NC_DataGridView frm_inscrNC_DGV = new InscriptionEtudiant_NC_DataGridView();
                frm_inscrNC_DGV.ShowDialog();
            }

            //------------------- TESTS
            else if (sender == btn_updateTest1)
            {
                InscriptionUpdate_Test1 ftest1 = new InscriptionUpdate_Test1();
                ftest1.ShowDialog();
            }
            else if (sender == btn_updateTest2)
            {
                InscriptionUpdate_Test2 ftest2 = new InscriptionUpdate_Test2();
                ftest2.ShowDialog();
            }
            
        }

    }
}
