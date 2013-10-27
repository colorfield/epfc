namespace ECOLE_CRM
{
    partial class Splash
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
            this.gbx_mode = new System.Windows.Forms.GroupBox();
            this.rbn_updateMode = new System.Windows.Forms.RadioButton();
            this.rbn_viewMode = new System.Windows.Forms.RadioButton();
            this.lbl_titleTable = new System.Windows.Forms.Label();
            this.cbx_table = new System.Windows.Forms.ComboBox();
            this.lbl_titleInscription = new System.Windows.Forms.Label();
            this.btn_singleValidate = new System.Windows.Forms.Button();
            this.gbx_isNewStudent = new System.Windows.Forms.GroupBox();
            this.rbn_isNotNew = new System.Windows.Forms.RadioButton();
            this.rbn_isNew = new System.Windows.Forms.RadioButton();
            this.btn_inscriptionValidate = new System.Windows.Forms.Button();
            this.btn_viewInscription = new System.Windows.Forms.Button();
            this.btn_inscrUpdateNC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_inscriptionUpdateNC_ListBox = new System.Windows.Forms.Button();
            this.btn_inscriptionUpdateNC_DataGrid = new System.Windows.Forms.Button();
            this.btn_updateTest1 = new System.Windows.Forms.Button();
            this.btn_updateTest2 = new System.Windows.Forms.Button();
            this.gbx_mode.SuspendLayout();
            this.gbx_isNewStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_mode
            // 
            this.gbx_mode.Controls.Add(this.rbn_updateMode);
            this.gbx_mode.Controls.Add(this.rbn_viewMode);
            this.gbx_mode.Location = new System.Drawing.Point(12, 76);
            this.gbx_mode.Name = "gbx_mode";
            this.gbx_mode.Size = new System.Drawing.Size(200, 70);
            this.gbx_mode.TabIndex = 1;
            this.gbx_mode.TabStop = false;
            this.gbx_mode.Text = "Sélectionner un mode";
            // 
            // rbn_updateMode
            // 
            this.rbn_updateMode.AutoSize = true;
            this.rbn_updateMode.Location = new System.Drawing.Point(10, 42);
            this.rbn_updateMode.Name = "rbn_updateMode";
            this.rbn_updateMode.Size = new System.Drawing.Size(76, 17);
            this.rbn_updateMode.TabIndex = 1;
            this.rbn_updateMode.Text = "Mise à jour";
            this.rbn_updateMode.UseVisualStyleBackColor = true;
            // 
            // rbn_viewMode
            // 
            this.rbn_viewMode.AutoSize = true;
            this.rbn_viewMode.Checked = true;
            this.rbn_viewMode.Location = new System.Drawing.Point(10, 19);
            this.rbn_viewMode.Name = "rbn_viewMode";
            this.rbn_viewMode.Size = new System.Drawing.Size(83, 17);
            this.rbn_viewMode.TabIndex = 0;
            this.rbn_viewMode.TabStop = true;
            this.rbn_viewMode.Text = "Consultation";
            this.rbn_viewMode.UseVisualStyleBackColor = true;
            // 
            // lbl_titleTable
            // 
            this.lbl_titleTable.AutoSize = true;
            this.lbl_titleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleTable.Location = new System.Drawing.Point(8, 13);
            this.lbl_titleTable.Name = "lbl_titleTable";
            this.lbl_titleTable.Size = new System.Drawing.Size(207, 22);
            this.lbl_titleTable.TabIndex = 2;
            this.lbl_titleTable.Text = "Opérations sur une table";
            // 
            // cbx_table
            // 
            this.cbx_table.FormattingEnabled = true;
            this.cbx_table.Items.AddRange(new object[] {
            "Etudiant",
            "Prof",
            "Cours"});
            this.cbx_table.Location = new System.Drawing.Point(12, 49);
            this.cbx_table.Name = "cbx_table";
            this.cbx_table.Size = new System.Drawing.Size(200, 21);
            this.cbx_table.TabIndex = 3;
            // 
            // lbl_titleInscription
            // 
            this.lbl_titleInscription.AutoSize = true;
            this.lbl_titleInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleInscription.Location = new System.Drawing.Point(8, 214);
            this.lbl_titleInscription.Name = "lbl_titleInscription";
            this.lbl_titleInscription.Size = new System.Drawing.Size(201, 22);
            this.lbl_titleInscription.TabIndex = 4;
            this.lbl_titleInscription.Text = "Gestion des inscriptions";
            // 
            // btn_singleValidate
            // 
            this.btn_singleValidate.Location = new System.Drawing.Point(120, 153);
            this.btn_singleValidate.Name = "btn_singleValidate";
            this.btn_singleValidate.Size = new System.Drawing.Size(92, 23);
            this.btn_singleValidate.TabIndex = 5;
            this.btn_singleValidate.Text = "Valider";
            this.btn_singleValidate.UseVisualStyleBackColor = true;
            this.btn_singleValidate.Click += new System.EventHandler(this.newWindow);
            // 
            // gbx_isNewStudent
            // 
            this.gbx_isNewStudent.Controls.Add(this.rbn_isNotNew);
            this.gbx_isNewStudent.Controls.Add(this.rbn_isNew);
            this.gbx_isNewStudent.Location = new System.Drawing.Point(12, 267);
            this.gbx_isNewStudent.Name = "gbx_isNewStudent";
            this.gbx_isNewStudent.Size = new System.Drawing.Size(200, 69);
            this.gbx_isNewStudent.TabIndex = 2;
            this.gbx_isNewStudent.TabStop = false;
            this.gbx_isNewStudent.Text = "Nouvel étudiant ?";
            // 
            // rbn_isNotNew
            // 
            this.rbn_isNotNew.AutoSize = true;
            this.rbn_isNotNew.Location = new System.Drawing.Point(9, 42);
            this.rbn_isNotNew.Name = "rbn_isNotNew";
            this.rbn_isNotNew.Size = new System.Drawing.Size(45, 17);
            this.rbn_isNotNew.TabIndex = 1;
            this.rbn_isNotNew.Text = "Non";
            this.rbn_isNotNew.UseVisualStyleBackColor = true;
            // 
            // rbn_isNew
            // 
            this.rbn_isNew.AutoSize = true;
            this.rbn_isNew.Checked = true;
            this.rbn_isNew.Location = new System.Drawing.Point(9, 19);
            this.rbn_isNew.Name = "rbn_isNew";
            this.rbn_isNew.Size = new System.Drawing.Size(41, 17);
            this.rbn_isNew.TabIndex = 0;
            this.rbn_isNew.TabStop = true;
            this.rbn_isNew.Text = "Oui";
            this.rbn_isNew.UseVisualStyleBackColor = true;
            // 
            // btn_inscriptionValidate
            // 
            this.btn_inscriptionValidate.Location = new System.Drawing.Point(120, 342);
            this.btn_inscriptionValidate.Name = "btn_inscriptionValidate";
            this.btn_inscriptionValidate.Size = new System.Drawing.Size(92, 23);
            this.btn_inscriptionValidate.TabIndex = 6;
            this.btn_inscriptionValidate.Text = "Valider";
            this.btn_inscriptionValidate.UseVisualStyleBackColor = true;
            this.btn_inscriptionValidate.Click += new System.EventHandler(this.newWindow);
            // 
            // btn_viewInscription
            // 
            this.btn_viewInscription.Location = new System.Drawing.Point(268, 272);
            this.btn_viewInscription.Name = "btn_viewInscription";
            this.btn_viewInscription.Size = new System.Drawing.Size(92, 23);
            this.btn_viewInscription.TabIndex = 8;
            this.btn_viewInscription.Text = "Visualiser";
            this.btn_viewInscription.UseVisualStyleBackColor = true;
            this.btn_viewInscription.Click += new System.EventHandler(this.newWindow);
            // 
            // btn_inscrUpdateNC
            // 
            this.btn_inscrUpdateNC.Location = new System.Drawing.Point(366, 272);
            this.btn_inscrUpdateNC.Name = "btn_inscrUpdateNC";
            this.btn_inscrUpdateNC.Size = new System.Drawing.Size(102, 23);
            this.btn_inscrUpdateNC.TabIndex = 9;
            this.btn_inscrUpdateNC.Text = "Table Inscription";
            this.btn_inscrUpdateNC.UseVisualStyleBackColor = true;
            this.btn_inscrUpdateNC.Click += new System.EventHandler(this.newWindow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mode connecté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mode non connecté";
            // 
            // btn_inscriptionUpdateNC_ListBox
            // 
            this.btn_inscriptionUpdateNC_ListBox.Location = new System.Drawing.Point(268, 301);
            this.btn_inscriptionUpdateNC_ListBox.Name = "btn_inscriptionUpdateNC_ListBox";
            this.btn_inscriptionUpdateNC_ListBox.Size = new System.Drawing.Size(200, 23);
            this.btn_inscriptionUpdateNC_ListBox.TabIndex = 13;
            this.btn_inscriptionUpdateNC_ListBox.Text = "Modifier par ListBox";
            this.btn_inscriptionUpdateNC_ListBox.UseVisualStyleBackColor = true;
            this.btn_inscriptionUpdateNC_ListBox.Click += new System.EventHandler(this.newWindow);
            // 
            // btn_inscriptionUpdateNC_DataGrid
            // 
            this.btn_inscriptionUpdateNC_DataGrid.Location = new System.Drawing.Point(268, 330);
            this.btn_inscriptionUpdateNC_DataGrid.Name = "btn_inscriptionUpdateNC_DataGrid";
            this.btn_inscriptionUpdateNC_DataGrid.Size = new System.Drawing.Size(200, 23);
            this.btn_inscriptionUpdateNC_DataGrid.TabIndex = 14;
            this.btn_inscriptionUpdateNC_DataGrid.Text = "Modifier par DataGridView";
            this.btn_inscriptionUpdateNC_DataGrid.UseVisualStyleBackColor = true;
            this.btn_inscriptionUpdateNC_DataGrid.Click += new System.EventHandler(this.newWindow);
            // 
            // btn_updateTest1
            // 
            this.btn_updateTest1.Location = new System.Drawing.Point(268, 243);
            this.btn_updateTest1.Name = "btn_updateTest1";
            this.btn_updateTest1.Size = new System.Drawing.Size(92, 23);
            this.btn_updateTest1.TabIndex = 15;
            this.btn_updateTest1.Text = "Update Test1";
            this.btn_updateTest1.UseVisualStyleBackColor = true;
            this.btn_updateTest1.Click += new System.EventHandler(this.newWindow);
            // 
            // btn_updateTest2
            // 
            this.btn_updateTest2.Location = new System.Drawing.Point(366, 243);
            this.btn_updateTest2.Name = "btn_updateTest2";
            this.btn_updateTest2.Size = new System.Drawing.Size(102, 23);
            this.btn_updateTest2.TabIndex = 16;
            this.btn_updateTest2.Text = "Update Test2";
            this.btn_updateTest2.UseVisualStyleBackColor = true;
            this.btn_updateTest2.Click += new System.EventHandler(this.newWindow);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 378);
            this.Controls.Add(this.btn_updateTest2);
            this.Controls.Add(this.btn_updateTest1);
            this.Controls.Add(this.btn_inscriptionUpdateNC_DataGrid);
            this.Controls.Add(this.btn_inscriptionUpdateNC_ListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_inscrUpdateNC);
            this.Controls.Add(this.btn_viewInscription);
            this.Controls.Add(this.btn_inscriptionValidate);
            this.Controls.Add(this.gbx_isNewStudent);
            this.Controls.Add(this.btn_singleValidate);
            this.Controls.Add(this.lbl_titleInscription);
            this.Controls.Add(this.cbx_table);
            this.Controls.Add(this.lbl_titleTable);
            this.Controls.Add(this.gbx_mode);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecole | CRM";
            this.gbx_mode.ResumeLayout(false);
            this.gbx_mode.PerformLayout();
            this.gbx_isNewStudent.ResumeLayout(false);
            this.gbx_isNewStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_mode;
        private System.Windows.Forms.RadioButton rbn_updateMode;
        private System.Windows.Forms.RadioButton rbn_viewMode;
        private System.Windows.Forms.Label lbl_titleTable;
        private System.Windows.Forms.ComboBox cbx_table;
        private System.Windows.Forms.Label lbl_titleInscription;
        private System.Windows.Forms.Button btn_singleValidate;
        private System.Windows.Forms.GroupBox gbx_isNewStudent;
        private System.Windows.Forms.RadioButton rbn_isNotNew;
        private System.Windows.Forms.RadioButton rbn_isNew;
        private System.Windows.Forms.Button btn_inscriptionValidate;
        private System.Windows.Forms.Button btn_viewInscription;
        private System.Windows.Forms.Button btn_inscrUpdateNC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_inscriptionUpdateNC_ListBox;
        private System.Windows.Forms.Button btn_inscriptionUpdateNC_DataGrid;
        private System.Windows.Forms.Button btn_updateTest1;
        private System.Windows.Forms.Button btn_updateTest2;
    }
}

