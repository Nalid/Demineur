﻿namespace Demineur
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
            this.tsmPartie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJouer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDebutant = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntermediaire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.tsmDebutant.Size = new System.Drawing.Size(144, 22);
            this.tsmDebutant.Text = "Débutant";
            // 
            // tsmIntermediaire
            // 
            this.tsmIntermediaire.Name = "tsmIntermediaire";
            this.tsmIntermediaire.Size = new System.Drawing.Size(144, 22);
            this.tsmIntermediaire.Text = "Intermédiaire";
            // 
            // tsmExpert
            // 
            this.tsmExpert.Name = "tsmExpert";
            this.tsmExpert.Size = new System.Drawing.Size(144, 22);
            this.tsmExpert.Text = "Expert";
            // 
            // tsmCustom
            // 
            this.tsmCustom.Name = "tsmCustom";
            this.tsmCustom.Size = new System.Drawing.Size(144, 22);
            this.tsmCustom.Text = "Personnaliser";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(152, 22);
            this.tsmExit.Text = "Quitter";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAide,
            this.tsmPropos});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // tsmAide
            // 
            this.tsmAide.Name = "tsmAide";
            this.tsmAide.Size = new System.Drawing.Size(122, 22);
            this.tsmAide.Text = "Aide";
            this.tsmAide.Click += new System.EventHandler(this.tsmAide_Click);
            // 
            // tsmPropos
            // 
            this.tsmPropos.Name = "tsmPropos";
            this.tsmPropos.Size = new System.Drawing.Size(122, 22);
            this.tsmPropos.Text = "A propos";
            this.tsmPropos.Click += new System.EventHandler(this.tsmPropos_Click);
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPartie,
            this.toolStripMenuItem1});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(806, 24);
            this.mspMenu.TabIndex = 2;
            this.mspMenu.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 539);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmPartie;
        private System.Windows.Forms.ToolStripMenuItem tsmJouer;
        private System.Windows.Forms.ToolStripMenuItem tsmDebutant;
        private System.Windows.Forms.ToolStripMenuItem tsmIntermediaire;
        private System.Windows.Forms.ToolStripMenuItem tsmExpert;
        private System.Windows.Forms.ToolStripMenuItem tsmCustom;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAide;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmPropos;
        private System.Windows.Forms.Timer timer1;


    }
}

