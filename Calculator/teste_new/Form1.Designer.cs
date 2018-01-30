namespace teste_new
{
    partial class Form1
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
            this.txb_num1 = new System.Windows.Forms.TextBox();
            this.txb_num2 = new System.Windows.Forms.TextBox();
            this.txb_res = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.txb_subtrai = new System.Windows.Forms.Button();
            this.btn_multiplica = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_num1
            // 
            this.txb_num1.Font = new System.Drawing.Font("Helvetica LT Std Cond", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_num1.Location = new System.Drawing.Point(16, 56);
            this.txb_num1.Name = "txb_num1";
            this.txb_num1.Size = new System.Drawing.Size(100, 22);
            this.txb_num1.TabIndex = 0;
            this.txb_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_num2
            // 
            this.txb_num2.Font = new System.Drawing.Font("Helvetica LT Std Cond", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_num2.Location = new System.Drawing.Point(17, 82);
            this.txb_num2.Name = "txb_num2";
            this.txb_num2.Size = new System.Drawing.Size(100, 22);
            this.txb_num2.TabIndex = 1;
            this.txb_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_res
            // 
            this.txb_res.Cursor = System.Windows.Forms.Cursors.No;
            this.txb_res.Enabled = false;
            this.txb_res.Font = new System.Drawing.Font("Helvetica LT Std Cond", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_res.Location = new System.Drawing.Point(16, 166);
            this.txb_res.Name = "txb_res";
            this.txb_res.ReadOnly = true;
            this.txb_res.Size = new System.Drawing.Size(100, 22);
            this.txb_res.TabIndex = 2;
            this.txb_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_res.TextChanged += new System.EventHandler(this.txb_res_TextChanged);
            // 
            // btn_soma
            // 
            this.btn_soma.Font = new System.Drawing.Font("Helvetica LT Std Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_soma.Location = new System.Drawing.Point(24, 108);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(35, 23);
            this.btn_soma.TabIndex = 3;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_subtrai
            // 
            this.txb_subtrai.Font = new System.Drawing.Font("Helvetica LT Std Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_subtrai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txb_subtrai.Location = new System.Drawing.Point(24, 137);
            this.txb_subtrai.Name = "txb_subtrai";
            this.txb_subtrai.Size = new System.Drawing.Size(35, 23);
            this.txb_subtrai.TabIndex = 4;
            this.txb_subtrai.Text = "-";
            this.txb_subtrai.UseVisualStyleBackColor = true;
            this.txb_subtrai.Click += new System.EventHandler(this.txb_subtrai_Click);
            // 
            // btn_multiplica
            // 
            this.btn_multiplica.Font = new System.Drawing.Font("Helvetica LT Std Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_multiplica.Location = new System.Drawing.Point(65, 108);
            this.btn_multiplica.Name = "btn_multiplica";
            this.btn_multiplica.Size = new System.Drawing.Size(35, 23);
            this.btn_multiplica.TabIndex = 5;
            this.btn_multiplica.Text = "*";
            this.btn_multiplica.UseVisualStyleBackColor = true;
            this.btn_multiplica.Click += new System.EventHandler(this.btn_multiplica_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Helvetica LT Std Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_divide.Location = new System.Drawing.Point(65, 137);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(35, 23);
            this.btn_divide.TabIndex = 6;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std Cond Blk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Basic Calculator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zerarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(145, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zerarToolStripMenuItem
            // 
            this.zerarToolStripMenuItem.Name = "zerarToolStripMenuItem";
            this.zerarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.zerarToolStripMenuItem.Text = "Reset";
            this.zerarToolStripMenuItem.Click += new System.EventHandler(this.zerarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Exit";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiplica);
            this.Controls.Add(this.txb_subtrai);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txb_res);
            this.Controls.Add(this.txb_num2);
            this.Controls.Add(this.txb_num1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_num1;
        private System.Windows.Forms.TextBox txb_num2;
        private System.Windows.Forms.TextBox txb_res;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button txb_subtrai;
        private System.Windows.Forms.Button btn_multiplica;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

