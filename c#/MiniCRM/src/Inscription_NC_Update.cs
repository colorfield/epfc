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
    public partial class Inscription_NC_Update : Form
    {
        public Inscription_NC_Update()
        {
            InitializeComponent();
        }

        private void inscriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoleDataSet);

        }

        private void Inscription_Update_NonConnecte_Load(object sender, EventArgs e)
        {
            this.inscriptionTableAdapter.Fill(this.ecoleDataSet.Inscription);
        }
       

    }
}
