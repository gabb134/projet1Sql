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
            this.dtpSejourDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpSejourFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numNbPers = new System.Windows.Forms.NumericUpDown();
            this.btnAjouterReservationChambre = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.getChambreForReservationChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getChambreForReservationChambreTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.getChambreForReservationChambreTableAdapter();
            this.getChambreForReservationChambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            noCLientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getChambreForReservationChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getChambreForReservationChambreDataGridView)).BeginInit();
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
            this.btnAjouterReservationChambre.Location = new System.Drawing.Point(657, 281);
            this.btnAjouterReservationChambre.Name = "btnAjouterReservationChambre";
            this.btnAjouterReservationChambre.Size = new System.Drawing.Size(254, 63);
            this.btnAjouterReservationChambre.TabIndex = 18;
            this.btnAjouterReservationChambre.Text = "Ajouter cette réservation";
            this.btnAjouterReservationChambre.UseVisualStyleBackColor = true;
            this.btnAjouterReservationChambre.Click += new System.EventHandler(this.btnAjouterReservationChambre_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(657, 358);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(254, 63);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // getChambreForReservationChambreBindingSource
            // 
            this.getChambreForReservationChambreBindingSource.DataMember = "getChambreForReservationChambre";
            this.getChambreForReservationChambreBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            // 
            // getChambreForReservationChambreTableAdapter
            // 
            this.getChambreForReservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // getChambreForReservationChambreDataGridView
            // 
            this.getChambreForReservationChambreDataGridView.AutoGenerateColumns = false;
            this.getChambreForReservationChambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getChambreForReservationChambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.getChambreForReservationChambreDataGridView.DataSource = this.getChambreForReservationChambreBindingSource;
            this.getChambreForReservationChambreDataGridView.Location = new System.Drawing.Point(272, 55);
            this.getChambreForReservationChambreDataGridView.Name = "getChambreForReservationChambreDataGridView";
            this.getChambreForReservationChambreDataGridView.Size = new System.Drawing.Size(639, 220);
            this.getChambreForReservationChambreDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoChambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoChambre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Emplacement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Decorations";
            this.dataGridViewTextBoxColumn3.HeaderText = "Decorations";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrixHaut";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrixHaut";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrixBas";
            this.dataGridViewTextBoxColumn5.HeaderText = "PrixBas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PrixMoyen";
            this.dataGridViewTextBoxColumn6.HeaderText = "PrixMoyen";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmAjoutReservationChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 433);
            this.Controls.Add(this.getChambreForReservationChambreDataGridView);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterReservationChambre);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getChambreForReservationChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getChambreForReservationChambreDataGridView)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpSejourDebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpSejourFin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numNbPers;
        private System.Windows.Forms.Button btnAjouterReservationChambre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource getChambreForReservationChambreBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.getChambreForReservationChambreTableAdapter getChambreForReservationChambreTableAdapter;
        private System.Windows.Forms.DataGridView getChambreForReservationChambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}