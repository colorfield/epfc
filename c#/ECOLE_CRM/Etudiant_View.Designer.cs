namespace ECOLE_CRM
{
    partial class Etudiant_View
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.lbl_etudiantListDesc = new System.Windows.Forms.Label();
            this.lbl_coursListTitle = new System.Windows.Forms.Label();
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.dgv_etudiantSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiantSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(195, 391);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 24);
            this.btn_init.TabIndex = 14;
            this.btn_init.Text = "Initialiser";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtrer par nom ou par prénom";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(157, 391);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 24);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "OK";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(17, 393);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(134, 20);
            this.tbx_search.TabIndex = 11;
            // 
            // lbl_etudiantListDesc
            // 
            this.lbl_etudiantListDesc.AutoSize = true;
            this.lbl_etudiantListDesc.Location = new System.Drawing.Point(13, 39);
            this.lbl_etudiantListDesc.Name = "lbl_etudiantListDesc";
            this.lbl_etudiantListDesc.Size = new System.Drawing.Size(412, 13);
            this.lbl_etudiantListDesc.TabIndex = 10;
            this.lbl_etudiantListDesc.Text = "Cliquer sur un étudiant pour obtenir ses détails ainsi que les cours auxquels il " +
                "est inscrit";
            // 
            // lbl_coursListTitle
            // 
            this.lbl_coursListTitle.AutoSize = true;
            this.lbl_coursListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursListTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_coursListTitle.Name = "lbl_coursListTitle";
            this.lbl_coursListTitle.Size = new System.Drawing.Size(162, 20);
            this.lbl_coursListTitle.TabIndex = 9;
            this.lbl_coursListTitle.Text = "Liste des étudiants";
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
            this.dgv_etudiantSelect.AutoGenerateColumns = false;
            this.dgv_etudiantSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_etudiantSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_etudiantSelect.DataSource = this.etudiantBindingSource;
            this.dgv_etudiantSelect.Location = new System.Drawing.Point(16, 73);
            this.dgv_etudiantSelect.Name = "dgv_etudiantSelect";
            this.dgv_etudiantSelect.Size = new System.Drawing.Size(558, 293);
            this.dgv_etudiantSelect.TabIndex = 15;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ddn";
            this.dataGridViewTextBoxColumn4.HeaderText = "ddn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "adr";
            this.dataGridViewTextBoxColumn5.HeaderText = "adr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Etudiant_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 427);
            this.Controls.Add(this.dgv_etudiantSelect);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.lbl_etudiantListDesc);
            this.Controls.Add(this.lbl_coursListTitle);
            this.Name = "Etudiant_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etudiant | Consultation";
            this.Load += new System.EventHandler(this.Etudiant_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiantSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label lbl_etudiantListDesc;
        private System.Windows.Forms.Label lbl_coursListTitle;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_etudiantSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}