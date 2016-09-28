namespace Demineur
{
    partial class Form2
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
            this.tbxRules1 = new System.Windows.Forms.TextBox();
            this.tbxRules2 = new System.Windows.Forms.TextBox();
            this.tbxRules3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRules1
            // 
            this.tbxRules1.BackColor = System.Drawing.SystemColors.Control;
            this.tbxRules1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRules1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRules1.Location = new System.Drawing.Point(68, 12);
            this.tbxRules1.Multiline = true;
            this.tbxRules1.Name = "tbxRules1";
            this.tbxRules1.ReadOnly = true;
            this.tbxRules1.Size = new System.Drawing.Size(180, 51);
            this.tbxRules1.TabIndex = 0;
            this.tbxRules1.Text = "Le but du jeu est de découvrir toutes les cases libres sans faire exploser les mi" +
    "nes.";
            // 
            // tbxRules2
            // 
            this.tbxRules2.BackColor = System.Drawing.SystemColors.Control;
            this.tbxRules2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRules2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRules2.Location = new System.Drawing.Point(12, 69);
            this.tbxRules2.Multiline = true;
            this.tbxRules2.Name = "tbxRules2";
            this.tbxRules2.ReadOnly = true;
            this.tbxRules2.Size = new System.Drawing.Size(236, 41);
            this.tbxRules2.TabIndex = 1;
            this.tbxRules2.Text = "Pour libérer une case, faire un clic gauche (clic normal)";
            // 
            // tbxRules3
            // 
            this.tbxRules3.BackColor = System.Drawing.SystemColors.Control;
            this.tbxRules3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRules3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRules3.Location = new System.Drawing.Point(12, 186);
            this.tbxRules3.Multiline = true;
            this.tbxRules3.Name = "tbxRules3";
            this.tbxRules3.ReadOnly = true;
            this.tbxRules3.Size = new System.Drawing.Size(236, 44);
            this.tbxRules3.TabIndex = 2;
            this.tbxRules3.Text = "Le compteur en haut à gauche indique le nombre de mines qu\'il reste à trouver.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(265, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 68);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Le chiffre qui s\'affiche sur les cases cliquées indique le nombre de mines se tro" +
    "uvant à proximité : à gauche ou à droite, en haut ou en bas, ou en diagonale.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demineur.Properties.Resources.mine;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demineur.Properties.Resources.Flag;
            this.pictureBox2.Location = new System.Drawing.Point(12, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(68, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(180, 50);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Pour marquer une mine, faire un clic droit, qui fera apparaître un drapeau.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Demineur.Properties.Resources.exemple;
            this.pictureBox3.Location = new System.Drawing.Point(265, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 228);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbxRules3);
            this.Controls.Add(this.tbxRules2);
            this.Controls.Add(this.tbxRules1);
            this.Name = "Form2";
            this.Text = "Aide";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRules1;
        private System.Windows.Forms.TextBox tbxRules2;
        private System.Windows.Forms.TextBox tbxRules3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}