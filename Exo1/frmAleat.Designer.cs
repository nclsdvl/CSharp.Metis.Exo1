namespace Exo1
{
    partial class frmAleat
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
            this.lbNbr = new System.Windows.Forms.Label();
            this.tbNbrA = new System.Windows.Forms.TextBox();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNbr
            // 
            this.lbNbr.AutoSize = true;
            this.lbNbr.Location = new System.Drawing.Point(29, 62);
            this.lbNbr.Name = "lbNbr";
            this.lbNbr.Size = new System.Drawing.Size(94, 13);
            this.lbNbr.TabIndex = 1;
            this.lbNbr.Text = "Nombre Aléatoire :";
            // 
            // tbNbrA
            // 
            this.tbNbrA.Enabled = false;
            this.tbNbrA.Location = new System.Drawing.Point(144, 59);
            this.tbNbrA.Name = "tbNbrA";
            this.tbNbrA.Size = new System.Drawing.Size(167, 20);
            this.tbNbrA.TabIndex = 2;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(431, 30);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 3;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(431, 86);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmAleat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 146);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.tbNbrA);
            this.Controls.Add(this.lbNbr);
            this.Name = "frmAleat";
            this.Text = "frmAleat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAleat_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNbr;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;
        public System.Windows.Forms.TextBox tbNbrA;
    }
}