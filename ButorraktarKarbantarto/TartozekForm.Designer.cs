namespace ButorraktarKarbantarto
{
    partial class TartozekForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tartoelem = new System.Windows.Forms.RadioButton();
            this.extraelem = new System.Windows.Forms.RadioButton();
            this.dekorelem = new System.Windows.Forms.RadioButton();
            this.fa = new System.Windows.Forms.RadioButton();
            this.fem = new System.Windows.Forms.RadioButton();
            this.egyeb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Hozzaad_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Megse_Click);
            // 
            // tartoelem
            // 
            this.tartoelem.AutoSize = true;
            this.tartoelem.Checked = true;
            this.tartoelem.Location = new System.Drawing.Point(0, 0);
            this.tartoelem.Name = "tartoelem";
            this.tartoelem.Size = new System.Drawing.Size(75, 17);
            this.tartoelem.TabIndex = 2;
            this.tartoelem.TabStop = true;
            this.tartoelem.Text = "Tartó elem";
            this.tartoelem.UseVisualStyleBackColor = true;
            this.tartoelem.CheckedChanged += new System.EventHandler(this.TartozekTipusValaszto_CheckedChanged);
            // 
            // extraelem
            // 
            this.extraelem.AutoSize = true;
            this.extraelem.Location = new System.Drawing.Point(91, 0);
            this.extraelem.Name = "extraelem";
            this.extraelem.Size = new System.Drawing.Size(74, 17);
            this.extraelem.TabIndex = 3;
            this.extraelem.Text = "Extra elem";
            this.extraelem.UseVisualStyleBackColor = true;
            this.extraelem.CheckedChanged += new System.EventHandler(this.TartozekTipusValaszto_CheckedChanged);
            // 
            // dekorelem
            // 
            this.dekorelem.AutoSize = true;
            this.dekorelem.Location = new System.Drawing.Point(171, 0);
            this.dekorelem.Name = "dekorelem";
            this.dekorelem.Size = new System.Drawing.Size(79, 17);
            this.dekorelem.TabIndex = 5;
            this.dekorelem.Text = "Dekor elem";
            this.dekorelem.UseVisualStyleBackColor = true;
            this.dekorelem.CheckedChanged += new System.EventHandler(this.TartozekTipusValaszto_CheckedChanged);
            // 
            // fa
            // 
            this.fa.AutoSize = true;
            this.fa.Checked = true;
            this.fa.Location = new System.Drawing.Point(0, 0);
            this.fa.Name = "fa";
            this.fa.Size = new System.Drawing.Size(37, 17);
            this.fa.TabIndex = 6;
            this.fa.TabStop = true;
            this.fa.Text = "Fa";
            this.fa.UseVisualStyleBackColor = true;
            this.fa.CheckedChanged += new System.EventHandler(this.AnyagValaszto_CheckedChanged);
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Location = new System.Drawing.Point(91, 0);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(45, 17);
            this.fem.TabIndex = 7;
            this.fem.Text = "Fém";
            this.fem.UseVisualStyleBackColor = true;
            this.fem.CheckedChanged += new System.EventHandler(this.AnyagValaszto_CheckedChanged);
            // 
            // egyeb
            // 
            this.egyeb.AutoSize = true;
            this.egyeb.Location = new System.Drawing.Point(171, 0);
            this.egyeb.Name = "egyeb";
            this.egyeb.Size = new System.Drawing.Size(55, 17);
            this.egyeb.TabIndex = 8;
            this.egyeb.Text = "Egyéb";
            this.egyeb.UseVisualStyleBackColor = true;
            this.egyeb.CheckedChanged += new System.EventHandler(this.AnyagValaszto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tartozék ára";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tartozék anyaga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tartozék típusa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dekorelem);
            this.groupBox1.Controls.Add(this.extraelem);
            this.groupBox1.Controls.Add(this.tartoelem);
            this.groupBox1.Location = new System.Drawing.Point(101, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 23);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.egyeb);
            this.groupBox2.Controls.Add(this.fem);
            this.groupBox2.Controls.Add(this.fa);
            this.groupBox2.Location = new System.Drawing.Point(101, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 18);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Forint";
            // 
            // ar
            // 
            this.ar.Location = new System.Drawing.Point(85, 68);
            this.ar.Name = "ar";
            this.ar.Size = new System.Drawing.Size(120, 20);
            this.ar.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 142);
            this.Controls.Add(this.ar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton tartoelem;
        private System.Windows.Forms.RadioButton extraelem;
        private System.Windows.Forms.RadioButton dekorelem;
        private System.Windows.Forms.RadioButton fa;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.RadioButton egyeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ar;
    }
}