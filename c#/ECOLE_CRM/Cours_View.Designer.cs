namespace ECOLE_CRM
{
    partial class Cours_View
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
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_coursListDesc = new System.Windows.Forms.Label();
            this.lbl_coursListTitle = new System.Windows.Forms.Label();
            this.dgv_coursSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.coursTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(186, 306);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 24);
            this.btn_init.TabIndex = 12;
            this.btn_init.Text = "Initialiser";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(146, 306);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(34, 24);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "OK";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(12, 310);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(128, 20);
            this.tbx_search.TabIndex = 10;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(10, 293);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(79, 13);
            this.lbl_search.TabIndex = 9;
            this.lbl_search.Text = "Filtrer par cours";
            // 
            // lbl_coursListDesc
            // 
            this.lbl_coursListDesc.AutoSize = true;
            this.lbl_coursListDesc.Location = new System.Drawing.Point(12, 34);
            this.lbl_coursListDesc.Name = "lbl_coursListDesc";
            this.lbl_coursListDesc.Size = new System.Drawing.Size(302, 13);
            this.lbl_coursListDesc.TabIndex = 8;
            this.lbl_coursListDesc.Text = "Cliquer sur un cours pour obtenir une liste des étudiants inscrits";
            // 
            // lbl_coursListTitle
            // 
            this.lbl_coursListTitle.AutoSize = true;
            this.lbl_coursListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursListTitle.Location = new System.Drawing.Point(9, 10);
            this.lbl_coursListTitle.Name = "lbl_coursListTitle";
            this.lbl_coursListTitle.Size = new System.Drawing.Size(131, 20);
            this.lbl_coursListTitle.TabIndex = 7;
            this.lbl_coursListTitle.Text = "Liste des cours";
            // 
            // dgv_coursSelect
            // 
            this.dgv_coursSelect.AutoGenerateColumns = false;
            this.dgv_coursSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coursSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_coursSelect.DataSource = this.coursBindingSource;
            this.dgv_coursSelect.Location = new System.Drawing.Point(15, 60);
            this.dgv_coursSelect.Name = "dgv_coursSelect";
            this.dgv_coursSelect.Size = new System.Drawing.Size(569, 220);
            this.dgv_coursSelect.TabIndex = 13;
            this.dgv_coursSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_coursSelect_CellClick);
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numProf";
            this.dataGridViewTextBoxColumn3.HeaderText = "numProf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn4.HeaderText = "nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn5.HeaderText = "prénom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // coursBindingSource
            // 
            this.coursBindingSource.DataMember = "Cours";
            this.coursBindingSource.DataSource = this.ecoleDataSet;
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Cours_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 350);
            this.Controls.Add(this.dgv_coursSelect);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_coursListDesc);
            this.Controls.Add(this.lbl_coursListTitle);
            this.Name = "Cours_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cours | Consultation";
            this.Load += new System.EventHandler(this.Cours_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_coursListDesc;
        private System.Windows.Forms.Label lbl_coursListTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.CoursTableAdapter coursTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_coursSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}