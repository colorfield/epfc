namespace ECOLE_CRM
{
    partial class ProfCours_View
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
            this.lbl_coursListDesc = new System.Windows.Forms.Label();
            this.lbl_coursListTitle = new System.Windows.Forms.Label();
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.dgv_coursProf = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursProf)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_coursListDesc
            // 
            this.lbl_coursListDesc.AutoSize = true;
            this.lbl_coursListDesc.Location = new System.Drawing.Point(13, 32);
            this.lbl_coursListDesc.Name = "lbl_coursListDesc";
            this.lbl_coursListDesc.Size = new System.Drawing.Size(357, 13);
            this.lbl_coursListDesc.TabIndex = 8;
            this.lbl_coursListDesc.Text = "Cliquer sur un cours pour obtenir les étudiants ayant ce cours avec ce prof";
            // 
            // lbl_coursListTitle
            // 
            this.lbl_coursListTitle.AutoSize = true;
            this.lbl_coursListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursListTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_coursListTitle.Name = "lbl_coursListTitle";
            this.lbl_coursListTitle.Size = new System.Drawing.Size(198, 20);
            this.lbl_coursListTitle.TabIndex = 7;
            this.lbl_coursListTitle.Text = "Liste des cours du prof ";
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
            // dgv_coursProf
            // 
            this.dgv_coursProf.AllowUserToAddRows = false;
            this.dgv_coursProf.AllowUserToDeleteRows = false;
            this.dgv_coursProf.AutoGenerateColumns = false;
            this.dgv_coursProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coursProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_coursProf.DataSource = this.coursBindingSource;
            this.dgv_coursProf.Location = new System.Drawing.Point(16, 62);
            this.dgv_coursProf.Name = "dgv_coursProf";
            this.dgv_coursProf.ReadOnly = true;
            this.dgv_coursProf.Size = new System.Drawing.Size(276, 245);
            this.dgv_coursProf.TabIndex = 9;
            this.dgv_coursProf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_coursProf_CellClick);
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
            // ProfCours_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 319);
            this.Controls.Add(this.dgv_coursProf);
            this.Controls.Add(this.lbl_coursListDesc);
            this.Controls.Add(this.lbl_coursListTitle);
            this.Name = "ProfCours_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cours du professeur n° ";
            this.Load += new System.EventHandler(this.ProfCoursView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_coursListDesc;
        private System.Windows.Forms.Label lbl_coursListTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter coursTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_coursProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}