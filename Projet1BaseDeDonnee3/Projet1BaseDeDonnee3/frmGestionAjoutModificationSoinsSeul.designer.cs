namespace Projet1BaseDeDonnee3
{
    partial class frmGestionAjoutModificationSoinsSeul
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
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label noSoinLabel;
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSoin = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.lblAjoutModif = new System.Windows.Forms.Label();
            this.bDTP1GuellehMarreroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TypeUtilisateurTableAdapter();
            this.typeUtilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TypeSoinTableAdapter();
            this.cbTypeSoin = new System.Windows.Forms.ComboBox();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            prixLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1GuellehMarreroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prixLabel.Location = new System.Drawing.Point(76, 259);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(43, 20);
            prixLabel.TabIndex = 38;
            prixLabel.Text = "Prix:";
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeSoinLabel.Location = new System.Drawing.Point(76, 137);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(120, 20);
            noTypeSoinLabel.TabIndex = 37;
            noTypeSoinLabel.Text = "No Type Soin:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dureeLabel.Location = new System.Drawing.Point(76, 225);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(108, 20);
            dureeLabel.TabIndex = 36;
            dureeLabel.Text = "Duree (min):";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(76, 196);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 35;
            descriptionLabel.Text = "Description:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noSoinLabel.Location = new System.Drawing.Point(76, 167);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(77, 20);
            noSoinLabel.TabIndex = 34;
            noSoinLabel.Text = "No Soin:";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(55, 342);
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
            this.btnFermer.Location = new System.Drawing.Point(201, 342);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(107, 79);
            this.btnFermer.TabIndex = 20;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(199, 256);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 20);
            this.tbPrix.TabIndex = 42;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(199, 195);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 40;
            // 
            // tbSoin
            // 
            this.tbSoin.Location = new System.Drawing.Point(199, 169);
            this.tbSoin.Name = "tbSoin";
            this.tbSoin.Size = new System.Drawing.Size(100, 20);
            this.tbSoin.TabIndex = 39;
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(199, 229);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(100, 20);
            this.tbDuree.TabIndex = 43;
            // 
            // lblAjoutModif
            // 
            this.lblAjoutModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutModif.Location = new System.Drawing.Point(-61, 37);
            this.lblAjoutModif.Name = "lblAjoutModif";
            this.lblAjoutModif.Size = new System.Drawing.Size(523, 60);
            this.lblAjoutModif.TabIndex = 44;
            this.lblAjoutModif.Text = "test";
            this.lblAjoutModif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bDTP1GuellehMarreroDataSetBindingSource
            // 
            this.bDTP1GuellehMarreroDataSetBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            this.bDTP1GuellehMarreroDataSetBindingSource.Position = 0;
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "TypeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bDTP1GuellehMarreroDataSetBindingSource;
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // typeUtilisateurBindingSource1
            // 
            this.typeUtilisateurBindingSource1.DataMember = "TypeUtilisateur";
            this.typeUtilisateurBindingSource1.DataSource = this.bDTP1Guelleh_MarreroDataSet;
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
            this.tableAdapterManager.TypeUtilisateurTableAdapter = this.typeUtilisateurTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "TypeSoin";
            this.typeSoinBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // cbTypeSoin
            // 
            this.cbTypeSoin.DataSource = this.typeSoinBindingSource;
            this.cbTypeSoin.DisplayMember = "NoTypeSoin";
            this.cbTypeSoin.FormattingEnabled = true;
            this.cbTypeSoin.Location = new System.Drawing.Point(202, 139);
            this.cbTypeSoin.Name = "cbTypeSoin";
            this.cbTypeSoin.Size = new System.Drawing.Size(97, 21);
            this.cbTypeSoin.TabIndex = 44;
            this.cbTypeSoin.ValueMember = "NoTypeSoin";
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmGestionAjoutModificationSoinsSeul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.cbTypeSoin);
            this.Controls.Add(this.lblAjoutModif);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbSoin);
            this.Controls.Add(prixLabel);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmGestionAjoutModificationSoinsSeul";
            this.Text = "frmGestionAjoutModificationSoinsSeul";
            this.Load += new System.EventHandler(this.frmGestionAjoutModificationSoinsSeul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1GuellehMarreroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbSoin;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.Label lblAjoutModif;
        private System.Windows.Forms.BindingSource bDTP1GuellehMarreroDataSetBindingSource;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TypeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource1;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TypeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.ComboBox cbTypeSoin;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}