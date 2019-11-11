namespace Projet1BaseDeDonnee3
{
    partial class frmSoinsAjoutModification
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
            System.Windows.Forms.Label prixLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label noSoinLabel;
            System.Windows.Forms.Label noTypeSoinLabel;
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.lblAjoutModif = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSoin = new System.Windows.Forms.TextBox();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TypeSoinTableAdapter();
            this.typeSoinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinTableAdapter1 = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TypeSoinTableAdapter();
            this.fKSoinNoTypeSoin418EA369BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cbTypeSoin = new System.Windows.Forms.ComboBox();
            this.tbDuree = new System.Windows.Forms.NumericUpDown();
            this.tbPrix = new System.Windows.Forms.NumericUpDown();
            prixLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSoinNoTypeSoin418EA369BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prixLabel.Location = new System.Drawing.Point(112, 246);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(43, 20);
            prixLabel.TabIndex = 49;
            prixLabel.Text = "Prix:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dureeLabel.Location = new System.Drawing.Point(112, 212);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(108, 20);
            dureeLabel.TabIndex = 47;
            dureeLabel.Text = "Duree (min):";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(112, 183);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 46;
            descriptionLabel.Text = "Description:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noSoinLabel.Location = new System.Drawing.Point(112, 154);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(77, 20);
            noSoinLabel.TabIndex = 45;
            noSoinLabel.Text = "No Soin:";
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeSoinLabel.Location = new System.Drawing.Point(100, 128);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(120, 20);
            noTypeSoinLabel.TabIndex = 55;
            noTypeSoinLabel.Text = "No Type Soin:";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(125, 334);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(107, 79);
            this.btnEnregistrer.TabIndex = 21;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(271, 334);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(107, 79);
            this.btnFermer.TabIndex = 20;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
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
            // lblAjoutModif
            // 
            this.lblAjoutModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutModif.Location = new System.Drawing.Point(-30, 46);
            this.lblAjoutModif.Name = "lblAjoutModif";
            this.lblAjoutModif.Size = new System.Drawing.Size(523, 60);
            this.lblAjoutModif.TabIndex = 28;
            this.lblAjoutModif.Text = "Ajout ";
            this.lblAjoutModif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(235, 182);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 51;
            // 
            // tbSoin
            // 
            this.tbSoin.Location = new System.Drawing.Point(235, 156);
            this.tbSoin.Name = "tbSoin";
            this.tbSoin.Size = new System.Drawing.Size(100, 20);
            this.tbSoin.TabIndex = 50;
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "TypeSoin";
            this.typeSoinBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeSoinBindingSource1
            // 
            this.typeSoinBindingSource1.DataMember = "TypeSoin";
            this.typeSoinBindingSource1.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // typeSoinBindingSource2
            // 
            this.typeSoinBindingSource2.DataMember = "TypeSoin";
            this.typeSoinBindingSource2.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeSoinBindingSource3
            // 
            this.typeSoinBindingSource3.DataMember = "TypeSoin";
            this.typeSoinBindingSource3.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeSoinTableAdapter1
            // 
            this.typeSoinTableAdapter1.ClearBeforeFill = true;
            // 
            // fKSoinNoTypeSoin418EA369BindingSource
            // 
            this.fKSoinNoTypeSoin418EA369BindingSource.DataMember = "FK__Soin__NoTypeSoin__418EA369";
            this.fKSoinNoTypeSoin418EA369BindingSource.DataSource = this.typeSoinBindingSource2;
            // 
            // typeSoinBindingSource4
            // 
            this.typeSoinBindingSource4.DataMember = "TypeSoin";
            this.typeSoinBindingSource4.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeSoinBindingSource5
            // 
            this.typeSoinBindingSource5.DataMember = "TypeSoin";
            this.typeSoinBindingSource5.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // cbTypeSoin
            // 
            this.cbTypeSoin.DataSource = this.typeSoinBindingSource;
            this.cbTypeSoin.DisplayMember = "NoTypeSoin";
            this.cbTypeSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeSoin.FormattingEnabled = true;
            this.cbTypeSoin.Location = new System.Drawing.Point(235, 130);
            this.cbTypeSoin.Name = "cbTypeSoin";
            this.cbTypeSoin.Size = new System.Drawing.Size(100, 21);
            this.cbTypeSoin.TabIndex = 54;
            this.cbTypeSoin.ValueMember = "NoTypeSoin";
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(235, 212);
            this.tbDuree.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(100, 20);
            this.tbDuree.TabIndex = 56;
            this.tbDuree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(235, 249);
            this.tbPrix.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 20);
            this.tbPrix.TabIndex = 57;
            this.tbPrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmSoinsAjoutModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 433);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(this.cbTypeSoin);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbSoin);
            this.Controls.Add(prixLabel);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.lblAjoutModif);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmSoinsAjoutModification";
            this.Text = "frmSoinsAjoutModification";
            this.Load += new System.EventHandler(this.frmSoinsAjoutModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource3)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.fKSoinNoTypeSoin418EA369BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFermer;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblAjoutModif;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbSoin;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private System.Windows.Forms.BindingSource typeSoinBindingSource1;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TypeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.BindingSource typeSoinBindingSource2;
        private System.Windows.Forms.BindingSource typeSoinBindingSource3;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TypeSoinTableAdapter typeSoinTableAdapter1;
        private System.Windows.Forms.BindingSource fKSoinNoTypeSoin418EA369BindingSource;
        private System.Windows.Forms.BindingSource typeSoinBindingSource4;
        private System.Windows.Forms.ComboBox cbTypeSoin;
        private System.Windows.Forms.BindingSource typeSoinBindingSource5;
        private System.Windows.Forms.NumericUpDown tbPrix;
        public System.Windows.Forms.NumericUpDown tbDuree;
    }
}