namespace ECOLE_CRM
{
    partial class CoursEtudiant_View
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
            this.lbl_etudiantDDN_Data = new System.Windows.Forms.Label();
            this.lbl_etudiantAdresse_Data = new System.Windows.Forms.Label();
            this.lbl_etudiantAdresse = new System.Windows.Forms.Label();
            this.lbl_etudiantDDN = new System.Windows.Forms.Label();
            this.lbl_etudiantsListDesc = new System.Windows.Forms.Label();
            this.lbl_etudiantsListTitle = new System.Windows.Forms.Label();
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.dgv_etudiantSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiantSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_etudiantDDN_Data
            // 
            this.lbl_etudiantDDN_Data.AutoSize = true;
            this.lbl_etudiantDDN_Data.Location = new System.Drawing.Point(120, 325);
            this.lbl_etudiantDDN_Data.Name = "lbl_etudiantDDN_Data";
            this.lbl_etudiantDDN_Data.Size = new System.Drawing.Size(16, 13);
            this.lbl_etudiantDDN_Data.TabIndex = 15;
            this.lbl_etudiantDDN_Data.Text = "---";
            // 
            // lbl_etudiantAdresse_Data
            // 
            this.lbl_etudiantAdresse_Data.AutoSize = true;
            this.lbl_etudiantAdresse_Data.Location = new System.Drawing.Point(120, 306);
            this.lbl_etudiantAdresse_Data.Name = "lbl_etudiantAdresse_Data";
            this.lbl_etudiantAdresse_Data.Size = new System.Drawing.Size(16, 13);
            this.lbl_etudiantAdresse_Data.TabIndex = 14;
            this.lbl_etudiantAdresse_Data.Text = "---";
            // 
            // lbl_etudiantAdresse
            // 
            this.lbl_etudiantAdresse.AutoSize = true;
            this.lbl_etudiantAdresse.Location = new System.Drawing.Point(9, 304);
            this.lbl_etudiantAdresse.Name = "lbl_etudiantAdresse";
            this.lbl_etudiantAdresse.Size = new System.Drawing.Size(45, 13);
            this.lbl_etudiantAdresse.TabIndex = 13;
            this.lbl_etudiantAdresse.Text = "Adresse";
            // 
            // lbl_etudiantDDN
            // 
            this.lbl_etudiantDDN.AutoSize = true;
            this.lbl_etudiantDDN.Location = new System.Drawing.Point(9, 325);
            this.lbl_etudiantDDN.Name = "lbl_etudiantDDN";
            this.lbl_etudiantDDN.Size = new System.Drawing.Size(96, 13);
            this.lbl_etudiantDDN.TabIndex = 12;
            this.lbl_etudiantDDN.Text = "Date de naissance";
            // 
            // lbl_etudiantsListDesc
            // 
            this.lbl_etudiantsListDesc.AutoSize = true;
            this.lbl_etudiantsListDesc.Location = new System.Drawing.Point(9, 36);
            this.lbl_etudiantsListDesc.Name = "lbl_etudiantsListDesc";
            this.lbl_etudiantsListDesc.Size = new System.Drawing.Size(220, 13);
            this.lbl_etudiantsListDesc.TabIndex = 11;
            this.lbl_etudiantsListDesc.Text = "Cliquer sur un étudiant pour obtenir les détails";
            // 
            // lbl_etudiantsListTitle
            // 
            this.lbl_etudiantsListTitle.AutoSize = true;
            this.lbl_etudiantsListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etudiantsListTitle.Location = new System.Drawing.Point(8, 13);
            this.lbl_etudiantsListTitle.Name = "lbl_etudiantsListTitle";
            this.lbl_etudiantsListTitle.Size = new System.Drawing.Size(271, 20);
            this.lbl_etudiantsListTitle.TabIndex = 10;
            this.lbl_etudiantsListTitle.Text = "Liste des étudiants du cours de  ";
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "Etudiant";
            this.etudiantBindingSource.DataSource = this.ecoleDataSet;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = this.etudiantTableAdapter;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.ProfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgv_etudiantSelect
            // 
            this.dgv_etudiantSelect.AllowUserToAddRows = false;
            this.dgv_etudiantSelect.AllowUserToDeleteRows = false;
            this.dgv_etudiantSelect.AutoGenerateColumns = false;
            this.dgv_etudiantSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_etudiantSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_etudiantSelect.DataSource = this.etudiantBindingSource;
            this.dgv_etudiantSelect.Location = new System.Drawing.Point(12, 62);
            this.dgv_etudiantSelect.Name = "dgv_etudiantSelect";
            this.dgv_etudiantSelect.ReadOnly = true;
            this.dgv_etudiantSelect.Size = new System.Drawing.Size(349, 227);
            this.dgv_etudiantSelect.TabIndex = 16;
            this.dgv_etudiantSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_etudiantSelect_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEtud";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEtud";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // CoursEtudiant_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 354);
            this.Controls.Add(this.dgv_etudiantSelect);
            this.Controls.Add(this.lbl_etudiantDDN_Data);
            this.Controls.Add(this.lbl_etudiantAdresse_Data);
            this.Controls.Add(this.lbl_etudiantAdresse);
            this.Controls.Add(this.lbl_etudiantDDN);
            this.Controls.Add(this.lbl_etudiantsListDesc);
            this.Controls.Add(this.lbl_etudiantsListTitle);
            this.Name = "CoursEtudiant_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CoursEtudiant_View";
            this.Load += new System.EventHandler(this.CoursEtudiantView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiantSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_etudiantDDN_Data;
        private System.Windows.Forms.Label lbl_etudiantAdresse_Data;
        private System.Windows.Forms.Label lbl_etudiantAdresse;
        private System.Windows.Forms.Label lbl_etudiantDDN;
        private System.Windows.Forms.Label lbl_etudiantsListDesc;
        private System.Windows.Forms.Label lbl_etudiantsListTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_etudiantSelect;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter coursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}