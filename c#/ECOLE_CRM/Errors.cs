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
    public partial class Errors : Form
    {
        /// <summary>
        /// Classe affichant les erreurs utilisateur
        /// </summary>
        /// <param name="msg"></param>
        public Errors(String msg)
        {
            InitializeComponent();
            lbl_errMsg.Text = msg;
        }
    }
}
