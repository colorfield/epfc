namespace ECOLE_CRM
{
    partial class InscriptionNewEtudiant_C_Update
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_etudiant = new System.Windows.Forms.Label();
            this.tbx_debug = new System.Windows.Forms.TextBox();
            this.btn_inscrire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(301, 18);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sélectionner des Cours pour l\'étudiant ";
            // 
            // lbl_etudiant
            // 
            this.lbl_etudiant.AutoSize = true;
            this.lbl_etudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etudiant.Location = new System.Drawing.Point(13, 35);
            this.lbl_etudiant.Name = "lbl_etudiant";
            this.lbl_etudiant.Size = new System.Drawing.Size(24, 20);
            this.lbl_etudiant.TabIndex = 1;
            this.lbl_etudiant.Text = "---";
            // 
            // tbx_debug
            // 
            this.tbx_debug.Location = new System.Drawing.Point(13, 278);
            this.tbx_debug.Multiline = true;
            this.tbx_debug.Name = "tbx_debug";
            this.tbx_debug.Size = new System.Drawing.Size(615, 59);
            this.tbx_debug.TabIndex = 2;
            // 
            // btn_inscrire
            // 
            this.btn_inscrire.Location = new System.Drawing.Point(494, 249);
            this.btn_inscrire.Name = "btn_inscrire";
            this.btn_inscrire.Size = new System.Drawing.Size(133, 23);
            this.btn_inscrire.TabIndex = 3;
            this.btn_inscrire.Text = "Inscrire";
            this.btn_inscrire.UseVisualStyleBackColor = true;
            this.btn_inscrire.Click += new System.EventHandler(this.btn_inscrire_Click);
            // 
            // InscriptionNewEtudiant_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 349);
            this.Controls.Add(this.btn_inscrire);
            this.Controls.Add(this.tbx_debug);
            this.Controls.Add(this.lbl_etudiant);
            this.Controls.Add(this.lbl_title);
            this.Name = "InscriptionNewEtudiant_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscription d\'un nouvel Etudiant | Sélection des Cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_etudiant;
        private System.Windows.Forms.TextBox tbx_debug;
        private System.Windows.Forms.Button btn_inscrire;
    }
}