namespace ECOLE_CRM
{
    partial class InscriptionEtudiant_C_Update
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_etudiants = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbx_inscrit = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx_nonInscrit = new System.Windows.Forms.ListBox();
            this.tbx_debug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cours inscrit";
            // 
            // cbx_etudiants
            // 
            this.cbx_etudiants.FormattingEnabled = true;
            this.cbx_etudiants.Location = new System.Drawing.Point(16, 60);
            this.cbx_etudiants.Name = "cbx_etudiants";
            this.cbx_etudiants.Size = new System.Drawing.Size(165, 21);
            this.cbx_etudiants.TabIndex = 37;
            this.cbx_etudiants.Text = "Sélectionner un étudiant";
            this.cbx_etudiants.SelectedIndexChanged += new System.EventHandler(this.cbx_etudiants_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Inscription d\'un étudiant à des Cours";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(304, 358);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 23);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Mettre à jour";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbx_inscrit
            // 
            this.lbx_inscrit.FormattingEnabled = true;
            this.lbx_inscrit.Location = new System.Drawing.Point(268, 125);
            this.lbx_inscrit.Name = "lbx_inscrit";
            this.lbx_inscrit.Size = new System.Drawing.Size(165, 225);
            this.lbx_inscrit.TabIndex = 34;
            this.lbx_inscrit.SelectedIndexChanged += new System.EventHandler(this.lbx_inscrit_SelectedIndexChanged);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(187, 241);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 33;
            this.btn_remove.Text = "<<<";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(187, 211);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = ">>>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cours non inscrit";
            // 
            // lbx_nonInscrit
            // 
            this.lbx_nonInscrit.FormattingEnabled = true;
            this.lbx_nonInscrit.Location = new System.Drawing.Point(16, 125);
            this.lbx_nonInscrit.Name = "lbx_nonInscrit";
            this.lbx_nonInscrit.Size = new System.Drawing.Size(165, 225);
            this.lbx_nonInscrit.TabIndex = 30;
            this.lbx_nonInscrit.SelectedIndexChanged += new System.EventHandler(this.lbx_nonInscrit_SelectedIndexChanged);
            // 
            // tbx_debug
            // 
            this.tbx_debug.BackColor = System.Drawing.SystemColors.Menu;
            this.tbx_debug.Location = new System.Drawing.Point(16, 387);
            this.tbx_debug.Multiline = true;
            this.tbx_debug.Name = "tbx_debug";
            this.tbx_debug.Size = new System.Drawing.Size(417, 23);
            this.tbx_debug.TabIndex = 40;
            this.tbx_debug.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "(Mode connecté)";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(13, 33);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(47, 13);
            this.lbl_year.TabIndex = 42;
            this.lbl_year.Text = "Année : ";
            // 
            // InscriptionEtudiant_C_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 407);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_debug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_etudiants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbx_inscrit);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbx_nonInscrit);
            this.Name = "InscriptionEtudiant_C_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscription | Mise à jour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_etudiants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ListBox lbx_inscrit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx_nonInscrit;
        private System.Windows.Forms.TextBox tbx_debug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_year;
    }
}