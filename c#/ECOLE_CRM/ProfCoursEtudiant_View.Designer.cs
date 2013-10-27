namespace ECOLE_CRM
{
    partial class ProfCoursEtudiant_View
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
            this.lbl_etudiantsListTitle = new System.Windows.Forms.Label();
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.etudiantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_etudiantsListTitle
            // 
            this.lbl_etudiantsListTitle.AutoSize = true;
            this.lbl_etudiantsListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etudiantsListTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_etudiantsListTitle.Name = "lbl_etudiantsListTitle";
            this.lbl_etudiantsListTitle.Size = new System.Drawing.Size(241, 20);
            this.lbl_etudiantsListTitle.TabIndex = 7;
            this.lbl_etudiantsListTitle.Text = "Liste des étudiants du cours ";
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
            // etudiantDataGridView
            // 
            this.etudiantDataGridView.AllowUserToAddRows = false;
            this.etudiantDataGridView.AllowUserToDeleteRows = false;
            this.etudiantDataGridView.AutoGenerateColumns = false;
            this.etudiantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etudiantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.etudiantDataGridView.DataSource = this.etudiantBindingSource;
            this.etudiantDataGridView.Location = new System.Drawing.Point(16, 46);
            this.etudiantDataGridView.Name = "etudiantDataGridView";
            this.etudiantDataGridView.ReadOnly = true;
            this.etudiantDataGridView.Size = new System.Drawing.Size(501, 242);
            this.etudiantDataGridView.TabIndex = 8;
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
            // ProfCoursEtudiant_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 300);
            this.Controls.Add(this.etudiantDataGridView);
            this.Controls.Add(this.lbl_etudiantsListTitle);
            this.Name = "ProfCoursEtudiant_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etudiants du Cours n° ";
            this.Load += new System.EventHandler(this.ProfCoursEtudiant_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_etudiantsListTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView etudiantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}