namespace Exo1
{
    partial class Appli2
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRetablir = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxVitesse = new System.Windows.Forms.ComboBox();
            this.cbxTemperature = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.tbVitesse = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.lbVitesse = new System.Windows.Forms.Label();
            this.lbTempérature = new System.Windows.Forms.Label();
            this.gbxParametre = new System.Windows.Forms.GroupBox();
            this.gbxParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(302, 219);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRetablir
            // 
            this.btnRetablir.Location = new System.Drawing.Point(302, 180);
            this.btnRetablir.Name = "btnRetablir";
            this.btnRetablir.Size = new System.Drawing.Size(75, 23);
            this.btnRetablir.TabIndex = 20;
            this.btnRetablir.Text = "Rétablir";
            this.btnRetablir.UseVisualStyleBackColor = true;
            this.btnRetablir.Click += new System.EventHandler(this.btnRetablir_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(302, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxVitesse
            // 
            this.cbxVitesse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVitesse.FormattingEnabled = true;
            this.cbxVitesse.Location = new System.Drawing.Point(184, 32);
            this.cbxVitesse.Name = "cbxVitesse";
            this.cbxVitesse.Size = new System.Drawing.Size(193, 21);
            this.cbxVitesse.TabIndex = 22;
            this.cbxVitesse.SelectedIndexChanged += new System.EventHandler(this.cbxVitesse_SelectedIndexChanged);
            // 
            // cbxTemperature
            // 
            this.cbxTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTemperature.FormattingEnabled = true;
            this.cbxTemperature.Location = new System.Drawing.Point(184, 67);
            this.cbxTemperature.Name = "cbxTemperature";
            this.cbxTemperature.Size = new System.Drawing.Size(193, 21);
            this.cbxTemperature.TabIndex = 23;
            this.cbxTemperature.SelectedIndexChanged += new System.EventHandler(this.cbxTemperature_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Choisir une vitesse :";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(51, 70);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(124, 13);
            this.lbTemp.TabIndex = 25;
            this.lbTemp.Text = "Choisir une température :";
            // 
            // tbVitesse
            // 
            this.tbVitesse.Enabled = false;
            this.tbVitesse.Location = new System.Drawing.Point(100, 27);
            this.tbVitesse.Name = "tbVitesse";
            this.tbVitesse.Size = new System.Drawing.Size(100, 20);
            this.tbVitesse.TabIndex = 26;
            // 
            // tbTemperature
            // 
            this.tbTemperature.Enabled = false;
            this.tbTemperature.Location = new System.Drawing.Point(100, 63);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(100, 20);
            this.tbTemperature.TabIndex = 27;
            // 
            // lbVitesse
            // 
            this.lbVitesse.AutoSize = true;
            this.lbVitesse.Location = new System.Drawing.Point(6, 30);
            this.lbVitesse.Name = "lbVitesse";
            this.lbVitesse.Size = new System.Drawing.Size(47, 13);
            this.lbVitesse.TabIndex = 28;
            this.lbVitesse.Text = "Vitesse :";
            // 
            // lbTempérature
            // 
            this.lbTempérature.AutoSize = true;
            this.lbTempérature.Location = new System.Drawing.Point(6, 66);
            this.lbTempérature.Name = "lbTempérature";
            this.lbTempérature.Size = new System.Drawing.Size(73, 13);
            this.lbTempérature.TabIndex = 29;
            this.lbTempérature.Text = "Température :";
            // 
            // gbxParametre
            // 
            this.gbxParametre.Controls.Add(this.lbTempérature);
            this.gbxParametre.Controls.Add(this.lbVitesse);
            this.gbxParametre.Controls.Add(this.tbTemperature);
            this.gbxParametre.Controls.Add(this.tbVitesse);
            this.gbxParametre.Location = new System.Drawing.Point(12, 141);
            this.gbxParametre.Name = "gbxParametre";
            this.gbxParametre.Size = new System.Drawing.Size(231, 101);
            this.gbxParametre.TabIndex = 30;
            this.gbxParametre.TabStop = false;
            this.gbxParametre.Text = "Paramètres retenus :";
            // 
            // Appli2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 276);
            this.Controls.Add(this.gbxParametre);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTemperature);
            this.Controls.Add(this.cbxVitesse);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetablir);
            this.Controls.Add(this.btnOK);
            this.Name = "Appli2";
            this.Text = "Appli2";
            this.gbxParametre.ResumeLayout(false);
            this.gbxParametre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRetablir;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxVitesse;
        private System.Windows.Forms.ComboBox cbxTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.TextBox tbVitesse;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label lbVitesse;
        private System.Windows.Forms.Label lbTempérature;
        private System.Windows.Forms.GroupBox gbxParametre;
    }
}