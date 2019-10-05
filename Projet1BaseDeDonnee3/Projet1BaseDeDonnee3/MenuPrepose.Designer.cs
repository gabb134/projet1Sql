namespace Projet1BaseDeDonnee3
{
    partial class MenuPrepose
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsPréposésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réserverDesChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitterPrepose = new System.Windows.Forms.Button();
            this.btnDeconnexionPrepose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsPréposésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsPréposésToolStripMenuItem
            // 
            this.optionsPréposésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem,
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem,
            this.réserverDesChambresToolStripMenuItem});
            this.optionsPréposésToolStripMenuItem.Name = "optionsPréposésToolStripMenuItem";
            this.optionsPréposésToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.optionsPréposésToolStripMenuItem.Text = "Options préposés";
            // 
            // gérerLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Name = "gérerLesClientsEtLeursInvitésToolStripMenuItem";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Text = "Gérer les clients et leurs invités";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Click += new System.EventHandler(this.GérerLesClientsEtLeursInvitésToolStripMenuItem_Click);
            // 
            // planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Name = "planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem";
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Text = "Planifier des soins pour les clients et leurs invités";
            // 
            // réserverDesChambresToolStripMenuItem
            // 
            this.réserverDesChambresToolStripMenuItem.Name = "réserverDesChambresToolStripMenuItem";
            this.réserverDesChambresToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.réserverDesChambresToolStripMenuItem.Text = "Réserver des chambres ";
            this.réserverDesChambresToolStripMenuItem.Click += new System.EventHandler(this.réserverDesChambresToolStripMenuItem_Click);
            // 
            // btnQuitterPrepose
            // 
            this.btnQuitterPrepose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterPrepose.Location = new System.Drawing.Point(165, 59);
            this.btnQuitterPrepose.Name = "btnQuitterPrepose";
            this.btnQuitterPrepose.Size = new System.Drawing.Size(128, 43);
            this.btnQuitterPrepose.TabIndex = 6;
            this.btnQuitterPrepose.Text = "Quitter";
            this.btnQuitterPrepose.UseVisualStyleBackColor = true;
            this.btnQuitterPrepose.Click += new System.EventHandler(this.btnQuitterPrepose_Click);
            // 
            // btnDeconnexionPrepose
            // 
            this.btnDeconnexionPrepose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexionPrepose.Location = new System.Drawing.Point(26, 59);
            this.btnDeconnexionPrepose.Name = "btnDeconnexionPrepose";
            this.btnDeconnexionPrepose.Size = new System.Drawing.Size(128, 43);
            this.btnDeconnexionPrepose.TabIndex = 5;
            this.btnDeconnexionPrepose.Text = "Deconnexion";
            this.btnDeconnexionPrepose.UseVisualStyleBackColor = true;
            this.btnDeconnexionPrepose.Click += new System.EventHandler(this.btnDeconnexionPrepose_Click);
            // 
            // MenuPrepose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 155);
            this.Controls.Add(this.btnQuitterPrepose);
            this.Controls.Add(this.btnDeconnexionPrepose);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrepose";
            this.Text = "Le menu des préposés";
            this.Load += new System.EventHandler(this.MenuPrepose_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnQuitterPrepose;
        private System.Windows.Forms.Button btnDeconnexionPrepose;
        private System.Windows.Forms.ToolStripMenuItem optionsPréposésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réserverDesChambresToolStripMenuItem;
    }
}