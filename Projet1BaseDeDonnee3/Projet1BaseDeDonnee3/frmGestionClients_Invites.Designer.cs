namespace Projet1BaseDeDonnee3
{
    partial class frmGestionClients_Invites
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
         this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
         this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.clientTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter();
         this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
         this.inviteTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.InviteTableAdapter();
         this.clientDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.inviteDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnAjouterClient = new System.Windows.Forms.Button();
         this.btnModifierClient = new System.Windows.Forms.Button();
         this.btnSupprimerClient = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnSupprimerInvite = new System.Windows.Forms.Button();
         this.btnModifierInvite = new System.Windows.Forms.Button();
         this.btnAjouterInvite = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // bDTP1Guelleh_MarreroDataSet
         // 
         this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
         this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // clientBindingSource
         // 
         this.clientBindingSource.DataMember = "Client";
         this.clientBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
         // 
         // clientTableAdapter
         // 
         this.clientTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.AssistantSoinTableAdapter = null;
         this.tableAdapterManager.AssistantTableAdapter = null;
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.ChambreTableAdapter = null;
         this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
         this.tableAdapterManager.InviteTableAdapter = this.inviteTableAdapter;
         this.tableAdapterManager.PlanifSoinTableAdapter = null;
         this.tableAdapterManager.ReservationChambreTableAdapter = null;
         this.tableAdapterManager.SoinTableAdapter = null;
         this.tableAdapterManager.TypeChambreTableAdapter = null;
         this.tableAdapterManager.TypeSoinTableAdapter = null;
         this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.UtilisateurTableAdapter = null;
         // 
         // inviteTableAdapter
         // 
         this.inviteTableAdapter.ClearBeforeFill = true;
         // 
         // clientDataGridView
         // 
         this.clientDataGridView.AutoGenerateColumns = false;
         this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
         this.clientDataGridView.DataSource = this.clientBindingSource;
         this.clientDataGridView.Location = new System.Drawing.Point(9, 41);
         this.clientDataGridView.Margin = new System.Windows.Forms.Padding(2);
         this.clientDataGridView.Name = "clientDataGridView";
         this.clientDataGridView.RowHeadersWidth = 51;
         this.clientDataGridView.RowTemplate.Height = 24;
         this.clientDataGridView.Size = new System.Drawing.Size(1029, 252);
         this.clientDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "NoCLient";
         this.dataGridViewTextBoxColumn1.HeaderText = "NoCLient";
         this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.Width = 125;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
         this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
         this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.Width = 125;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
         this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
         this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.Width = 125;
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "Ville";
         this.dataGridViewTextBoxColumn4.HeaderText = "Ville";
         this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.Width = 125;
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.DataPropertyName = "Pays";
         this.dataGridViewTextBoxColumn5.HeaderText = "Pays";
         this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         this.dataGridViewTextBoxColumn5.Width = 125;
         // 
         // dataGridViewTextBoxColumn6
         // 
         this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresse";
         this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
         this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
         this.dataGridViewTextBoxColumn6.Width = 125;
         // 
         // dataGridViewTextBoxColumn7
         // 
         this.dataGridViewTextBoxColumn7.DataPropertyName = "CodePostal";
         this.dataGridViewTextBoxColumn7.HeaderText = "CodePostal";
         this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
         this.dataGridViewTextBoxColumn7.Width = 125;
         // 
         // dataGridViewTextBoxColumn8
         // 
         this.dataGridViewTextBoxColumn8.DataPropertyName = "DateInscription";
         this.dataGridViewTextBoxColumn8.HeaderText = "DateInscription";
         this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
         this.dataGridViewTextBoxColumn8.Width = 125;
         // 
         // inviteBindingSource
         // 
         this.inviteBindingSource.DataMember = "FK__Invite__NoClient__4FDCC2C0";
         this.inviteBindingSource.DataSource = this.clientBindingSource;
         // 
         // inviteDataGridView
         // 
         this.inviteDataGridView.AutoGenerateColumns = false;
         this.inviteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.inviteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
         this.inviteDataGridView.DataSource = this.inviteBindingSource;
         this.inviteDataGridView.Location = new System.Drawing.Point(9, 435);
         this.inviteDataGridView.Margin = new System.Windows.Forms.Padding(2);
         this.inviteDataGridView.Name = "inviteDataGridView";
         this.inviteDataGridView.RowHeadersWidth = 51;
         this.inviteDataGridView.RowTemplate.Height = 24;
         this.inviteDataGridView.Size = new System.Drawing.Size(1029, 200);
         this.inviteDataGridView.TabIndex = 2;
         // 
         // dataGridViewTextBoxColumn9
         // 
         this.dataGridViewTextBoxColumn9.DataPropertyName = "NoInvite";
         this.dataGridViewTextBoxColumn9.HeaderText = "NoInvite";
         this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
         this.dataGridViewTextBoxColumn9.Width = 125;
         // 
         // dataGridViewTextBoxColumn10
         // 
         this.dataGridViewTextBoxColumn10.DataPropertyName = "NomPrenom";
         this.dataGridViewTextBoxColumn10.HeaderText = "NomPrenom";
         this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
         this.dataGridViewTextBoxColumn10.Width = 125;
         // 
         // dataGridViewTextBoxColumn11
         // 
         this.dataGridViewTextBoxColumn11.DataPropertyName = "NoClient";
         this.dataGridViewTextBoxColumn11.HeaderText = "NoClient";
         this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
         this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
         this.dataGridViewTextBoxColumn11.Width = 125;
         // 
         // btnAjouterClient
         // 
         this.btnAjouterClient.Location = new System.Drawing.Point(9, 298);
         this.btnAjouterClient.Margin = new System.Windows.Forms.Padding(2);
         this.btnAjouterClient.Name = "btnAjouterClient";
         this.btnAjouterClient.Size = new System.Drawing.Size(122, 63);
         this.btnAjouterClient.TabIndex = 4;
         this.btnAjouterClient.Text = "Ajouter un client";
         this.btnAjouterClient.UseVisualStyleBackColor = true;
         this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
         // 
         // btnModifierClient
         // 
         this.btnModifierClient.Location = new System.Drawing.Point(477, 298);
         this.btnModifierClient.Margin = new System.Windows.Forms.Padding(2);
         this.btnModifierClient.Name = "btnModifierClient";
         this.btnModifierClient.Size = new System.Drawing.Size(122, 63);
         this.btnModifierClient.TabIndex = 5;
         this.btnModifierClient.Text = "Modifier ce client";
         this.btnModifierClient.UseVisualStyleBackColor = true;
         this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
         // 
         // btnSupprimerClient
         // 
         this.btnSupprimerClient.Location = new System.Drawing.Point(916, 298);
         this.btnSupprimerClient.Margin = new System.Windows.Forms.Padding(2);
         this.btnSupprimerClient.Name = "btnSupprimerClient";
         this.btnSupprimerClient.Size = new System.Drawing.Size(122, 63);
         this.btnSupprimerClient.TabIndex = 6;
         this.btnSupprimerClient.Text = "Supprimer ce client";
         this.btnSupprimerClient.UseVisualStyleBackColor = true;
         this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(493, 7);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(103, 32);
         this.label1.TabIndex = 7;
         this.label1.Text = "Clients";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(493, 401);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(97, 32);
         this.label2.TabIndex = 8;
         this.label2.Text = "Invités";
         // 
         // btnSupprimerInvite
         // 
         this.btnSupprimerInvite.Location = new System.Drawing.Point(916, 640);
         this.btnSupprimerInvite.Margin = new System.Windows.Forms.Padding(2);
         this.btnSupprimerInvite.Name = "btnSupprimerInvite";
         this.btnSupprimerInvite.Size = new System.Drawing.Size(122, 63);
         this.btnSupprimerInvite.TabIndex = 11;
         this.btnSupprimerInvite.Text = "Supprimer cet invité";
         this.btnSupprimerInvite.UseVisualStyleBackColor = true;
         this.btnSupprimerInvite.Click += new System.EventHandler(this.btnSupprimerInvite_Click);
         // 
         // btnModifierInvite
         // 
         this.btnModifierInvite.Location = new System.Drawing.Point(477, 640);
         this.btnModifierInvite.Margin = new System.Windows.Forms.Padding(2);
         this.btnModifierInvite.Name = "btnModifierInvite";
         this.btnModifierInvite.Size = new System.Drawing.Size(122, 63);
         this.btnModifierInvite.TabIndex = 10;
         this.btnModifierInvite.Text = "Modifier cet invité";
         this.btnModifierInvite.UseVisualStyleBackColor = true;
         this.btnModifierInvite.Click += new System.EventHandler(this.btnModifierInvite_Click);
         // 
         // btnAjouterInvite
         // 
         this.btnAjouterInvite.Location = new System.Drawing.Point(9, 640);
         this.btnAjouterInvite.Margin = new System.Windows.Forms.Padding(2);
         this.btnAjouterInvite.Name = "btnAjouterInvite";
         this.btnAjouterInvite.Size = new System.Drawing.Size(122, 63);
         this.btnAjouterInvite.TabIndex = 9;
         this.btnAjouterInvite.Text = "Ajouter un invité";
         this.btnAjouterInvite.UseVisualStyleBackColor = true;
         this.btnAjouterInvite.Click += new System.EventHandler(this.btnAjouterInvite_Click);
         // 
         // frmGestionClients
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1047, 715);
         this.Controls.Add(this.btnSupprimerInvite);
         this.Controls.Add(this.btnModifierInvite);
         this.Controls.Add(this.btnAjouterInvite);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnSupprimerClient);
         this.Controls.Add(this.btnModifierClient);
         this.Controls.Add(this.btnAjouterClient);
         this.Controls.Add(this.inviteDataGridView);
         this.Controls.Add(this.clientDataGridView);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "frmGestionClients";
         this.Text = "Gestion des clients";
         this.Load += new System.EventHandler(this.FrmGestionClients_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private System.Windows.Forms.DataGridView inviteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupprimerInvite;
        private System.Windows.Forms.Button btnModifierInvite;
        private System.Windows.Forms.Button btnAjouterInvite;
    }
}