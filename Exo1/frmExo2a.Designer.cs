namespace Exo1
{
    partial class frmExo2a
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtRouge = new System.Windows.Forms.RadioButton();
            this.rbtVert = new System.Windows.Forms.RadioButton();
            this.rbtBleu = new System.Windows.Forms.RadioButton();
            this.gbxCouleur = new System.Windows.Forms.GroupBox();
            this.gbxCouleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("French Script MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Démonstration des cases à cocher et des boutons d\'options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("French Script MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(24, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 26);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Modifier la couleur";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("French Script MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 123);
            this.label2.TabIndex = 2;
            this.label2.Text = "La couleur choisie";
            // 
            // rbtRouge
            // 
            this.rbtRouge.AutoSize = true;
            this.rbtRouge.Location = new System.Drawing.Point(16, 28);
            this.rbtRouge.Name = "rbtRouge";
            this.rbtRouge.Size = new System.Drawing.Size(67, 26);
            this.rbtRouge.TabIndex = 3;
            this.rbtRouge.TabStop = true;
            this.rbtRouge.Text = "&Rouge";
            this.rbtRouge.UseVisualStyleBackColor = true;
            // 
            // rbtVert
            // 
            this.rbtVert.AutoSize = true;
            this.rbtVert.Location = new System.Drawing.Point(18, 60);
            this.rbtVert.Name = "rbtVert";
            this.rbtVert.Size = new System.Drawing.Size(55, 26);
            this.rbtVert.TabIndex = 4;
            this.rbtVert.TabStop = true;
            this.rbtVert.Text = "&Vert";
            this.rbtVert.UseVisualStyleBackColor = true;
            // 
            // rbtBleu
            // 
            this.rbtBleu.AutoSize = true;
            this.rbtBleu.Location = new System.Drawing.Point(18, 91);
            this.rbtBleu.Name = "rbtBleu";
            this.rbtBleu.Size = new System.Drawing.Size(57, 26);
            this.rbtBleu.TabIndex = 5;
            this.rbtBleu.TabStop = true;
            this.rbtBleu.Text = "&Bleu";
            this.rbtBleu.UseVisualStyleBackColor = true;
            // 
            // gbxCouleur
            // 
            this.gbxCouleur.Controls.Add(this.rbtBleu);
            this.gbxCouleur.Controls.Add(this.rbtVert);
            this.gbxCouleur.Controls.Add(this.rbtRouge);
            this.gbxCouleur.Font = new System.Drawing.Font("French Script MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCouleur.Location = new System.Drawing.Point(251, 274);
            this.gbxCouleur.Name = "gbxCouleur";
            this.gbxCouleur.Size = new System.Drawing.Size(127, 119);
            this.gbxCouleur.TabIndex = 6;
            this.gbxCouleur.TabStop = false;
            this.gbxCouleur.Text = "Couleur";
            this.gbxCouleur.Visible = false;
            // 
            // frmExo2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 417);
            this.Controls.Add(this.gbxCouleur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmExo2a";
            this.Text = "Exercice 2a : Couleurs";
            this.gbxCouleur.ResumeLayout(false);
            this.gbxCouleur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtRouge;
        private System.Windows.Forms.RadioButton rbtVert;
        private System.Windows.Forms.RadioButton rbtBleu;
        private System.Windows.Forms.GroupBox gbxCouleur;
    }
}