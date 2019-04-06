namespace ButorraktarKarbantarto
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
            this.megnevezesTxb = new System.Windows.Forms.TextBox();
            this.xTxb = new System.Windows.Forms.TextBox();
            this.hozzaAd = new System.Windows.Forms.Button();
            this.megse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yTxb = new System.Windows.Forms.TextBox();
            this.zTxb = new System.Windows.Forms.TextBox();
            this.fa = new System.Windows.Forms.RadioButton();
            this.fem = new System.Windows.Forms.RadioButton();
            this.egyeb = new System.Windows.Forms.RadioButton();
            this.furdo = new System.Windows.Forms.RadioButton();
            this.nappali = new System.Windows.Forms.RadioButton();
            this.konyha = new System.Windows.Forms.RadioButton();
            this.anyagBox = new System.Windows.Forms.GroupBox();
            this.helysegBox = new System.Windows.Forms.GroupBox();
            this.darab = new System.Windows.Forms.NumericUpDown();
            this.anyagBox.SuspendLayout();
            this.helysegBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darab)).BeginInit();
            this.SuspendLayout();
            // 
            // megnevezesTxb
            // 
            this.megnevezesTxb.Location = new System.Drawing.Point(86, 38);
            this.megnevezesTxb.Name = "megnevezesTxb";
            this.megnevezesTxb.Size = new System.Drawing.Size(403, 20);
            this.megnevezesTxb.TabIndex = 0;
            // 
            // xTxb
            // 
            this.xTxb.Location = new System.Drawing.Point(86, 64);
            this.xTxb.Name = "xTxb";
            this.xTxb.Size = new System.Drawing.Size(90, 20);
            this.xTxb.TabIndex = 1;
            // 
            // hozzaAd
            // 
            this.hozzaAd.Location = new System.Drawing.Point(158, 184);
            this.hozzaAd.Name = "hozzaAd";
            this.hozzaAd.Size = new System.Drawing.Size(75, 23);
            this.hozzaAd.TabIndex = 6;
            this.hozzaAd.Text = "Hozzáadás";
            this.hozzaAd.UseVisualStyleBackColor = true;
            this.hozzaAd.Click += new System.EventHandler(this.hozzaAd_Click);
            // 
            // megse
            // 
            this.megse.Location = new System.Drawing.Point(262, 184);
            this.megse.Name = "megse";
            this.megse.Size = new System.Drawing.Size(75, 23);
            this.megse.TabIndex = 7;
            this.megse.Text = "Mégse";
            this.megse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.megse.UseVisualStyleBackColor = true;
            this.megse.Click += new System.EventHandler(this.megse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Megnevezés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Méret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anyaga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Elhelyezés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Darabszám";
            // 
            // yTxb
            // 
            this.yTxb.Location = new System.Drawing.Point(190, 64);
            this.yTxb.Name = "yTxb";
            this.yTxb.Size = new System.Drawing.Size(90, 20);
            this.yTxb.TabIndex = 14;
            // 
            // zTxb
            // 
            this.zTxb.Location = new System.Drawing.Point(286, 64);
            this.zTxb.Name = "zTxb";
            this.zTxb.Size = new System.Drawing.Size(90, 20);
            this.zTxb.TabIndex = 15;
            // 
            // fa
            // 
            this.fa.AutoSize = true;
            this.fa.Checked = true;
            this.fa.Location = new System.Drawing.Point(15, 0);
            this.fa.Name = "fa";
            this.fa.Size = new System.Drawing.Size(34, 17);
            this.fa.TabIndex = 16;
            this.fa.TabStop = true;
            this.fa.Text = "fa";
            this.fa.UseVisualStyleBackColor = true;
            this.fa.CheckedChanged += new System.EventHandler(this.Anyag_CheckedChanged);
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Location = new System.Drawing.Point(119, 1);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(42, 17);
            this.fem.TabIndex = 17;
            this.fem.TabStop = true;
            this.fem.Text = "fém";
            this.fem.UseVisualStyleBackColor = true;
            this.fem.CheckedChanged += new System.EventHandler(this.Anyag_CheckedChanged);
            // 
            // egyeb
            // 
            this.egyeb.AutoSize = true;
            this.egyeb.Location = new System.Drawing.Point(215, 1);
            this.egyeb.Name = "egyeb";
            this.egyeb.Size = new System.Drawing.Size(54, 17);
            this.egyeb.TabIndex = 18;
            this.egyeb.TabStop = true;
            this.egyeb.Text = "egyéb";
            this.egyeb.UseVisualStyleBackColor = true;
            this.egyeb.CheckedChanged += new System.EventHandler(this.Anyag_CheckedChanged);
            // 
            // furdo
            // 
            this.furdo.AutoSize = true;
            this.furdo.Checked = true;
            this.furdo.Location = new System.Drawing.Point(15, 0);
            this.furdo.Name = "furdo";
            this.furdo.Size = new System.Drawing.Size(49, 17);
            this.furdo.TabIndex = 19;
            this.furdo.TabStop = true;
            this.furdo.Text = "fürdő";
            this.furdo.UseVisualStyleBackColor = true;
            this.furdo.CheckedChanged += new System.EventHandler(this.Elhelyezes_CheckedChanged);
            // 
            // nappali
            // 
            this.nappali.AutoSize = true;
            this.nappali.Location = new System.Drawing.Point(119, 0);
            this.nappali.Name = "nappali";
            this.nappali.Size = new System.Drawing.Size(59, 17);
            this.nappali.TabIndex = 20;
            this.nappali.Text = "nappali";
            this.nappali.UseVisualStyleBackColor = true;
            this.nappali.CheckedChanged += new System.EventHandler(this.Elhelyezes_CheckedChanged);
            // 
            // konyha
            // 
            this.konyha.AutoSize = true;
            this.konyha.Location = new System.Drawing.Point(215, 0);
            this.konyha.Name = "konyha";
            this.konyha.Size = new System.Drawing.Size(60, 17);
            this.konyha.TabIndex = 21;
            this.konyha.Text = "konyha";
            this.konyha.UseVisualStyleBackColor = true;
            this.konyha.CheckedChanged += new System.EventHandler(this.Elhelyezes_CheckedChanged);
            // 
            // anyagBox
            // 
            this.anyagBox.Controls.Add(this.egyeb);
            this.anyagBox.Controls.Add(this.fem);
            this.anyagBox.Controls.Add(this.fa);
            this.anyagBox.Location = new System.Drawing.Point(71, 90);
            this.anyagBox.Name = "anyagBox";
            this.anyagBox.Size = new System.Drawing.Size(336, 17);
            this.anyagBox.TabIndex = 23;
            this.anyagBox.TabStop = false;
            // 
            // helysegBox
            // 
            this.helysegBox.Controls.Add(this.konyha);
            this.helysegBox.Controls.Add(this.nappali);
            this.helysegBox.Controls.Add(this.furdo);
            this.helysegBox.Location = new System.Drawing.Point(71, 114);
            this.helysegBox.Name = "helysegBox";
            this.helysegBox.Size = new System.Drawing.Size(336, 24);
            this.helysegBox.TabIndex = 24;
            this.helysegBox.TabStop = false;
            // 
            // darab
            // 
            this.darab.Location = new System.Drawing.Point(86, 143);
            this.darab.Name = "darab";
            this.darab.Size = new System.Drawing.Size(120, 20);
            this.darab.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 220);
            this.Controls.Add(this.darab);
            this.Controls.Add(this.helysegBox);
            this.Controls.Add(this.anyagBox);
            this.Controls.Add(this.zTxb);
            this.Controls.Add(this.yTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.megse);
            this.Controls.Add(this.hozzaAd);
            this.Controls.Add(this.xTxb);
            this.Controls.Add(this.megnevezesTxb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.anyagBox.ResumeLayout(false);
            this.anyagBox.PerformLayout();
            this.helysegBox.ResumeLayout(false);
            this.helysegBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox megnevezesTxb;
        private System.Windows.Forms.TextBox xTxb;
        private System.Windows.Forms.Button hozzaAd;
        private System.Windows.Forms.Button megse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yTxb;
        private System.Windows.Forms.TextBox zTxb;
        private System.Windows.Forms.RadioButton fa;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.RadioButton egyeb;
        private System.Windows.Forms.RadioButton furdo;
        private System.Windows.Forms.RadioButton nappali;
        private System.Windows.Forms.RadioButton konyha;
        private System.Windows.Forms.GroupBox anyagBox;
        private System.Windows.Forms.GroupBox helysegBox;
        private System.Windows.Forms.NumericUpDown darab;
    }
}