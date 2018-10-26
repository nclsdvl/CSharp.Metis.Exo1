namespace Exo1
{
    partial class frmPrinc
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
            this.tbChrono = new System.Windows.Forms.TextBox();
            this.tbAleatoire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChrono
            // 
            this.tbChrono.Enabled = false;
            this.tbChrono.Location = new System.Drawing.Point(202, 32);
            this.tbChrono.Name = "tbChrono";
            this.tbChrono.Size = new System.Drawing.Size(296, 20);
            this.tbChrono.TabIndex = 0;
            // 
            // tbAleatoire
            // 
            this.tbAleatoire.Enabled = false;
            this.tbAleatoire.Location = new System.Drawing.Point(202, 93);
            this.tbAleatoire.Name = "tbAleatoire";
            this.tbAleatoire.Size = new System.Drawing.Size(295, 20);
            this.tbAleatoire.TabIndex = 1;
            this.tbAleatoire.TextChanged += new System.EventHandler(this.tbAleatoire_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chrono :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Aléatoire :";
            // 
            // frmPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAleatoire);
            this.Controls.Add(this.tbChrono);
            this.Name = "frmPrinc";
            this.Text = "frmPrinc";
            this.Load += new System.EventHandler(this.frmPrinc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbChrono;
        public System.Windows.Forms.TextBox tbAleatoire;
    }
}