namespace Projet1BaseDeDonnee3
{
    partial class frmAjoutPlanifSoin
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
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noCLientLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.cbNoClient = new System.Windows.Forms.ComboBox();
            this.clientTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterReservationChambre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.assistantTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter();
            this.soinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbNoSoin = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.prenomTextBox1 = new System.Windows.Forms.TextBox();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTextBox1 = new System.Windows.Forms.TextBox();
            this.cbNoAssist = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpReservation = new System.Windows.Forms.DateTimePicker();
            this.numHeureReservation = new System.Windows.Forms.NumericUpDown();
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noCLientLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeureReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(6, 145);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(80, 25);
            prenomLabel.TabIndex = 4;
            prenomLabel.Text = "Prénom";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(6, 96);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(53, 25);
            nomLabel.TabIndex = 2;
            nomLabel.Text = "Nom";
            // 
            // noCLientLabel
            // 
            noCLientLabel.AutoSize = true;
            noCLientLabel.Location = new System.Drawing.Point(6, 50);
            noCLientLabel.Name = "noCLientLabel";
            noCLientLabel.Size = new System.Drawing.Size(114, 25);
            noCLientLabel.TabIndex = 0;
            noCLientLabel.Text = "No du client";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(77, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 25);
            label4.TabIndex = 0;
            label4.Text = "No du soin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 145);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "Prénom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 96);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 25);
            label6.TabIndex = 2;
            label6.Text = "Nom";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 50);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(154, 25);
            label7.TabIndex = 0;
            label7.Text = "No de l\'assistant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Planification de soin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomTextBox);
            this.groupBox1.Controls.Add(this.prenomTextBox);
            this.groupBox1.Controls.Add(this.cbNoClient);
            this.groupBox1.Controls.Add(prenomLabel);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(noCLientLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données de la personne";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom", true));
            this.nomTextBox.Enabled = false;
            this.nomTextBox.Location = new System.Drawing.Point(126, 93);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 30);
            this.nomTextBox.TabIndex = 23;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenom", true));
            this.prenomTextBox.Enabled = false;
            this.prenomTextBox.Location = new System.Drawing.Point(126, 142);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 30);
            this.prenomTextBox.TabIndex = 24;
            // 
            // cbNoClient
            // 
            this.cbNoClient.DataSource = this.clientBindingSource;
            this.cbNoClient.DisplayMember = "NoCLient";
            this.cbNoClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoClient.FormattingEnabled = true;
            this.cbNoClient.Location = new System.Drawing.Point(126, 46);
            this.cbNoClient.Name = "cbNoClient";
            this.cbNoClient.Size = new System.Drawing.Size(60, 33);
            this.cbNoClient.TabIndex = 7;
            this.cbNoClient.ValueMember = "NoCLient";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(360, 29);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(254, 63);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouterReservationChambre
            // 
            this.btnAjouterReservationChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterReservationChambre.Location = new System.Drawing.Point(6, 31);
            this.btnAjouterReservationChambre.Name = "btnAjouterReservationChambre";
            this.btnAjouterReservationChambre.Size = new System.Drawing.Size(254, 63);
            this.btnAjouterReservationChambre.TabIndex = 20;
            this.btnAjouterReservationChambre.Text = "Ajouter cette planification";
            this.btnAjouterReservationChambre.UseVisualStyleBackColor = true;
            this.btnAjouterReservationChambre.Click += new System.EventHandler(this.btnAjouterReservationChambre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAjouterReservationChambre);
            this.groupBox2.Controls.Add(this.btnAnnuler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(86, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion des planifications des soins";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = this.assistantTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
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
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descriptionTextBox);
            this.groupBox3.Controls.Add(this.cbNoSoin);
            this.groupBox3.Controls.Add(label3);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(272, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 181);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Données des soins";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soinBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(11, 142);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(237, 30);
            this.descriptionTextBox.TabIndex = 25;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "Soin";
            this.soinBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // cbNoSoin
            // 
            this.cbNoSoin.DataSource = this.soinBindingSource;
            this.cbNoSoin.DisplayMember = "NoSoin";
            this.cbNoSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoSoin.FormattingEnabled = true;
            this.cbNoSoin.Location = new System.Drawing.Point(126, 46);
            this.cbNoSoin.Name = "cbNoSoin";
            this.cbNoSoin.Size = new System.Drawing.Size(60, 33);
            this.cbNoSoin.TabIndex = 7;
            this.cbNoSoin.ValueMember = "NoSoin";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.prenomTextBox1);
            this.groupBox4.Controls.Add(this.nomTextBox1);
            this.groupBox4.Controls.Add(this.cbNoAssist);
            this.groupBox4.Controls.Add(label5);
            this.groupBox4.Controls.Add(label6);
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(532, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 181);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Données des assistants";
            // 
            // prenomTextBox1
            // 
            this.prenomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "Prenom", true));
            this.prenomTextBox1.Enabled = false;
            this.prenomTextBox1.Location = new System.Drawing.Point(92, 142);
            this.prenomTextBox1.Name = "prenomTextBox1";
            this.prenomTextBox1.Size = new System.Drawing.Size(134, 30);
            this.prenomTextBox1.TabIndex = 25;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // nomTextBox1
            // 
            this.nomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "Nom", true));
            this.nomTextBox1.Enabled = false;
            this.nomTextBox1.Location = new System.Drawing.Point(92, 93);
            this.nomTextBox1.Name = "nomTextBox1";
            this.nomTextBox1.Size = new System.Drawing.Size(134, 30);
            this.nomTextBox1.TabIndex = 26;
            // 
            // cbNoAssist
            // 
            this.cbNoAssist.DataSource = this.assistantBindingSource;
            this.cbNoAssist.DisplayMember = "NoAssistant";
            this.cbNoAssist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoAssist.FormattingEnabled = true;
            this.cbNoAssist.Location = new System.Drawing.Point(166, 47);
            this.cbNoAssist.Name = "cbNoAssist";
            this.cbNoAssist.Size = new System.Drawing.Size(60, 33);
            this.cbNoAssist.TabIndex = 7;
            this.cbNoAssist.ValueMember = "NoAssistant";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numHeureReservation);
            this.groupBox5.Controls.Add(this.dtpReservation);
            this.groupBox5.Controls.Add(label2);
            this.groupBox5.Controls.Add(label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(185, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(418, 132);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Séjour";
            // 
            // dtpReservation
            // 
            this.dtpReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservation.Location = new System.Drawing.Point(205, 45);
            this.dtpReservation.Name = "dtpReservation";
            this.dtpReservation.Size = new System.Drawing.Size(200, 30);
            this.dtpReservation.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(193, 25);
            label2.TabIndex = 2;
            label2.Text = "Heure de réservation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 50);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(181, 25);
            label8.TabIndex = 0;
            label8.Text = "Date de réservation";
            // 
            // numHeureReservation
            // 
            this.numHeureReservation.Location = new System.Drawing.Point(205, 94);
            this.numHeureReservation.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numHeureReservation.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numHeureReservation.Name = "numHeureReservation";
            this.numHeureReservation.Size = new System.Drawing.Size(120, 30);
            this.numHeureReservation.TabIndex = 16;
            this.numHeureReservation.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // frmAjoutPlanifSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 478);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutPlanifSoin";
            this.Text = "Ajout d\'une planification de soin";
            this.Load += new System.EventHandler(this.frmAjoutPlanifSoin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeureReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNoClient;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouterReservationChambre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbNoSoin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbNoAssist;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private System.Windows.Forms.TextBox prenomTextBox1;
        private System.Windows.Forms.TextBox nomTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpReservation;
        private System.Windows.Forms.NumericUpDown numHeureReservation;
    }
}