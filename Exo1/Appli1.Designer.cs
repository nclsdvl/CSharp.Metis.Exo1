namespace Exo1
{
    partial class Appli1
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
            this.rbTour100 = new System.Windows.Forms.RadioButton();
            this.rbTour200 = new System.Windows.Forms.RadioButton();
            this.rbTour300 = new System.Windows.Forms.RadioButton();
            this.rbTour500 = new System.Windows.Forms.RadioButton();
            this.gbxVitesse = new System.Windows.Forms.GroupBox();
            this.rbTemp50 = new System.Windows.Forms.RadioButton();
            this.rbTemp80 = new System.Windows.Forms.RadioButton();
            this.rbTemp100 = new System.Windows.Forms.RadioButton();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRetablir = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tbVitesse = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.lbVitesse = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.gbxParametres = new System.Windows.Forms.GroupBox();
            this.gbxVitesse.SuspendLayout();
            this.gbxTemp.SuspendLayout();
            this.gbxParametres.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTour100
            // 
            this.rbTour100.AutoSize = true;
            this.rbTour100.Location = new System.Drawing.Point(28, 29);
            this.rbTour100.Name = "rbTour100";
            this.rbTour100.Size = new System.Drawing.Size(43, 17);
            this.rbTour100.TabIndex = 0;
            this.rbTour100.TabStop = true;
            this.rbTour100.Text = "100";
            this.rbTour100.UseVisualStyleBackColor = true;
            // 
            // rbTour200
            // 
            this.rbTour200.AutoSize = true;
            this.rbTour200.Location = new System.Drawing.Point(89, 29);
            this.rbTour200.Name = "rbTour200";
            this.rbTour200.Size = new System.Drawing.Size(43, 17);
            this.rbTour200.TabIndex = 1;
            this.rbTour200.TabStop = true;
            this.rbTour200.Text = "200";
            this.rbTour200.UseVisualStyleBackColor = true;
            // 
            // rbTour300
            // 
            this.rbTour300.AutoSize = true;
            this.rbTour300.Location = new System.Drawing.Point(150, 29);
            this.rbTour300.Name = "rbTour300";
            this.rbTour300.Size = new System.Drawing.Size(43, 17);
            this.rbTour300.TabIndex = 2;
            this.rbTour300.TabStop = true;
            this.rbTour300.Text = "300";
            this.rbTour300.UseVisualStyleBackColor = true;
            // 
            // rbTour500
            // 
            this.rbTour500.AutoSize = true;
            this.rbTour500.Location = new System.Drawing.Point(209, 29);
            this.rbTour500.Name = "rbTour500";
            this.rbTour500.Size = new System.Drawing.Size(43, 17);
            this.rbTour500.TabIndex = 3;
            this.rbTour500.TabStop = true;
            this.rbTour500.Text = "500";
            this.rbTour500.UseVisualStyleBackColor = true;
            // 
            // gbxVitesse
            // 
            this.gbxVitesse.Controls.Add(this.rbTour500);
            this.gbxVitesse.Controls.Add(this.rbTour300);
            this.gbxVitesse.Controls.Add(this.rbTour200);
            this.gbxVitesse.Controls.Add(this.rbTour100);
            this.gbxVitesse.Location = new System.Drawing.Point(19, 29);
            this.gbxVitesse.Name = "gbxVitesse";
            this.gbxVitesse.Size = new System.Drawing.Size(288, 75);
            this.gbxVitesse.TabIndex = 4;
            this.gbxVitesse.TabStop = false;
            this.gbxVitesse.Text = "Vitesse du mélangeur en tours par minute :";
            // 
            // rbTemp50
            // 
            this.rbTemp50.AutoSize = true;
            this.rbTemp50.Location = new System.Drawing.Point(6, 27);
            this.rbTemp50.Name = "rbTemp50";
            this.rbTemp50.Size = new System.Drawing.Size(37, 17);
            this.rbTemp50.TabIndex = 5;
            this.rbTemp50.TabStop = true;
            this.rbTemp50.Text = "50";
            this.rbTemp50.UseVisualStyleBackColor = true;
            // 
            // rbTemp80
            // 
            this.rbTemp80.AutoSize = true;
            this.rbTemp80.Location = new System.Drawing.Point(64, 27);
            this.rbTemp80.Name = "rbTemp80";
            this.rbTemp80.Size = new System.Drawing.Size(37, 17);
            this.rbTemp80.TabIndex = 6;
            this.rbTemp80.TabStop = true;
            this.rbTemp80.Text = "80";
            this.rbTemp80.UseVisualStyleBackColor = true;
            // 
            // rbTemp100
            // 
            this.rbTemp100.AutoSize = true;
            this.rbTemp100.Location = new System.Drawing.Point(118, 27);
            this.rbTemp100.Name = "rbTemp100";
            this.rbTemp100.Size = new System.Drawing.Size(43, 17);
            this.rbTemp100.TabIndex = 7;
            this.rbTemp100.TabStop = true;
            this.rbTemp100.Text = "100";
            this.rbTemp100.UseVisualStyleBackColor = true;
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.rbTemp80);
            this.gbxTemp.Controls.Add(this.rbTemp100);
            this.gbxTemp.Controls.Add(this.rbTemp50);
            this.gbxTemp.Location = new System.Drawing.Point(19, 133);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(202, 72);
            this.gbxTemp.TabIndex = 8;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "Température du mélangeur :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(325, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRetablir
            // 
            this.btnRetablir.Location = new System.Drawing.Point(325, 300);
            this.btnRetablir.Name = "btnRetablir";
            this.btnRetablir.Size = new System.Drawing.Size(75, 23);
            this.btnRetablir.TabIndex = 10;
            this.btnRetablir.Text = "Rétablir";
            this.btnRetablir.UseVisualStyleBackColor = true;
            this.btnRetablir.Click += new System.EventHandler(this.btnRetablir_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(325, 339);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // tbVitesse
            // 
            this.tbVitesse.Location = new System.Drawing.Point(80, 22);
            this.tbVitesse.Name = "tbVitesse";
            this.tbVitesse.Size = new System.Drawing.Size(100, 20);
            this.tbVitesse.TabIndex = 12;
            this.tbVitesse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(80, 57);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(100, 20);
            this.tbTemperature.TabIndex = 13;
            // 
            // lbVitesse
            // 
            this.lbVitesse.AutoSize = true;
            this.lbVitesse.Location = new System.Drawing.Point(27, 25);
            this.lbVitesse.Name = "lbVitesse";
            this.lbVitesse.Size = new System.Drawing.Size(47, 13);
            this.lbVitesse.TabIndex = 14;
            this.lbVitesse.Text = "Vitesse :";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(4, 60);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(73, 13);
            this.lbTemperature.TabIndex = 15;
            this.lbTemperature.Text = "Température :";
            // 
            // gbxParametres
            // 
            this.gbxParametres.Controls.Add(this.lbTemperature);
            this.gbxParametres.Controls.Add(this.lbVitesse);
            this.gbxParametres.Controls.Add(this.tbTemperature);
            this.gbxParametres.Controls.Add(this.tbVitesse);
            this.gbxParametres.Location = new System.Drawing.Point(12, 239);
            this.gbxParametres.Name = "gbxParametres";
            this.gbxParametres.Size = new System.Drawing.Size(199, 113);
            this.gbxParametres.TabIndex = 16;
            this.gbxParametres.TabStop = false;
            this.gbxParametres.Text = "Paramètres retenus :";
            // 
            // Appli1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 385);
            this.Controls.Add(this.gbxParametres);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetablir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxTemp);
            this.Controls.Add(this.gbxVitesse);
            this.Name = "Appli1";
            this.Text = "Appli1";
            this.gbxVitesse.ResumeLayout(false);
            this.gbxVitesse.PerformLayout();
            this.gbxTemp.ResumeLayout(false);
            this.gbxTemp.PerformLayout();
            this.gbxParametres.ResumeLayout(false);
            this.gbxParametres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTour100;
        private System.Windows.Forms.RadioButton rbTour200;
        private System.Windows.Forms.RadioButton rbTour300;
        private System.Windows.Forms.RadioButton rbTour500;
        private System.Windows.Forms.GroupBox gbxVitesse;
        private System.Windows.Forms.RadioButton rbTemp50;
        private System.Windows.Forms.RadioButton rbTemp80;
        private System.Windows.Forms.RadioButton rbTemp100;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRetablir;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox tbVitesse;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label lbVitesse;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.GroupBox gbxParametres;
    }
}