﻿namespace Exo1
{
    partial class frmExo2b
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPhrase1 = new System.Windows.Forms.TextBox();
            this.tbxPhrase2 = new System.Windows.Forms.TextBox();
            this.tbxPhrase3 = new System.Windows.Forms.TextBox();
            this.gbxPhrase = new System.Windows.Forms.GroupBox();
            this.cbxPhrase1 = new System.Windows.Forms.CheckBox();
            this.cbxPhrase2 = new System.Windows.Forms.CheckBox();
            this.cbxPhrase3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMonChar = new System.Windows.Forms.TextBox();
            this.tbx_Resultat = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.gbxPhrase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phrase 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phrase 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phrase 3 :";
            // 
            // tbxPhrase1
            // 
            this.tbxPhrase1.Location = new System.Drawing.Point(91, 23);
            this.tbxPhrase1.Name = "tbxPhrase1";
            this.tbxPhrase1.Size = new System.Drawing.Size(377, 20);
            this.tbxPhrase1.TabIndex = 3;
            // 
            // tbxPhrase2
            // 
            this.tbxPhrase2.Location = new System.Drawing.Point(91, 58);
            this.tbxPhrase2.Name = "tbxPhrase2";
            this.tbxPhrase2.Size = new System.Drawing.Size(377, 20);
            this.tbxPhrase2.TabIndex = 4;
            // 
            // tbxPhrase3
            // 
            this.tbxPhrase3.Location = new System.Drawing.Point(91, 93);
            this.tbxPhrase3.Name = "tbxPhrase3";
            this.tbxPhrase3.Size = new System.Drawing.Size(377, 20);
            this.tbxPhrase3.TabIndex = 5;
            // 
            // gbxPhrase
            // 
            this.gbxPhrase.Controls.Add(this.tbxPhrase3);
            this.gbxPhrase.Controls.Add(this.tbxPhrase2);
            this.gbxPhrase.Controls.Add(this.tbxPhrase1);
            this.gbxPhrase.Controls.Add(this.label3);
            this.gbxPhrase.Controls.Add(this.label2);
            this.gbxPhrase.Controls.Add(this.label1);
            this.gbxPhrase.Location = new System.Drawing.Point(37, 11);
            this.gbxPhrase.Name = "gbxPhrase";
            this.gbxPhrase.Size = new System.Drawing.Size(511, 134);
            this.gbxPhrase.TabIndex = 6;
            this.gbxPhrase.TabStop = false;
            // 
            // cbxPhrase1
            // 
            this.cbxPhrase1.AutoSize = true;
            this.cbxPhrase1.Location = new System.Drawing.Point(26, 25);
            this.cbxPhrase1.Name = "cbxPhrase1";
            this.cbxPhrase1.Size = new System.Drawing.Size(65, 17);
            this.cbxPhrase1.TabIndex = 7;
            this.cbxPhrase1.Text = "Phrase1";
            this.cbxPhrase1.UseVisualStyleBackColor = true;
            // 
            // cbxPhrase2
            // 
            this.cbxPhrase2.AutoSize = true;
            this.cbxPhrase2.Location = new System.Drawing.Point(26, 68);
            this.cbxPhrase2.Name = "cbxPhrase2";
            this.cbxPhrase2.Size = new System.Drawing.Size(65, 17);
            this.cbxPhrase2.TabIndex = 8;
            this.cbxPhrase2.Text = "Phrase2";
            this.cbxPhrase2.UseVisualStyleBackColor = true;
            // 
            // cbxPhrase3
            // 
            this.cbxPhrase3.AutoSize = true;
            this.cbxPhrase3.Location = new System.Drawing.Point(26, 113);
            this.cbxPhrase3.Name = "cbxPhrase3";
            this.cbxPhrase3.Size = new System.Drawing.Size(65, 17);
            this.cbxPhrase3.TabIndex = 9;
            this.cbxPhrase3.Text = "Phrase3";
            this.cbxPhrase3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPhrase3);
            this.groupBox1.Controls.Add(this.cbxPhrase2);
            this.groupBox1.Controls.Add(this.cbxPhrase1);
            this.groupBox1.Location = new System.Drawing.Point(48, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher dans :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lettre à rechercher :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombres d\'occurences :";
            // 
            // tbxMonChar
            // 
            this.tbxMonChar.Location = new System.Drawing.Point(353, 205);
            this.tbxMonChar.Name = "tbxMonChar";
            this.tbxMonChar.Size = new System.Drawing.Size(152, 20);
            this.tbxMonChar.TabIndex = 13;
            this.tbxMonChar.MaxLength = 1;
            // 
            // tbx_Resultat
            // 
            this.tbx_Resultat.Location = new System.Drawing.Point(353, 237);
            this.tbx_Resultat.Name = "tbx_Resultat";
            this.tbx_Resultat.Size = new System.Drawing.Size(152, 20);
            this.tbx_Resultat.TabIndex = 14;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(523, 214);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(112, 33);
            this.btnRecherche.TabIndex = 15;
            this.btnRecherche.Text = "Lancer la recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // frmExo2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 338);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.tbx_Resultat);
            this.Controls.Add(this.tbxMonChar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxPhrase);
            this.Name = "frmExo2b";
            this.Text = "frmExo2b";
            this.gbxPhrase.ResumeLayout(false);
            this.gbxPhrase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPhrase1;
        private System.Windows.Forms.TextBox tbxPhrase2;
        private System.Windows.Forms.TextBox tbxPhrase3;
        private System.Windows.Forms.GroupBox gbxPhrase;
        private System.Windows.Forms.CheckBox cbxPhrase1;
        private System.Windows.Forms.CheckBox cbxPhrase2;
        private System.Windows.Forms.CheckBox cbxPhrase3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMonChar;
        private System.Windows.Forms.TextBox tbx_Resultat;
        private System.Windows.Forms.Button btnRecherche;
    }
}