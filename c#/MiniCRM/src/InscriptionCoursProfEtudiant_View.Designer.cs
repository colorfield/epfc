namespace ECOLE_CRM
{
    partial class InscriptionCoursProfEtudiant_View
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
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.numEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.numEToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.inscriptionCoursProfEtudiantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscriptionCoursProfEtudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.inscriptionCoursProfEtudiantTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.InscriptionCoursProfEtudiantTableAdapter();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionCoursProfEtudiantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionCoursProfEtudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numEToolStripLabel,
            this.numEToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(878, 25);
            this.fillToolStrip.TabIndex = 0;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // numEToolStripLabel
            // 
            this.numEToolStripLabel.Name = "numEToolStripLabel";
            this.numEToolStripLabel.Size = new System.Drawing.Size(108, 22);
            this.numEToolStripLabel.Text = "Numéro d\'étudiant";
            // 
            // numEToolStripTextBox
            // 
            this.numEToolStripTextBox.Name = "numEToolStripTextBox";
            this.numEToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.fillToolStripButton.Text = "Filtrer";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // inscriptionCoursProfEtudiantDataGridView
            // 
            this.inscriptionCoursProfEtudiantDataGridView.AutoGenerateColumns = false;
            this.inscriptionCoursProfEtudiantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscriptionCoursProfEtudiantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.prénomProf,
            this.nomProf,
            this.dataGridViewTextBoxColumn6,
            this.prénomEtudiant,
            this.nomEtudiant});
            this.inscriptionCoursProfEtudiantDataGridView.DataSource = this.inscriptionCoursProfEtudiantBindingSource;
            this.inscriptionCoursProfEtudiantDataGridView.Location = new System.Drawing.Point(12, 28);
            this.inscriptionCoursProfEtudiantDataGridView.Name = "inscriptionCoursProfEtudiantDataGridView";
            this.inscriptionCoursProfEtudiantDataGridView.Size = new System.Drawing.Size(856, 360);
            this.inscriptionCoursProfEtudiantDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProf";
            this.dataGridViewTextBoxColumn3.HeaderText = "idProf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // prénomProf
            // 
            this.prénomProf.DataPropertyName = "prénomProf";
            this.prénomProf.HeaderText = "Prénom Prof";
            this.prénomProf.Name = "prénomProf";
            // 
            // nomProf
            // 
            this.nomProf.DataPropertyName = "nomProf";
            this.nomProf.HeaderText = "nomProf";
            this.nomProf.Name = "nomProf";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idEtud";
            this.dataGridViewTextBoxColumn6.HeaderText = "idEtud";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // prénomEtudiant
            // 
            this.prénomEtudiant.DataPropertyName = "prénomEtudiant";
            this.prénomEtudiant.HeaderText = "Prénom Etudiant";
            this.prénomEtudiant.Name = "prénomEtudiant";
            this.prénomEtudiant.ReadOnly = true;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.DataPropertyName = "nomEtudiant";
            this.nomEtudiant.HeaderText = "Nom Etudiant";
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            // 
            // inscriptionCoursProfEtudiantBindingSource
            // 
            this.inscriptionCoursProfEtudiantBindingSource.DataMember = "InscriptionCoursProfEtudiant";
            this.inscriptionCoursProfEtudiantBindingSource.DataSource = this.ecoleDataSet;
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoursTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.ProfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscriptionCoursProfEtudiantTableAdapter
            // 
            this.inscriptionCoursProfEtudiantTableAdapter.ClearBeforeFill = true;
            // 
            // InscriptionCoursProfEtudiant_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 413);
            this.Controls.Add(this.inscriptionCoursProfEtudiantDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "InscriptionCoursProfEtudiant_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Snapshot des inscriptions";
            this.Load += new System.EventHandler(this.InscriptionCoursProfEtudiant_View_Load);
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionCoursProfEtudiantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionCoursProfEtudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EcoleDataSet ecoleDataSet;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource inscriptionCoursProfEtudiantBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.InscriptionCoursProfEtudiantTableAdapter inscriptionCoursProfEtudiantTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel numEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox numEToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView inscriptionCoursProfEtudiantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
    }
}