namespace ButorraktarKarbantarto
{
    partial class MainForm
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
            this.butorok = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tartozekok = new System.Windows.Forms.ListBox();
            this.tartozekFelvitelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butorok
            // 
            this.butorok.FormattingEnabled = true;
            this.butorok.Location = new System.Drawing.Point(12, 73);
            this.butorok.Name = "butorok";
            this.butorok.Size = new System.Drawing.Size(383, 303);
            this.butorok.TabIndex = 0;
            this.butorok.SelectedIndexChanged += new System.EventHandler(this.ButorListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bútor felvitel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButorFelvitel_Click);
            // 
            // tartozekok
            // 
            this.tartozekok.FormattingEnabled = true;
            this.tartozekok.Location = new System.Drawing.Point(401, 73);
            this.tartozekok.Name = "tartozekok";
            this.tartozekok.Size = new System.Drawing.Size(387, 303);
            this.tartozekok.TabIndex = 2;
            // 
            // tartozekFelvitelButton
            // 
            this.tartozekFelvitelButton.Location = new System.Drawing.Point(681, 406);
            this.tartozekFelvitelButton.Name = "tartozekFelvitelButton";
            this.tartozekFelvitelButton.Size = new System.Drawing.Size(107, 23);
            this.tartozekFelvitelButton.TabIndex = 3;
            this.tartozekFelvitelButton.Text = "Tartozék felvitel";
            this.tartozekFelvitelButton.UseVisualStyleBackColor = true;
            this.tartozekFelvitelButton.Click += new System.EventHandler(this.TartozekFelvitel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tartozekFelvitelButton);
            this.Controls.Add(this.tartozekok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butorok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox butorok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox tartozekok;
        private System.Windows.Forms.Button tartozekFelvitelButton;
    }
}

