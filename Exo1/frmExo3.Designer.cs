namespace Exo1
{
    partial class frmExo3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExo3));
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.lstCible = new System.Windows.Forms.ListBox();
            this.btnAjoute = new System.Windows.Forms.Button();
            this.btnAjouteTout = new System.Windows.Forms.Button();
            this.btnSupprime = new System.Windows.Forms.Button();
            this.btnSupprimeTout = new System.Windows.Forms.Button();
            this.btnHaut = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSource
            // 
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(61, 57);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(172, 21);
            this.cbxSource.TabIndex = 0;
            // 
            // lstCible
            // 
            this.lstCible.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.lstCible.FormattingEnabled = true;
            this.lstCible.Location = new System.Drawing.Point(370, 57);
            this.lstCible.Name = "lstCible";
            this.lstCible.Size = new System.Drawing.Size(185, 212);
            this.lstCible.TabIndex = 1;
            // 
            // btnAjoute
            // 
            this.btnAjoute.Location = new System.Drawing.Point(264, 57);
            this.btnAjoute.Name = "btnAjoute";
            this.btnAjoute.Size = new System.Drawing.Size(75, 23);
            this.btnAjoute.TabIndex = 2;
            this.btnAjoute.Text = ">";
            this.btnAjoute.UseVisualStyleBackColor = true;
            this.btnAjoute.Click += new System.EventHandler(this.btnAjoute_Click);
            // 
            // btnAjouteTout
            // 
            this.btnAjouteTout.Location = new System.Drawing.Point(264, 86);
            this.btnAjouteTout.Name = "btnAjouteTout";
            this.btnAjouteTout.Size = new System.Drawing.Size(75, 23);
            this.btnAjouteTout.TabIndex = 3;
            this.btnAjouteTout.Text = ">>";
            this.btnAjouteTout.UseVisualStyleBackColor = true;
            this.btnAjouteTout.Click += new System.EventHandler(this.btnAjouteTout_Click);
            // 
            // btnSupprime
            // 
            this.btnSupprime.Location = new System.Drawing.Point(264, 217);
            this.btnSupprime.Name = "btnSupprime";
            this.btnSupprime.Size = new System.Drawing.Size(75, 23);
            this.btnSupprime.TabIndex = 4;
            this.btnSupprime.Text = "<";
            this.btnSupprime.UseVisualStyleBackColor = true;
            this.btnSupprime.Click += new System.EventHandler(this.btnSupprime_Click);
            // 
            // btnSupprimeTout
            // 
            this.btnSupprimeTout.Location = new System.Drawing.Point(264, 246);
            this.btnSupprimeTout.Name = "btnSupprimeTout";
            this.btnSupprimeTout.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimeTout.TabIndex = 5;
            this.btnSupprimeTout.Text = "<<";
            this.btnSupprimeTout.UseVisualStyleBackColor = true;
            this.btnSupprimeTout.Click += new System.EventHandler(this.btnSupprimeTout_Click);
            // 
            // btnHaut
            // 
            this.btnHaut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHaut.BackgroundImage")));
            this.btnHaut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHaut.Location = new System.Drawing.Point(413, 275);
            this.btnHaut.Name = "btnHaut";
            this.btnHaut.Size = new System.Drawing.Size(39, 35);
            this.btnHaut.TabIndex = 6;
            this.btnHaut.UseVisualStyleBackColor = true;
            // 
            // btnBas
            // 
            this.btnBas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBas.BackgroundImage")));
            this.btnBas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBas.Location = new System.Drawing.Point(471, 275);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(39, 35);
            this.btnBas.TabIndex = 7;
            this.btnBas.UseVisualStyleBackColor = true;
            // 
            // frmExo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 413);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.btnHaut);
            this.Controls.Add(this.btnSupprimeTout);
            this.Controls.Add(this.btnSupprime);
            this.Controls.Add(this.btnAjouteTout);
            this.Controls.Add(this.btnAjoute);
            this.Controls.Add(this.lstCible);
            this.Controls.Add(this.cbxSource);
            this.Name = "frmExo3";
            this.Text = "frmExo3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.ListBox lstCible;
        private System.Windows.Forms.Button btnAjoute;
        private System.Windows.Forms.Button btnAjouteTout;
        private System.Windows.Forms.Button btnSupprime;
        private System.Windows.Forms.Button btnSupprimeTout;
        private System.Windows.Forms.Button btnHaut;
        private System.Windows.Forms.Button btnBas;
    }
}