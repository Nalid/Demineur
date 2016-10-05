namespace WindowsFormsApplication1
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
            this.lblHorlogeUp = new System.Windows.Forms.Label();
            this.timUp = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorlogeUp
            // 
            this.lblHorlogeUp.AutoSize = true;
            this.lblHorlogeUp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorlogeUp.Location = new System.Drawing.Point(132, 55);
            this.lblHorlogeUp.Name = "lblHorlogeUp";
            this.lblHorlogeUp.Size = new System.Drawing.Size(49, 29);
            this.lblHorlogeUp.TabIndex = 0;
            this.lblHorlogeUp.Text = "151";
            this.lblHorlogeUp.Click += new System.EventHandler(this.lblHorlogeUp_Click);
            // 
            // timUp
            // 
            this.timUp.Enabled = true;
            this.timUp.Interval = 1000;
            this.timUp.Tick += new System.EventHandler(this.timUp_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.horloge;
            this.pictureBox1.Location = new System.Drawing.Point(85, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timDown
            // 
            this.timDown.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 185);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHorlogeUp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorlogeUp;
        private System.Windows.Forms.Timer timUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timDown;
    }
}

