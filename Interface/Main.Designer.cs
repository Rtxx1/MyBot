namespace MyBot
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dofusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mITMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activerMitm = new System.Windows.Forms.ToolStripMenuItem();
            this.desactiverMitm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.mITMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.dofusToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleToolStripMenuItem.Image")));
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // dofusToolStripMenuItem
            // 
            this.dofusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dofusToolStripMenuItem.Image")));
            this.dofusToolStripMenuItem.Name = "dofusToolStripMenuItem";
            this.dofusToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dofusToolStripMenuItem.Text = "Dofus";
            this.dofusToolStripMenuItem.Click += new System.EventHandler(this.dofusToolStripMenuItem_Click);
            // 
            // mITMToolStripMenuItem
            // 
            this.mITMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activerMitm,
            this.desactiverMitm});
            this.mITMToolStripMenuItem.Name = "mITMToolStripMenuItem";
            this.mITMToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.mITMToolStripMenuItem.Text = "MITM";
            // 
            // activerMitm
            // 
            this.activerMitm.Name = "activerMitm";
            this.activerMitm.Size = new System.Drawing.Size(128, 22);
            this.activerMitm.Text = "Activer";
            this.activerMitm.Click += new System.EventHandler(this.activerToolStripMenuItem_Click);
            // 
            // desactiverMitm
            // 
            this.desactiverMitm.Name = "desactiverMitm";
            this.desactiverMitm.Size = new System.Drawing.Size(128, 22);
            this.desactiverMitm.Text = "Desactiver";
            this.desactiverMitm.Click += new System.EventHandler(this.desactiverToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 585);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MyBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mITMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activerMitm;
        private System.Windows.Forms.ToolStripMenuItem desactiverMitm;
        private System.Windows.Forms.ToolStripMenuItem dofusToolStripMenuItem;
    }
}

