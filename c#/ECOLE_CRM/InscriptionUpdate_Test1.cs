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
    public partial class InscriptionUpdate_Test1 : Form
    {
        public InscriptionUpdate_Test1()
        {
            InitializeComponent();
        }

        private void inscriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoleDataSet);

        }

        private void InscriptionUpdate_Test_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'ecoleDataSet.Inscription'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.inscriptionTableAdapter.Fill(this.ecoleDataSet.Inscription);

        }
    }
}
