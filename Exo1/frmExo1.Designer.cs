namespace Exo1
{
    partial class FrmExo1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.btnRecopier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copie :";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(24, 43);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(48, 13);
            this.lblOriginal.TabIndex = 1;
            this.lblOriginal.Text = "Original :";
            // 
            // btnRecopier
            // 
            this.btnRecopier.Location = new System.Drawing.Point(678, 26);
            this.btnRecopier.Name = "btnRecopier";
            this.btnRecopier.Size = new System.Drawing.Size(75, 23);
            this.btnRecopier.TabIndex = 2;
            this.btnRecopier.Text = "Recopier";
            this.btnRecopier.UseVisualStyleBackColor = true;
            this.btnRecopier.Click += new System.EventHandler(this.btnRecopier_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEffacer.Location = new System.Drawing.Point(678, 67);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 3;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(678, 106);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultat.Location = new System.Drawing.Point(104, 90);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(284, 20);
            this.lblResultat.TabIndex = 5;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(97, 43);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(284, 20);
            this.txtOriginal.TabIndex = 6;
            this.txtOriginal.Enter += new System.EventHandler(this.txtOriginal_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exo.2.A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "exo.2.B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "exo.3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmExo1
            // 
            this.AcceptButton = this.btnRecopier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEffacer;
            this.ClientSize = new System.Drawing.Size(781, 170);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnRecopier);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.label1);
            this.Name = "FrmExo1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExo1_FormClosing);
            this.Load += new System.EventHandler(this.FrmExo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Button btnRecopier;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

