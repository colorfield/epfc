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
    public partial class Eudiant_New : Form
    {
        public Eudiant_New()
        {
            InitializeComponent();
        }

        private void btn_nextStep_Click(object sender, EventArgs e)
        {

            // vérifie l'existence au moins du nom et du prénom
            // même si c'est la charge d'un élément du schéma de la DB
            // cela évite pas mal de trafic de le faire ici
            if (tbx_lName.Text == "" || tbx_fName.Text == "")
            {
                lbl_errMsg.Text = "Données incomplètes";
            }
            else
            {
                lbl_errMsg.Text = "";

                // création d'un objet étudiant...
                Data_Etudiant de = new Data_Etudiant();
                de.nom = tbx_lName.Text;
                de.prenom = tbx_fName.Text;
                de.adr = tbx_adress.Text;
                de.ddn = dtp_birthDate.Value;

                // ... que nous allons passer à la Form suivante
                // éventuellement, on pourrait vérifier dans la db si le couple nom - prénom 
                // existe, dans ce cas, on en avertit le gestionnaire
                // Ceci dit, cela plaide en faveur du mode non connecté dans ce cas
                // (et cet exemple est en mode connecté...)
                InscriptionNewEtudiant_C_Update frm = new InscriptionNewEtudiant_C_Update(de);
                this.Hide();
                frm.ShowDialog();
                // une fois que la nouvelle Form appellée rends la main à celle-ci
                // on la ferme, pour retour du focus à la fenêtre de départ
                this.Close();
            }
           
          
        }




    }
}
