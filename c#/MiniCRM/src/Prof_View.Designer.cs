namespace ECOLE_CRM
{
    partial class Prof_View
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
            this.lbl_etudiantsListDesc = new System.Windows.Forms.Label();
            this.lbl_etudiantsListTitle = new System.Windows.Forms.Label();
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.profBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.ProfTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.dgv_profSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(208, 354);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 16;
            this.btn_init.Text = "Initialiser";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(162, 354);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 23);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "OK";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(15, 356);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(141, 20);
            this.tbx_search.TabIndex = 14;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(12, 337);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(144, 13);
            this.lbl_search.TabIndex = 13;
            this.lbl_search.Text = "Filtrer par nom ou par prénom";
            // 
            // lbl_etudiantsListDesc
            // 
            this.lbl_etudiantsListDesc.AutoSize = true;
            this.lbl_etudiantsListDesc.Location = new System.Drawing.Point(13, 32);
            this.lbl_etudiantsListDesc.Name = "lbl_etudiantsListDesc";
            this.lbl_etudiantsListDesc.Size = new System.Drawing.Size(256, 13);
            this.lbl_etudiantsListDesc.TabIndex = 12;
            this.lbl_etudiantsListDesc.Text = "Cliquer sur un prof pour obtenir une liste de ses cours";
            // 
            // lbl_etudiantsListTitle
            // 
            this.lbl_etudiantsListTitle.AutoSize = true;
            this.lbl_etudiantsListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etudiantsListTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_etudiantsListTitle.Name = "lbl_etudiantsListTitle";
            this.lbl_etudiantsListTitle.Size = new System.Drawing.Size(128, 20);
            this.lbl_etudiantsListTitle.TabIndex = 11;
            this.lbl_etudiantsListTitle.Text = "Liste des profs";
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profBindingSource
            // 
            this.profBindingSource.DataMember = "Prof";
            this.profBindingSource.DataSource = this.ecoleDataSet;
            // 
            // profTableAdapter
            // 
            this.profTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.ProfTableAdapter = this.profTableAdapter;
            this.tableAdapterManager.UpdateOrder = ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgv_profSelect
            // 
            this.dgv_profSelect.AutoGenerateColumns = false;
            this.dgv_profSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_profSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_profSelect.DataSource = this.profBindingSource;
            this.dgv_profSelect.Location = new System.Drawing.Point(16, 65);
            this.dgv_profSelect.Name = "dgv_profSelect";
            this.dgv_profSelect.Size = new System.Drawing.Size(370, 261);
            this.dgv_profSelect.TabIndex = 17;
            this.dgv_profSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_profSelect_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProf";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProf";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Prof_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 389);
            this.Controls.Add(this.dgv_profSelect);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_etudiantsListDesc);
            this.Controls.Add(this.lbl_etudiantsListTitle);
            this.Name = "Prof_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prof | Consultation";
            this.Load += new System.EventHandler(this.Prof_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_etudiantsListDesc;
        private System.Windows.Forms.Label lbl_etudiantsListTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource profBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.ProfTableAdapter profTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_profSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}