namespace Projet1BaseDeDonnee3
{
    partial class frmAjouterUtilisateur
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.tbUtilisateur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAjoutModif = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.typeUtilisateurTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TypeUtilisateurTableAdapter();
            this.cbNoTypeUtilisateur = new System.Windows.Forms.ComboBox();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom de l\'utilisateur";
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(198, 158);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(121, 20);
            this.tbMotDePasse.TabIndex = 7;
            // 
            // tbUtilisateur
            // 
            this.tbUtilisateur.Location = new System.Drawing.Point(198, 125);
            this.tbUtilisateur.Name = "tbUtilisateur";
            this.tbUtilisateur.Size = new System.Drawing.Size(121, 20);
            this.tbUtilisateur.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "No type utilisateur :";
            // 
            // lblAjoutModif
            // 
            this.lblAjoutModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutModif.Location = new System.Drawing.Point(12, 33);
            this.lblAjoutModif.Name = "lblAjoutModif";
            this.lblAjoutModif.Size = new System.Drawing.Size(523, 60);
            this.lblAjoutModif.TabIndex = 13;
            this.lblAjoutModif.Text = "Ajout d\'un utilisateur";
            this.lblAjoutModif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(358, 270);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(107, 79);
            this.btnFermer.TabIndex = 15;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // cbNoTypeUtilisateur
            // 
            this.cbNoTypeUtilisateur.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeUtilisateurBindingSource, "NoTypeUtilisteur", true));
            this.cbNoTypeUtilisateur.DataSource = this.typeUtilisateurBindingSource1;
            this.cbNoTypeUtilisateur.DisplayMember = "Identification";
            this.cbNoTypeUtilisateur.FormattingEnabled = true;
            this.cbNoTypeUtilisateur.Location = new System.Drawing.Point(198, 191);
            this.cbNoTypeUtilisateur.Name = "cbNoTypeUtilisateur";
            this.cbNoTypeUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.cbNoTypeUtilisateur.TabIndex = 16;
            this.cbNoTypeUtilisateur.ValueMember = "NoTypeUtilisteur";
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "TypeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // typeUtilisateurBindingSource1
            // 
            this.typeUtilisateurBindingSource1.DataMember = "TypeUtilisateur";
            this.typeUtilisateurBindingSource1.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(212, 270);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(107, 79);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // frmAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 382);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbNoTypeUtilisateur);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblAjoutModif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.tbUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAjouterUtilisateur";
            this.Text = "Ajout d\'un utilisateur";
            this.Load += new System.EventHandler(this.frmAjouterUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.TextBox tbUtilisateur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAjoutModif;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TypeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbNoTypeUtilisateur;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource1;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}