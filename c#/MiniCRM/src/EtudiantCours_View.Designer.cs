namespace ECOLE_CRM
{
    partial class EtudiantCours_View
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
            this.components = new System.ComponentModel.Container();
            this.lbl_ddn_Data = new System.Windows.Forms.Label();
            this.lbl_adr_Data = new System.Windows.Forms.Label();
            this.lbl_prenom_Data = new System.Windows.Forms.Label();
            this.lbl_nom_Data = new System.Windows.Forms.Label();
            this.lbl_ddn = new System.Windows.Forms.Label();
            this.lbl_adr = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_etudiantDetailsTitle = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_subTitle = new System.Windows.Forms.Label();
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.coursDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ddn_Data
            // 
            this.lbl_ddn_Data.AutoSize = true;
            this.lbl_ddn_Data.Location = new System.Drawing.Point(137, 102);
            this.lbl_ddn_Data.Name = "lbl_ddn_Data";
            this.lbl_ddn_Data.Size = new System.Drawing.Size(16, 13);
            this.lbl_ddn_Data.TabIndex = 17;
            this.lbl_ddn_Data.Text = "---";
            // 
            // lbl_adr_Data
            // 
            this.lbl_adr_Data.AutoSize = true;
            this.lbl_adr_Data.Location = new System.Drawing.Point(137, 84);
            this.lbl_adr_Data.Name = "lbl_adr_Data";
            this.lbl_adr_Data.Size = new System.Drawing.Size(16, 13);
            this.lbl_adr_Data.TabIndex = 16;
            this.lbl_adr_Data.Text = "---";
            // 
            // lbl_prenom_Data
            // 
            this.lbl_prenom_Data.AutoSize = true;
            this.lbl_prenom_Data.Location = new System.Drawing.Point(137, 67);
            this.lbl_prenom_Data.Name = "lbl_prenom_Data";
            this.lbl_prenom_Data.Size = new System.Drawing.Size(16, 13);
            this.lbl_prenom_Data.TabIndex = 15;
            this.lbl_prenom_Data.Text = "---";
            // 
            // lbl_nom_Data
            // 
            this.lbl_nom_Data.AutoSize = true;
            this.lbl_nom_Data.Location = new System.Drawing.Point(137, 48);
            this.lbl_nom_Data.Name = "lbl_nom_Data";
            this.lbl_nom_Data.Size = new System.Drawing.Size(16, 13);
            this.lbl_nom_Data.TabIndex = 14;
            this.lbl_nom_Data.Text = "---";
            // 
            // lbl_ddn
            // 
            this.lbl_ddn.AutoSize = true;
            this.lbl_ddn.Location = new System.Drawing.Point(13, 102);
            this.lbl_ddn.Name = "lbl_ddn";
            this.lbl_ddn.Size = new System.Drawing.Size(96, 13);
            this.lbl_ddn.TabIndex = 13;
            this.lbl_ddn.Text = "Date de naissance";
            // 
            // lbl_adr
            // 
            this.lbl_adr.AutoSize = true;
            this.lbl_adr.Location = new System.Drawing.Point(13, 84);
            this.lbl_adr.Name = "lbl_adr";
            this.lbl_adr.Size = new System.Drawing.Size(45, 13);
            this.lbl_adr.TabIndex = 12;
            this.lbl_adr.Text = "Adresse";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(13, 67);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom.TabIndex = 11;
            this.lbl_prenom.Text = "Prénom";
            // 
            // lbl_etudiantDetailsTitle
            // 
            this.lbl_etudiantDetailsTitle.AutoSize = true;
            this.lbl_etudiantDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etudiantDetailsTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_etudiantDetailsTitle.Name = "lbl_etudiantDetailsTitle";
            this.lbl_etudiantDetailsTitle.Size = new System.Drawing.Size(194, 22);
            this.lbl_etudiantDetailsTitle.TabIndex = 10;
            this.lbl_etudiantDetailsTitle.Text = "Détails de l\'étudiant n° ";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(13, 48);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 9;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_subTitle
            // 
            this.lbl_subTitle.AutoSize = true;
            this.lbl_subTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTitle.Location = new System.Drawing.Point(12, 145);
            this.lbl_subTitle.Name = "lbl_subTitle";
            this.lbl_subTitle.Size = new System.Drawing.Size(140, 22);
            this.lbl_subTitle.TabIndex = 18;
            this.lbl_subTitle.Text = "Inscrit aux cours";
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursBindingSource
            // 
            this.coursBindingSource.DataMember = "Cours";
            this.coursBindingSource.DataSource = this.ecoleDataSet;
            // 
            // coursTableAdapter
            // 
            this.coursTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursTableAdapter = this.coursTableAdapter;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.ProfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursDataGridView
            // 
            this.coursDataGridView.AllowUserToAddRows = false;
            this.coursDataGridView.AllowUserToDeleteRows = false;
            this.coursDataGridView.AutoGenerateColumns = false;
            this.coursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.coursDataGridView.DataSource = this.coursBindingSource;
            this.coursDataGridView.Location = new System.Drawing.Point(16, 181);
            this.coursDataGridView.Name = "coursDataGridView";
            this.coursDataGridView.ReadOnly = true;
            this.coursDataGridView.Size = new System.Drawing.Size(561, 220);
            this.coursDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCours";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCours";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numProf";
            this.dataGridViewTextBoxColumn3.HeaderText = "numProf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn4.HeaderText = "nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn5.HeaderText = "prénom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // EtudiantCours_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 415);
            this.Controls.Add(this.coursDataGridView);
            this.Controls.Add(this.lbl_subTitle);
            this.Controls.Add(this.lbl_ddn_Data);
            this.Controls.Add(this.lbl_adr_Data);
            this.Controls.Add(this.lbl_prenom_Data);
            this.Controls.Add(this.lbl_nom_Data);
            this.Controls.Add(this.lbl_ddn);
            this.Controls.Add(this.lbl_adr);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_etudiantDetailsTitle);
            this.Controls.Add(this.lbl_nom);
            this.Name = "EtudiantCours_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etudiant ";
            this.Load += new System.EventHandler(this.EtudiantCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ddn_Data;
        private System.Windows.Forms.Label lbl_adr_Data;
        private System.Windows.Forms.Label lbl_prenom_Data;
        private System.Windows.Forms.Label lbl_nom_Data;
        private System.Windows.Forms.Label lbl_ddn;
        private System.Windows.Forms.Label lbl_adr;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_etudiantDetailsTitle;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_subTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter coursTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView coursDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}