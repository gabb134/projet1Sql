namespace Projet1BaseDeDonnee3
{
    partial class frmGestionDesSoins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.soinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planifSoinTableAdapter1 = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.PlanifSoinTableAdapter();
            this.assistantSoinTableAdapter1 = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantSoinTableAdapter();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter();
            this.assistantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupprimerSoin);
            this.groupBox1.Controls.Add(this.btnAjouterSoin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(204, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des soins";
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerSoin.Location = new System.Drawing.Point(379, 37);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(301, 63);
            this.btnSupprimerSoin.TabIndex = 7;
            this.btnSupprimerSoin.Text = "Supprimer ce soin";
            this.btnSupprimerSoin.UseVisualStyleBackColor = true;
            this.btnSupprimerSoin.Click += new System.EventHandler(this.btnSupprimerSoin_Click);
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSoin.Location = new System.Drawing.Point(6, 37);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(301, 63);
            this.btnAjouterSoin.TabIndex = 4;
            this.btnAjouterSoin.Text = "Ajouter un soin";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soins des assistants";
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "Soin";
            this.soinBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // soinDataGridView
            // 
            this.soinDataGridView.AutoGenerateColumns = false;
            this.soinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.soinDataGridView.DataSource = this.soinBindingSource;
            this.soinDataGridView.Location = new System.Drawing.Point(496, 127);
            this.soinDataGridView.Name = "soinDataGridView";
            this.soinDataGridView.Size = new System.Drawing.Size(543, 231);
            this.soinDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoSoin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Duree";
            this.dataGridViewTextBoxColumn3.HeaderText = "Duree";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoTypeSoin";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoTypeSoin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // planifSoinTableAdapter1
            // 
            this.planifSoinTableAdapter1.ClearBeforeFill = true;
            // 
            // assistantSoinTableAdapter1
            // 
            this.assistantSoinTableAdapter1.ClearBeforeFill = true;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            this.assistantBindingSource.CurrentChanged += new System.EventHandler(this.assistantBindingSource_CurrentChanged);
            this.assistantBindingSource.PositionChanged += new System.EventHandler(this.assistantBindingSource_PositionChanged);
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // assistantDataGridView
            // 
            this.assistantDataGridView.AutoGenerateColumns = false;
            this.assistantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.assistantDataGridView.DataSource = this.assistantBindingSource;
            this.assistantDataGridView.Location = new System.Drawing.Point(12, 155);
            this.assistantDataGridView.Name = "assistantDataGridView";
            this.assistantDataGridView.Size = new System.Drawing.Size(438, 220);
            this.assistantDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn6.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Specialites";
            this.dataGridViewTextBoxColumn9.HeaderText = "Specialites";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Assistans";
            // 
            // frmGestionDesSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assistantDataGridView);
            this.Controls.Add(this.soinDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionDesSoins";
            this.Text = "frmGestionSoins";
            this.Load += new System.EventHandler(this.frmGestionDesSoins_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSupprimerSoin;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.Label label1;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView soinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.PlanifSoinTableAdapter planifSoinTableAdapter1;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter1;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.DataGridView assistantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label2;
    }
}