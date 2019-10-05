namespace Projet1BaseDeDonnee3
{
    partial class frmAjoutReservationChambre
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
            System.Windows.Forms.Label noCLientLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.label1 = new System.Windows.Forms.Label();
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.ChambreTableAdapter();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbNoClient = new System.Windows.Forms.ComboBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.numPrixBas = new System.Windows.Forms.NumericUpDown();
            this.numPrixMoyen = new System.Windows.Forms.NumericUpDown();
            this.numPrixHaut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpSejourDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpSejourFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numNbPers = new System.Windows.Forms.NumericUpDown();
            this.btnAjouterReservationChambre = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            noCLientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixBas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixMoyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixHaut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPers)).BeginInit();
            this.SuspendLayout();
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
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(6, 96);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(53, 25);
            nomLabel.TabIndex = 2;
            nomLabel.Text = "Nom";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Réservation de chambre";
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre";
            this.chambreBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
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
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.cbNoClient);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(prenomLabel);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(noCLientLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 220);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données du client";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenom", true));
            this.tbPrenom.Enabled = false;
            this.tbPrenom.Location = new System.Drawing.Point(126, 142);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(120, 30);
            this.tbPrenom.TabIndex = 8;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
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
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom", true));
            this.tbNom.Enabled = false;
            this.tbNom.Location = new System.Drawing.Point(126, 93);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(120, 30);
            this.tbNom.TabIndex = 8;
            // 
            // numPrixBas
            // 
            this.numPrixBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrixBas.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPrixBas.Location = new System.Drawing.Point(126, 33);
            this.numPrixBas.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrixBas.Name = "numPrixBas";
            this.numPrixBas.Size = new System.Drawing.Size(120, 30);
            this.numPrixBas.TabIndex = 8;
            // 
            // numPrixMoyen
            // 
            this.numPrixMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrixMoyen.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPrixMoyen.Location = new System.Drawing.Point(126, 100);
            this.numPrixMoyen.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrixMoyen.Name = "numPrixMoyen";
            this.numPrixMoyen.Size = new System.Drawing.Size(120, 30);
            this.numPrixMoyen.TabIndex = 9;
            // 
            // numPrixHaut
            // 
            this.numPrixHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrixHaut.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPrixHaut.Location = new System.Drawing.Point(126, 168);
            this.numPrixHaut.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrixHaut.Name = "numPrixHaut";
            this.numPrixHaut.Size = new System.Drawing.Size(120, 30);
            this.numPrixHaut.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prix Bas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prix Moyen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prix Haut";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numPrixBas);
            this.groupBox2.Controls.Add(this.numPrixMoyen);
            this.groupBox2.Controls.Add(this.numPrixHaut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 220);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prix des saisons";
            // 
            // dtpSejourDebut
            // 
            this.dtpSejourDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSejourDebut.Location = new System.Drawing.Point(148, 47);
            this.dtpSejourDebut.Name = "dtpSejourDebut";
            this.dtpSejourDebut.Size = new System.Drawing.Size(200, 30);
            this.dtpSejourDebut.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpSejourFin);
            this.groupBox3.Controls.Add(this.dtpSejourDebut);
            this.groupBox3.Controls.Add(label6);
            this.groupBox3.Controls.Add(label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(272, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 132);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Séjour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 96);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 25);
            label6.TabIndex = 2;
            label6.Text = "Date de fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 50);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(134, 25);
            label7.TabIndex = 0;
            label7.Text = "Date de début";
            // 
            // dtpSejourFin
            // 
            this.dtpSejourFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSejourFin.Location = new System.Drawing.Point(148, 93);
            this.dtpSejourFin.Name = "dtpSejourFin";
            this.dtpSejourFin.Size = new System.Drawing.Size(200, 30);
            this.dtpSejourFin.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numNbPers);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 76);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nombre de personnes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nb de pers.";
            // 
            // numNbPers
            // 
            this.numNbPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbPers.Location = new System.Drawing.Point(126, 33);
            this.numNbPers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numNbPers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNbPers.Name = "numNbPers";
            this.numNbPers.Size = new System.Drawing.Size(120, 30);
            this.numNbPers.TabIndex = 8;
            this.numNbPers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAjouterReservationChambre
            // 
            this.btnAjouterReservationChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterReservationChambre.Location = new System.Drawing.Point(632, 277);
            this.btnAjouterReservationChambre.Name = "btnAjouterReservationChambre";
            this.btnAjouterReservationChambre.Size = new System.Drawing.Size(254, 63);
            this.btnAjouterReservationChambre.TabIndex = 18;
            this.btnAjouterReservationChambre.Text = "Ajouter cette réservation";
            this.btnAjouterReservationChambre.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(632, 350);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(254, 63);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmAjoutReservationChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 425);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterReservationChambre);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutReservationChambre";
            this.Text = "Réservation de chambre";
            this.Load += new System.EventHandler(this.frmAjoutReservationChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixBas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixMoyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixHaut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ComboBox cbNoClient;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.NumericUpDown numPrixBas;
        private System.Windows.Forms.NumericUpDown numPrixMoyen;
        private System.Windows.Forms.NumericUpDown numPrixHaut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpSejourDebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpSejourFin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numNbPers;
        private System.Windows.Forms.Button btnAjouterReservationChambre;
        private System.Windows.Forms.Button btnAnnuler;
    }
}