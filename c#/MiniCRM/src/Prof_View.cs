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
    public partial class Prof_View : Form
    {
        public Prof_View()
        {
            InitializeComponent();
        }

        private void Prof_View_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'ecoleDataSet.Prof'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.profTableAdapter.Fill(this.ecoleDataSet.Prof);

        }

         private void btn_search_Click(object sender, EventArgs e)
        {
            this.profTableAdapter.FillByNomOrPrenom(this.ecoleDataSet.Prof, this.tbx_search.Text, this.tbx_search.Text);
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            this.profTableAdapter.Fill(this.ecoleDataSet.Prof);
        }

        private void dgv_profSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // récupérer la ligne d'une cellule
            DataGridViewRow r;
            r = dgv_profSelect.Rows[e.RowIndex];
            int profId = int.Parse(r.Cells[0].Value.ToString());
            String profNom= r.Cells[1].Value.ToString();
            String profPrenom = r.Cells[2].Value.ToString();

            ProfCours_View frm_profCours = new ProfCours_View();
            frm_profCours.profId = profId;
            frm_profCours.profNom = profNom;
            frm_profCours.profPrenom = profPrenom;

            frm_profCours.ShowDialog();
        }
    }
    }

