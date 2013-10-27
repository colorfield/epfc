namespace ECOLE_CRM
{
    partial class InscriptionEtudiant_NC_DataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.inscriptionNonCoursProfEtudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_coursInscrit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantCoursInscritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.dgv_coursNonInscrit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.année = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantCoursNonInscritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tbx_debug = new System.Windows.Forms.TextBox();
            this.cbx_etudiantYear = new System.Windows.Forms.ComboBox();
            this.cbx_etudiant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.etudiantCoursInscritTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantCoursInscritTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.etudiantCoursNonInscritTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantCoursNonInscritTableAdapter();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionNonCoursProfEtudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantCoursInscritBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursNonInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantCoursNonInscritBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Inscription d\'un étudiant à des Cours";
            // 
            // inscriptionNonCoursProfEtudiantBindingSource
            // 
            this.inscriptionNonCoursProfEtudiantBindingSource.DataMember = "InscriptionNonCoursProfEtudiant";
            // 
            // dgv_coursInscrit
            // 
            this.dgv_coursInscrit.AutoGenerateColumns = false;
            this.dgv_coursInscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coursInscrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_coursInscrit.DataSource = this.etudiantCoursInscritBindingSource;
            this.dgv_coursInscrit.Location = new System.Drawing.Point(655, 117);
            this.dgv_coursInscrit.Name = "dgv_coursInscrit";
            this.dgv_coursInscrit.ReadOnly = true;
            this.dgv_coursInscrit.Size = new System.Drawing.Size(562, 220);
            this.dgv_coursInscrit.TabIndex = 39;
            this.dgv_coursInscrit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getDGVRowData);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "année";
            this.dataGridViewTextBoxColumn2.HeaderText = "Année";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prénom Prof";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nom Prof";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // etudiantCoursInscritBindingSource
            // 
            this.etudiantCoursInscritBindingSource.DataMember = "EtudiantCoursInscrit";
            this.etudiantCoursInscritBindingSource.DataSource = this.ecoleDataSet;
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.EnforceConstraints = false;
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_coursNonInscrit
            // 
            this.dgv_coursNonInscrit.AutoGenerateColumns = false;
            this.dgv_coursNonInscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coursNonInscrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.année,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgv_coursNonInscrit.DataSource = this.etudiantCoursNonInscritBindingSource;
            this.dgv_coursNonInscrit.Location = new System.Drawing.Point(12, 117);
            this.dgv_coursNonInscrit.Name = "dgv_coursNonInscrit";
            this.dgv_coursNonInscrit.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_coursNonInscrit.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_coursNonInscrit.Size = new System.Drawing.Size(560, 220);
            this.dgv_coursNonInscrit.TabIndex = 39;
            this.dgv_coursNonInscrit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getDGVRowData);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idCours";
            this.dataGridViewTextBoxColumn6.HeaderText = "idCours";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // année
            // 
            this.année.DataPropertyName = "année";
            this.année.HeaderText = "Année";
            this.année.Name = "année";
            this.année.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prénom";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prénom Prof";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nom Prof";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // etudiantCoursNonInscritBindingSource
            // 
            this.etudiantCoursNonInscritBindingSource.DataMember = "EtudiantCoursNonInscrit";
            this.etudiantCoursNonInscritBindingSource.DataSource = this.ecoleDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cours inscrit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cours non inscrit";
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(534, 343);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(157, 23);
            this.btn_modify.TabIndex = 42;
            this.btn_modify.Text = "Modifier les inscriptions";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(578, 218);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(71, 23);
            this.btn_add.TabIndex = 43;
            this.btn_add.Text = ">>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(578, 247);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(71, 23);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "<<";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tbx_debug
            // 
            this.tbx_debug.Location = new System.Drawing.Point(655, 11);
            this.tbx_debug.Multiline = true;
            this.tbx_debug.Name = "tbx_debug";
            this.tbx_debug.Size = new System.Drawing.Size(562, 83);
            this.tbx_debug.TabIndex = 45;
            // 
            // cbx_etudiantYear
            // 
            this.cbx_etudiantYear.FormattingEnabled = true;
            this.cbx_etudiantYear.Location = new System.Drawing.Point(186, 50);
            this.cbx_etudiantYear.Name = "cbx_etudiantYear";
            this.cbx_etudiantYear.Size = new System.Drawing.Size(154, 21);
            this.cbx_etudiantYear.TabIndex = 46;
            this.cbx_etudiantYear.Text = "Sélectionner l\'année";
            this.cbx_etudiantYear.SelectedValueChanged += new System.EventHandler(this.cbx_etudiantYear_SelectedValueChanged);
            // 
            // cbx_etudiant
            // 
            this.cbx_etudiant.FormattingEnabled = true;
            this.cbx_etudiant.Location = new System.Drawing.Point(12, 50);
            this.cbx_etudiant.Name = "cbx_etudiant";
            this.cbx_etudiant.Size = new System.Drawing.Size(161, 21);
            this.cbx_etudiant.TabIndex = 47;
            this.cbx_etudiant.Text = "Sélectionner l\'étudiant";
            this.cbx_etudiant.SelectedValueChanged += new System.EventHandler(this.cbx_etudiant_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Etudiant";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(185, 34);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(38, 13);
            this.lbl_year.TabIndex = 49;
            this.lbl_year.Text = "Année";
            // 
            // etudiantCoursInscritTableAdapter
            // 
            this.etudiantCoursInscritTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoursTableAdapter = null;
            this.tableAdapterManager.EtudiantCoursInscritTableAdapter = null;
            this.tableAdapterManager.EtudiantCoursNonInscritTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.ProfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // etudiantCoursNonInscritTableAdapter
            // 
            this.etudiantCoursNonInscritTableAdapter.ClearBeforeFill = true;
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
            // InscriptionEtudiant_NC_DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 381);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_etudiant);
            this.Controls.Add(this.cbx_etudiantYear);
            this.Controls.Add(this.tbx_debug);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_coursNonInscrit);
            this.Controls.Add(this.dgv_coursInscrit);
            this.Controls.Add(this.label2);
            this.Name = "InscriptionEtudiant_NC_DataGridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Incription | Mise à jour";
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionNonCoursProfEtudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursInscrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantCoursInscritBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coursNonInscrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantCoursNonInscritBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource inscriptionNonCoursProfEtudiantBindingSource;
        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource etudiantCoursInscritBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantCoursInscritTableAdapter etudiantCoursInscritTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_coursInscrit;
        private System.Windows.Forms.BindingSource etudiantCoursNonInscritBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantCoursNonInscritTableAdapter etudiantCoursNonInscritTableAdapter;
        private System.Windows.Forms.DataGridView dgv_coursNonInscrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tbx_debug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn année;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbx_etudiantYear;
        private System.Windows.Forms.ComboBox cbx_etudiant;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_year;
      }
}