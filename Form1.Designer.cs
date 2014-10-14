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
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_mod = new System.Windows.Forms.RadioButton();
            this.tb_numerator = new System.Windows.Forms.TextBox();
            this.tb_denominator = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.label_denom = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(69, 124);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Checked = true;
            this.rb_sub.Location = new System.Drawing.Point(12, 12);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(84, 17);
            this.rb_sub.TabIndex = 1;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "Substraction";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_mod
            // 
            this.rb_mod.AutoSize = true;
            this.rb_mod.Location = new System.Drawing.Point(103, 12);
            this.rb_mod.Name = "rb_mod";
            this.rb_mod.Size = new System.Drawing.Size(60, 17);
            this.rb_mod.TabIndex = 2;
            this.rb_mod.Text = "Modulo";
            this.rb_mod.UseVisualStyleBackColor = true;
            // 
            // tb_numerator
            // 
            this.tb_numerator.Location = new System.Drawing.Point(88, 49);
            this.tb_numerator.Name = "tb_numerator";
            this.tb_numerator.Size = new System.Drawing.Size(100, 20);
            this.tb_numerator.TabIndex = 3;
            this.tb_numerator.TextChanged += new System.EventHandler(this.tb_nominator_TextChanged);
            // 
            // tb_denominator
            // 
            this.tb_denominator.Location = new System.Drawing.Point(88, 86);
            this.tb_denominator.Name = "tb_denominator";
            this.tb_denominator.Size = new System.Drawing.Size(100, 20);
            this.tb_denominator.TabIndex = 4;
            this.tb_denominator.TextChanged += new System.EventHandler(this.tb_denominator_TextChanged);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(9, 52);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(56, 13);
            this.label_num.TabIndex = 5;
            this.label_num.Text = "Numerator";
            // 
            // label_denom
            // 
            this.label_denom.AutoSize = true;
            this.label_denom.Location = new System.Drawing.Point(9, 89);
            this.label_denom.Name = "label_denom";
            this.label_denom.Size = new System.Drawing.Size(67, 13);
            this.label_denom.TabIndex = 6;
            this.label_denom.Text = "Denominator";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(88, 164);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(100, 20);
            this.tb_result.TabIndex = 7;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(9, 167);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(37, 13);
            this.label_result.TabIndex = 8;
            this.label_result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 202);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.label_denom);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.tb_denominator);
            this.Controls.Add(this.tb_numerator);
            this.Controls.Add(this.rb_mod);
            this.Controls.Add(this.rb_sub);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Euclid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_mod;
        private System.Windows.Forms.TextBox tb_numerator;
        private System.Windows.Forms.TextBox tb_denominator;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_denom;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label_result;
    }
}

