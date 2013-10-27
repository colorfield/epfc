namespace ECOLE_CRM
{
    partial class Eudiant_New
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
            this.lbl_lName = new System.Windows.Forms.Label();
            this.lbl_fName = new System.Windows.Forms.Label();
            this.lbl_DDN = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.tbx_lName = new System.Windows.Forms.TextBox();
            this.tbx_fName = new System.Windows.Forms.TextBox();
            this.dtp_birthDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_adress = new System.Windows.Forms.TextBox();
            this.btn_nextStep = new System.Windows.Forms.Button();
            this.lbl_errMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_lName
            // 
            this.lbl_lName.AutoSize = true;
            this.lbl_lName.Location = new System.Drawing.Point(19, 42);
            this.lbl_lName.Name = "lbl_lName";
            this.lbl_lName.Size = new System.Drawing.Size(29, 13);
            this.lbl_lName.TabIndex = 0;
            this.lbl_lName.Text = "Nom";
            // 
            // lbl_fName
            // 
            this.lbl_fName.AutoSize = true;
            this.lbl_fName.Location = new System.Drawing.Point(19, 72);
            this.lbl_fName.Name = "lbl_fName";
            this.lbl_fName.Size = new System.Drawing.Size(43, 13);
            this.lbl_fName.TabIndex = 1;
            this.lbl_fName.Text = "Prénom";
            // 
            // lbl_DDN
            // 
            this.lbl_DDN.AutoSize = true;
            this.lbl_DDN.Location = new System.Drawing.Point(19, 99);
            this.lbl_DDN.Name = "lbl_DDN";
            this.lbl_DDN.Size = new System.Drawing.Size(31, 13);
            this.lbl_DDN.TabIndex = 2;
            this.lbl_DDN.Text = "DDN";
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Location = new System.Drawing.Point(19, 124);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(45, 13);
            this.lbl_adress.TabIndex = 3;
            this.lbl_adress.Text = "Adresse";
            // 
            // tbx_lName
            // 
            this.tbx_lName.Location = new System.Drawing.Point(76, 35);
            this.tbx_lName.Name = "tbx_lName";
            this.tbx_lName.Size = new System.Drawing.Size(201, 20);
            this.tbx_lName.TabIndex = 4;
            this.tbx_lName.Text = "TEST";
            // 
            // tbx_fName
            // 
            this.tbx_fName.Location = new System.Drawing.Point(77, 65);
            this.tbx_fName.Name = "tbx_fName";
            this.tbx_fName.Size = new System.Drawing.Size(200, 20);
            this.tbx_fName.TabIndex = 5;
            this.tbx_fName.Text = "TEST";
            // 
            // dtp_birthDate
            // 
            this.dtp_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birthDate.Location = new System.Drawing.Point(77, 93);
            this.dtp_birthDate.Name = "dtp_birthDate";
            this.dtp_birthDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_birthDate.TabIndex = 6;
            // 
            // tbx_adress
            // 
            this.tbx_adress.Location = new System.Drawing.Point(77, 121);
            this.tbx_adress.Name = "tbx_adress";
            this.tbx_adress.Size = new System.Drawing.Size(200, 20);
            this.tbx_adress.TabIndex = 7;
            // 
            // btn_nextStep
            // 
            this.btn_nextStep.Location = new System.Drawing.Point(178, 179);
            this.btn_nextStep.Name = "btn_nextStep";
            this.btn_nextStep.Size = new System.Drawing.Size(99, 23);
            this.btn_nextStep.TabIndex = 8;
            this.btn_nextStep.Text = "Etape suivante";
            this.btn_nextStep.UseVisualStyleBackColor = true;
            this.btn_nextStep.Click += new System.EventHandler(this.btn_nextStep_Click);
            // 
            // lbl_errMsg
            // 
            this.lbl_errMsg.AutoSize = true;
            this.lbl_errMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_errMsg.Location = new System.Drawing.Point(74, 153);
            this.lbl_errMsg.Name = "lbl_errMsg";
            this.lbl_errMsg.Size = new System.Drawing.Size(0, 13);
            this.lbl_errMsg.TabIndex = 9;
            // 
            // Eudiant_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 225);
            this.Controls.Add(this.lbl_errMsg);
            this.Controls.Add(this.btn_nextStep);
            this.Controls.Add(this.tbx_adress);
            this.Controls.Add(this.dtp_birthDate);
            this.Controls.Add(this.tbx_fName);
            this.Controls.Add(this.tbx_lName);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.lbl_DDN);
            this.Controls.Add(this.lbl_fName);
            this.Controls.Add(this.lbl_lName);
            this.Name = "Eudiant_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table Etudiant | Ajouter un Etudiant (nouvelle inscription)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lName;
        private System.Windows.Forms.Label lbl_fName;
        private System.Windows.Forms.Label lbl_DDN;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.TextBox tbx_lName;
        private System.Windows.Forms.TextBox tbx_fName;
        private System.Windows.Forms.DateTimePicker dtp_birthDate;
        private System.Windows.Forms.TextBox tbx_adress;
        private System.Windows.Forms.Button btn_nextStep;
        private System.Windows.Forms.Label lbl_errMsg;
    }
}