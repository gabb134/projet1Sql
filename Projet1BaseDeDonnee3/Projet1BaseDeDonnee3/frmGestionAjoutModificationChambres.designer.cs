namespace Projet1BaseDeDonnee3
{
    partial class frmGestionAjoutModificationChambres
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
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label noSoinLabel;
            this.lblAjoutModif = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.tbChambre = new System.Windows.Forms.TextBox();
            this.tbEmplacement = new System.Windows.Forms.TextBox();
            this.tbDecoration = new System.Windows.Forms.TextBox();
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TypeChambreTableAdapter();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.cbNoTypeChambre = new System.Windows.Forms.ComboBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            noTypeSoinLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeSoinLabel.Location = new System.Drawing.Point(30, 162);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(103, 20);
            noTypeSoinLabel.TabIndex = 62;
            noTypeSoinLabel.Text = "NoChambre";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dureeLabel.Location = new System.Drawing.Point(30, 249);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(156, 20);
            dureeLabel.TabIndex = 61;
            dureeLabel.Text = "No  Type Chambre";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(30, 220);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(102, 20);
            descriptionLabel.TabIndex = 60;
            descriptionLabel.Text = "Décoration:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noSoinLabel.Location = new System.Drawing.Point(30, 191);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(118, 20);
            noSoinLabel.TabIndex = 59;
            noSoinLabel.Text = "Emplacement";
            // 
            // lblAjoutModif
            // 
            this.lblAjoutModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutModif.Location = new System.Drawing.Point(-69, 72);
            this.lblAjoutModif.Name = "lblAjoutModif";
            this.lblAjoutModif.Size = new System.Drawing.Size(523, 60);
            this.lblAjoutModif.TabIndex = 58;
            this.lblAjoutModif.Text = "Ajout ";
            this.lblAjoutModif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(86, 360);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(107, 79);
            this.btnEnregistrer.TabIndex = 57;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(232, 360);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(107, 79);
            this.btnFermer.TabIndex = 56;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // tbChambre
            // 
            this.tbChambre.Location = new System.Drawing.Point(214, 162);
            this.tbChambre.Name = "tbChambre";
            this.tbChambre.Size = new System.Drawing.Size(100, 20);
            this.tbChambre.TabIndex = 63;
            // 
            // tbEmplacement
            // 
            this.tbEmplacement.Location = new System.Drawing.Point(214, 191);
            this.tbEmplacement.Name = "tbEmplacement";
            this.tbEmplacement.Size = new System.Drawing.Size(100, 20);
            this.tbEmplacement.TabIndex = 64;
            // 
            // tbDecoration
            // 
            this.tbDecoration.Location = new System.Drawing.Point(214, 224);
            this.tbDecoration.Name = "tbDecoration";
            this.tbDecoration.Size = new System.Drawing.Size(100, 20);
            this.tbDecoration.TabIndex = 65;
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // cbNoTypeChambre
            // 
            this.cbNoTypeChambre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "NoTypeChambre", true));
            this.cbNoTypeChambre.DataSource = this.typeChambreBindingSource;
            this.cbNoTypeChambre.DisplayMember = "NoTypeChambre";
            this.cbNoTypeChambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoTypeChambre.FormattingEnabled = true;
            this.cbNoTypeChambre.Location = new System.Drawing.Point(214, 251);
            this.cbNoTypeChambre.Name = "cbNoTypeChambre";
            this.cbNoTypeChambre.Size = new System.Drawing.Size(100, 21);
            this.cbNoTypeChambre.TabIndex = 66;
            this.cbNoTypeChambre.ValueMember = "NoTypeChambre";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmGestionAjoutModificationChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 510);
            this.Controls.Add(this.cbNoTypeChambre);
            this.Controls.Add(this.tbDecoration);
            this.Controls.Add(this.tbEmplacement);
            this.Controls.Add(this.tbChambre);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.lblAjoutModif);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmGestionAjoutModificationChambres";
            this.Text = "frmGestionAjoutModificationChambres";
            this.Load += new System.EventHandler(this.frmGestionAjoutModificationChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutModif;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox tbChambre;
        private System.Windows.Forms.TextBox tbEmplacement;
        private System.Windows.Forms.TextBox tbDecoration;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbNoTypeChambre;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}