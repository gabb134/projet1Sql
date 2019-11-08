namespace Projet1BaseDeDonnee3
{
    partial class frmAjoutModificationInvite
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
            this.gbPlaceholder = new System.Windows.Forms.GroupBox();
            this.btnPlaceholderEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.cbClientNo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.inviteTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.InviteTableAdapter();
            this.clientTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClientNom = new System.Windows.Forms.TextBox();
            this.tbClientPrenom = new System.Windows.Forms.TextBox();
            this.tbClientVille = new System.Windows.Forms.TextBox();
            this.tbClientPays = new System.Windows.Forms.TextBox();
            this.tbClientCodePostal = new System.Windows.Forms.TextBox();
            this.tbClientAdresse = new System.Windows.Forms.TextBox();
            this.tbClientDate = new System.Windows.Forms.TextBox();
            this.tbClientNo = new System.Windows.Forms.TextBox();
            this.errMsgInvite = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPlaceholder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMsgInvite)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlaceholder
            // 
            this.gbPlaceholder.Controls.Add(this.btnPlaceholderEnregistrer);
            this.gbPlaceholder.Controls.Add(this.btnAnnuler);
            this.gbPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlaceholder.Location = new System.Drawing.Point(51, 500);
            this.gbPlaceholder.Name = "gbPlaceholder";
            this.gbPlaceholder.Size = new System.Drawing.Size(464, 120);
            this.gbPlaceholder.TabIndex = 46;
            this.gbPlaceholder.TabStop = false;
            // 
            // btnPlaceholderEnregistrer
            // 
            this.btnPlaceholderEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceholderEnregistrer.Location = new System.Drawing.Point(6, 37);
            this.btnPlaceholderEnregistrer.Name = "btnPlaceholderEnregistrer";
            this.btnPlaceholderEnregistrer.Size = new System.Drawing.Size(175, 63);
            this.btnPlaceholderEnregistrer.TabIndex = 3;
            this.btnPlaceholderEnregistrer.UseVisualStyleBackColor = true;
            this.btnPlaceholderEnregistrer.Click += new System.EventHandler(this.btnPlaceholderEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(283, 37);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(175, 63);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(92, 105);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(117, 30);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(92, 63);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(117, 30);
            this.tbNom.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Prénom";
            // 
            // tbNo
            // 
            this.tbNo.Enabled = false;
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNo.Location = new System.Drawing.Point(299, 23);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(33, 30);
            this.tbNo.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "No de l\'invité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Label placeholder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Code postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Prénom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ville";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(252, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "Pays";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(247, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Adresse";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 56;
            this.label12.Text = "Date d\'inscription";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 54;
            this.label13.Text = "No du client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbClientNo);
            this.groupBox1.Controls.Add(this.tbClientDate);
            this.groupBox1.Controls.Add(this.tbClientAdresse);
            this.groupBox1.Controls.Add(this.tbClientCodePostal);
            this.groupBox1.Controls.Add(this.tbClientPays);
            this.groupBox1.Controls.Add(this.tbClientVille);
            this.groupBox1.Controls.Add(this.tbClientPrenom);
            this.groupBox1.Controls.Add(this.tbClientNom);
            this.groupBox1.Controls.Add(this.cbClientNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 296);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données du client";
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbClientNo
            // 
            this.cbClientNo.DataSource = this.clientBindingSource;
            this.cbClientNo.DisplayMember = "NoCLient";
            this.cbClientNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientNo.FormattingEnabled = true;
            this.cbClientNo.Location = new System.Drawing.Point(299, 22);
            this.cbClientNo.Name = "cbClientNo";
            this.cbClientNo.Size = new System.Drawing.Size(69, 33);
            this.cbClientNo.TabIndex = 64;
            this.cbClientNo.ValueMember = "NoCLient";
            this.cbClientNo.Visible = false;
            this.cbClientNo.TextChanged += new System.EventHandler(this.cbClientNo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNo);
            this.groupBox2.Controls.Add(this.tbPrenom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbNom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 148);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Données de l\'invité";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "Invite";
            this.inviteBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // tbClientNom
            // 
            this.tbClientNom.Enabled = false;
            this.tbClientNom.Location = new System.Drawing.Point(92, 83);
            this.tbClientNom.Name = "tbClientNom";
            this.tbClientNom.Size = new System.Drawing.Size(117, 30);
            this.tbClientNom.TabIndex = 81;
            // 
            // tbClientPrenom
            // 
            this.tbClientPrenom.Enabled = false;
            this.tbClientPrenom.Location = new System.Drawing.Point(92, 125);
            this.tbClientPrenom.Name = "tbClientPrenom";
            this.tbClientPrenom.Size = new System.Drawing.Size(117, 30);
            this.tbClientPrenom.TabIndex = 82;
            // 
            // tbClientVille
            // 
            this.tbClientVille.Enabled = false;
            this.tbClientVille.Location = new System.Drawing.Point(92, 169);
            this.tbClientVille.Name = "tbClientVille";
            this.tbClientVille.Size = new System.Drawing.Size(117, 30);
            this.tbClientVille.TabIndex = 83;
            // 
            // tbClientPays
            // 
            this.tbClientPays.Enabled = false;
            this.tbClientPays.Location = new System.Drawing.Point(375, 83);
            this.tbClientPays.Name = "tbClientPays";
            this.tbClientPays.Size = new System.Drawing.Size(115, 30);
            this.tbClientPays.TabIndex = 84;
            // 
            // tbClientCodePostal
            // 
            this.tbClientCodePostal.Enabled = false;
            this.tbClientCodePostal.Location = new System.Drawing.Point(375, 169);
            this.tbClientCodePostal.Name = "tbClientCodePostal";
            this.tbClientCodePostal.Size = new System.Drawing.Size(115, 30);
            this.tbClientCodePostal.TabIndex = 85;
            // 
            // tbClientAdresse
            // 
            this.tbClientAdresse.Enabled = false;
            this.tbClientAdresse.Location = new System.Drawing.Point(375, 125);
            this.tbClientAdresse.Name = "tbClientAdresse";
            this.tbClientAdresse.Size = new System.Drawing.Size(191, 30);
            this.tbClientAdresse.TabIndex = 86;
            // 
            // tbClientDate
            // 
            this.tbClientDate.Enabled = false;
            this.tbClientDate.Location = new System.Drawing.Point(299, 235);
            this.tbClientDate.Name = "tbClientDate";
            this.tbClientDate.Size = new System.Drawing.Size(200, 30);
            this.tbClientDate.TabIndex = 87;
            // 
            // tbClientNo
            // 
            this.tbClientNo.Enabled = false;
            this.tbClientNo.Location = new System.Drawing.Point(299, 23);
            this.tbClientNo.Name = "tbClientNo";
            this.tbClientNo.Size = new System.Drawing.Size(33, 30);
            this.tbClientNo.TabIndex = 88;
            // 
            // errMsgInvite
            // 
            this.errMsgInvite.ContainerControl = this;
            // 
            // frmInviteAjoutModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPlaceholder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInviteAjoutModification";
            this.Load += new System.EventHandler(this.frmInviteAjoutModification_Load);
            this.gbPlaceholder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMsgInvite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlaceholder;
        private System.Windows.Forms.Button btnPlaceholderEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbClientNo;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private System.Windows.Forms.TextBox tbClientAdresse;
        private System.Windows.Forms.TextBox tbClientCodePostal;
        private System.Windows.Forms.TextBox tbClientPays;
        private System.Windows.Forms.TextBox tbClientVille;
        private System.Windows.Forms.TextBox tbClientPrenom;
        private System.Windows.Forms.TextBox tbClientNom;
        private System.Windows.Forms.TextBox tbClientDate;
        private System.Windows.Forms.TextBox tbClientNo;
        private System.Windows.Forms.ErrorProvider errMsgInvite;
        //private Projet1BaseDeDonnee3.BDVoyagesGuellehDataSetTableAdapters.clientTableAdapter clientTableAdapter;
    }
}