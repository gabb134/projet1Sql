namespace Projet1BaseDeDonnee3
{
    partial class frmGestionDesAssistantEtSoins
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
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTP1Guelleh_MarreroDataSet = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGestionAssistant = new System.Windows.Forms.Button();
            this.btnGestionSoins = new System.Windows.Forms.Button();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter();
            this.tableAdapterManager = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager();
            this.assistantTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter();
            this.assistantSoinTableAdapter = new Projet1BaseDeDonnee3.BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantSoinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bDTP1Guelleh_MarreroDataSet;
            this.assistantBindingSource.PositionChanged += new System.EventHandler(this.assistantBindingSource_PositionChanged);
            // 
            // bDTP1Guelleh_MarreroDataSet
            // 
            this.bDTP1Guelleh_MarreroDataSet.DataSetName = "BDTP1Guelleh_MarreroDataSet";
            this.bDTP1Guelleh_MarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGestionAssistant);
            this.groupBox1.Controls.Add(this.btnGestionSoins);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des assistants et des soins";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGestionAssistant
            // 
            this.btnGestionAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAssistant.Location = new System.Drawing.Point(19, 38);
            this.btnGestionAssistant.Name = "btnGestionAssistant";
            this.btnGestionAssistant.Size = new System.Drawing.Size(301, 63);
            this.btnGestionAssistant.TabIndex = 4;
            this.btnGestionAssistant.Text = "Gestion des assistant";
            this.btnGestionAssistant.UseVisualStyleBackColor = true;
            this.btnGestionAssistant.Click += new System.EventHandler(this.btnGestionAssistant_Click);
            // 
            // btnGestionSoins
            // 
            this.btnGestionSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionSoins.Location = new System.Drawing.Point(19, 139);
            this.btnGestionSoins.Name = "btnGestionSoins";
            this.btnGestionSoins.Size = new System.Drawing.Size(301, 63);
            this.btnGestionSoins.TabIndex = 5;
            this.btnGestionSoins.Text = "Gestion des soins";
            this.btnGestionSoins.UseVisualStyleBackColor = true;
            this.btnGestionSoins.Click += new System.EventHandler(this.btnGestionSoins_Click);
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "FK__Assistant__NoAss__446B1014";
            this.assistantSoinBindingSource.DataSource = this.assistantBindingSource;
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
            this.tableAdapterManager.AssistantTableAdapter = this.assistantTableAdapter;
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
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // frmGestionDesAssistantEtSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 252);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGestionDesAssistantEtSoins";
            this.Text = "Gestion des assistant et des soins";
            this.Load += new System.EventHandler(this.frmGererAssistantEtSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTP1Guelleh_MarreroDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDTP1Guelleh_MarreroDataSet bDTP1Guelleh_MarreroDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGestionAssistant;
        private System.Windows.Forms.Button btnGestionSoins;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private BDTP1Guelleh_MarreroDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter;
    }
}