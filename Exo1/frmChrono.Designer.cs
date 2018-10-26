namespace Exo1
{
    partial class frmChrono
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
            this.lbChrono = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChrono
            // 
            this.tbChrono.Enabled = false;
            this.tbChrono.Location = new System.Drawing.Point(82, 47);
            this.tbChrono.Name = "tbChrono";
            this.tbChrono.Size = new System.Drawing.Size(100, 20);
            this.tbChrono.TabIndex = 1;
            // 
            // lbChrono
            // 
            this.lbChrono.AutoSize = true;
            this.lbChrono.Location = new System.Drawing.Point(16, 50);
            this.lbChrono.Name = "lbChrono";
            this.lbChrono.Size = new System.Drawing.Size(47, 13);
            this.lbChrono.TabIndex = 3;
            this.lbChrono.Text = "Chrono :";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(245, 25);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(245, 65);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // frmChrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 109);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.lbChrono);
            this.Controls.Add(this.tbChrono);
            this.Name = "frmChrono";
            this.Text = "frmChrono";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChrono_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbChrono;
        private System.Windows.Forms.Label lbChrono;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;
    }
}