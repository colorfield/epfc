namespace ECOLE_CRM
{
    partial class InscriptionUpdate_Test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscriptionUpdate_Test1));
            System.Windows.Forms.Label numCoursLabel;
            System.Windows.Forms.Label numEtudLabel;
            System.Windows.Forms.Label annéeLabel;
            this.ecoleDataSet = new ECOLE_CRM.EcoleDataSet();
            this.inscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscriptionTableAdapter = new ECOLE_CRM.EcoleDataSetTableAdapters.InscriptionTableAdapter();
            this.tableAdapterManager = new ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager();
            this.inscriptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.inscriptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numCoursTextBox = new System.Windows.Forms.TextBox();
            this.numEtudTextBox = new System.Windows.Forms.TextBox();
            this.annéeTextBox = new System.Windows.Forms.TextBox();
            numCoursLabel = new System.Windows.Forms.Label();
            numEtudLabel = new System.Windows.Forms.Label();
            annéeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingNavigator)).BeginInit();
            this.inscriptionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecoleDataSet
            // 
            this.ecoleDataSet.DataSetName = "EcoleDataSet";
            this.ecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscriptionBindingSource
            // 
            this.inscriptionBindingSource.DataMember = "Inscription";
            this.inscriptionBindingSource.DataSource = this.ecoleDataSet;
            // 
            // inscriptionTableAdapter
            // 
            this.inscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursTableAdapter = null;
            this.tableAdapterManager.EtudiantCoursInscritTableAdapter = null;
            this.tableAdapterManager.EtudiantCoursNonInscritTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = this.inscriptionTableAdapter;
            this.tableAdapterManager.ProfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscriptionBindingNavigator
            // 
            this.inscriptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inscriptionBindingNavigator.BindingSource = this.inscriptionBindingSource;
            this.inscriptionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inscriptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inscriptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inscriptionBindingNavigatorSaveItem});
            this.inscriptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscriptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inscriptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inscriptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inscriptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inscriptionBindingNavigator.Name = "inscriptionBindingNavigator";
            this.inscriptionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inscriptionBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.inscriptionBindingNavigator.TabIndex = 0;
            this.inscriptionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // inscriptionBindingNavigatorSaveItem
            // 
            this.inscriptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscriptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscriptionBindingNavigatorSaveItem.Image")));
            this.inscriptionBindingNavigatorSaveItem.Name = "inscriptionBindingNavigatorSaveItem";
            this.inscriptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.inscriptionBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.inscriptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.inscriptionBindingNavigatorSaveItem_Click);
            // 
            // numCoursLabel
            // 
            numCoursLabel.AutoSize = true;
            numCoursLabel.Location = new System.Drawing.Point(12, 47);
            numCoursLabel.Name = "numCoursLabel";
            numCoursLabel.Size = new System.Drawing.Size(60, 13);
            numCoursLabel.TabIndex = 1;
            numCoursLabel.Text = "num Cours:";
            // 
            // numCoursTextBox
            // 
            this.numCoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "numCours", true));
            this.numCoursTextBox.Location = new System.Drawing.Point(78, 44);
            this.numCoursTextBox.Name = "numCoursTextBox";
            this.numCoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.numCoursTextBox.TabIndex = 2;
            // 
            // numEtudLabel
            // 
            numEtudLabel.AutoSize = true;
            numEtudLabel.Location = new System.Drawing.Point(12, 73);
            numEtudLabel.Name = "numEtudLabel";
            numEtudLabel.Size = new System.Drawing.Size(55, 13);
            numEtudLabel.TabIndex = 3;
            numEtudLabel.Text = "num Etud:";
            // 
            // numEtudTextBox
            // 
            this.numEtudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "numEtud", true));
            this.numEtudTextBox.Location = new System.Drawing.Point(78, 70);
            this.numEtudTextBox.Name = "numEtudTextBox";
            this.numEtudTextBox.Size = new System.Drawing.Size(100, 20);
            this.numEtudTextBox.TabIndex = 4;
            // 
            // annéeLabel
            // 
            annéeLabel.AutoSize = true;
            annéeLabel.Location = new System.Drawing.Point(12, 99);
            annéeLabel.Name = "annéeLabel";
            annéeLabel.Size = new System.Drawing.Size(40, 13);
            annéeLabel.TabIndex = 5;
            annéeLabel.Text = "année:";
            // 
            // annéeTextBox
            // 
            this.annéeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "année", true));
            this.annéeTextBox.Location = new System.Drawing.Point(78, 96);
            this.annéeTextBox.Name = "annéeTextBox";
            this.annéeTextBox.Size = new System.Drawing.Size(100, 20);
            this.annéeTextBox.TabIndex = 6;
            // 
            // InscriptionUpdate_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 262);
            this.Controls.Add(numCoursLabel);
            this.Controls.Add(this.numCoursTextBox);
            this.Controls.Add(numEtudLabel);
            this.Controls.Add(this.numEtudTextBox);
            this.Controls.Add(annéeLabel);
            this.Controls.Add(this.annéeTextBox);
            this.Controls.Add(this.inscriptionBindingNavigator);
            this.Name = "InscriptionUpdate_Test";
            this.Text = "InscriptionUpdate_Test";
            this.Load += new System.EventHandler(this.InscriptionUpdate_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ecoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingNavigator)).EndInit();
            this.inscriptionBindingNavigator.ResumeLayout(false);
            this.inscriptionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EcoleDataSet ecoleDataSet;
        private System.Windows.Forms.BindingSource inscriptionBindingSource;
        private ECOLE_CRM.EcoleDataSetTableAdapters.InscriptionTableAdapter inscriptionTableAdapter;
        private ECOLE_CRM.EcoleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inscriptionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inscriptionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numCoursTextBox;
        private System.Windows.Forms.TextBox numEtudTextBox;
        private System.Windows.Forms.TextBox annéeTextBox;
    }
}