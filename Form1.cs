using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euclid
{
    public partial class Form1 : Form
    {
        private int numerator;
        private int denominator;

        public Form1()
        {
            InitializeComponent();
        }

        private void tb_nominator_TextChanged(object sender, EventArgs e)
        {
            numerator = Convert.ToInt32(tb_numerator.Text);
        }

        private void tb_denominator_TextChanged(object sender, EventArgs e)
        {
            denominator = Convert.ToInt32(tb_denominator.Text);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (rb_mod.Checked)
            {
                while (denominator != 0)
                {
                    int temp = denominator;
                    denominator = numerator % denominator;
                    numerator = temp;
                }
                tb_result.Text = numerator.ToString();
            }
            else
            {
                tb_result.Text = "Fuck off";
            }
        }
    }
}
