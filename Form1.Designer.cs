namespace Euclid
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calc = new System.Windows.Forms.Button();
            this.label_num = new System.Windows.Forms.Label();
            this.label_denom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_method = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.nud_num = new System.Windows.Forms.NumericUpDown();
            this.nud_den = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_den)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(263, 51);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(10, 21);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(56, 13);
            this.label_num.TabIndex = 5;
            this.label_num.Text = "Numerator";
            // 
            // label_denom
            // 
            this.label_denom.AutoSize = true;
            this.label_denom.Location = new System.Drawing.Point(10, 56);
            this.label_denom.Name = "label_denom";
            this.label_denom.Size = new System.Drawing.Size(67, 13);
            this.label_denom.TabIndex = 6;
            this.label_denom.Text = "Denominator";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nud_den);
            this.panel1.Controls.Add(this.cb_method);
            this.panel1.Controls.Add(this.nud_num);
            this.panel1.Controls.Add(this.label_num);
            this.panel1.Controls.Add(this.label_denom);
            this.panel1.Controls.Add(this.btn_calc);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 88);
            this.panel1.TabIndex = 7;
            // 
            // cb_method
            // 
            this.cb_method.FormattingEnabled = true;
            this.cb_method.Items.AddRange(new object[] {
            "Subsctraction",
            "Modulo",
            "Prime"});
            this.cb_method.Location = new System.Drawing.Point(240, 18);
            this.cb_method.Name = "cb_method";
            this.cb_method.Size = new System.Drawing.Size(121, 21);
            this.cb_method.TabIndex = 0;
            this.cb_method.Text = "Method";
            this.cb_method.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_result);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 172);
            this.panel2.TabIndex = 8;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(14, 12);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_result.Size = new System.Drawing.Size(373, 150);
            this.tb_result.TabIndex = 2;
            // 
            // nud_num
            // 
            this.nud_num.Location = new System.Drawing.Point(94, 19);
            this.nud_num.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_num.Name = "nud_num";
            this.nud_num.Size = new System.Drawing.Size(120, 20);
            this.nud_num.TabIndex = 3;
            this.nud_num.Value = new decimal(new int[] {
            2366,
            0,
            0,
            0});
            this.nud_num.ValueChanged += new System.EventHandler(this.nud_num_ValueChanged);
            // 
            // nud_den
            // 
            this.nud_den.Location = new System.Drawing.Point(94, 54);
            this.nud_den.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_den.Name = "nud_den";
            this.nud_den.Size = new System.Drawing.Size(120, 20);
            this.nud_den.TabIndex = 4;
            this.nud_den.Value = new decimal(new int[] {
            273,
            0,
            0,
            0});
            this.nud_den.ValueChanged += new System.EventHandler(this.nud_den_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Euclid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_den)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_denom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_method;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.NumericUpDown nud_den;
        private System.Windows.Forms.NumericUpDown nud_num;
    }
}

