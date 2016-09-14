namespace Demineur
{
    partial class Form1
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

            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.tsmPartie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJouer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDebutant = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntermediaire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.commentJouerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPartie,
            this.toolStripMenuItem1});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(384, 24);
            this.mspMenu.TabIndex = 2;
            this.mspMenu.Text = "menuStrip1";
            // 
            // tsmPartie
            // 
            this.tsmPartie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmJouer,
            this.tsmExit});
            this.tsmPartie.Name = "tsmPartie";
            this.tsmPartie.Size = new System.Drawing.Size(49, 20);
            this.tsmPartie.Text = "Partie";
            // 
            // tsmJouer
            // 
            this.tsmJouer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDebutant,
            this.tsmIntermediaire,
            this.tsmExpert,
            this.tsmCustom});
            this.tsmJouer.Name = "tsmJouer";
            this.tsmJouer.Size = new System.Drawing.Size(152, 22);
            this.tsmJouer.Text = "Jouer";
            // 
            // tsmDebutant
            // 
            this.tsmDebutant.Name = "tsmDebutant";
            this.tsmDebutant.Size = new System.Drawing.Size(152, 22);
            this.tsmDebutant.Text = "Débutant";
            // 
            // tsmIntermediaire
            // 
            this.tsmIntermediaire.Name = "tsmIntermediaire";
            this.tsmIntermediaire.Size = new System.Drawing.Size(152, 22);
            this.tsmIntermediaire.Text = "Intermediaire";
            // 
            // tsmExpert
            // 
            this.tsmExpert.Name = "tsmExpert";
            this.tsmExpert.Size = new System.Drawing.Size(152, 22);
            this.tsmExpert.Text = "Expert";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentJouerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // tsmCustom
            // 
            this.tsmCustom.Name = "tsmCustom";
            this.tsmCustom.Size = new System.Drawing.Size(152, 22);
            this.tsmCustom.Text = "Custom";
            this.tsmCustom.Click += new System.EventHandler(this.tsmCustom_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(152, 22);
            this.tsmExit.Text = "Exit";
            // 
            // commentJouerToolStripMenuItem
            // 
            this.commentJouerToolStripMenuItem.Name = "commentJouerToolStripMenuItem";
            this.commentJouerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.commentJouerToolStripMenuItem.Text = "Comment jouer";
            // 

            this.SuspendLayout();
            // 

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Form1";
            this.Text = "Démineur";
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.ClientSize = new System.Drawing.Size(738, 447);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmPartie;
        private System.Windows.Forms.ToolStripMenuItem tsmJouer;
        private System.Windows.Forms.ToolStripMenuItem tsmDebutant;
        private System.Windows.Forms.ToolStripMenuItem tsmIntermediaire;
        private System.Windows.Forms.ToolStripMenuItem tsmExpert;
        private System.Windows.Forms.ToolStripMenuItem tsmCustom;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commentJouerToolStripMenuItem;

    }
}

