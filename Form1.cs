using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int step;
        private int result;
        string NL = Environment.NewLine;
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            numerator = 90987072;
            denominator = 46049088;
            tb_numerator.Text = numerator.ToString();
            tb_denominator.Text = denominator.ToString();
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
            tb_result.Clear();
            result = 0;
            switch (cb_method.SelectedIndex)
            {
                case 0:
                    result = sub(numerator, denominator);
                    tb_result.AppendText(NL + "");
                    tb_result.AppendText(NL + "GCD: " + result);
                    tb_result.AppendText(NL + "Fraction: " + numerator/result + "/" + denominator/result);
                    tb_result.AppendText(NL + "Time: " + stopwatch.ElapsedMilliseconds + "ms");
                    break;

                case 1:
                    result = mod(numerator, denominator);
                    tb_result.AppendText(NL + "");
                    tb_result.AppendText(NL + "GCD: " + result);
                    tb_result.AppendText(NL + "Fraction: " + numerator/result + "/" + denominator/result);
                    tb_result.AppendText(NL + "Time: " + stopwatch.ElapsedMilliseconds + "ms");
                    break;

                case 2:
                    prime(numerator, denominator);
                    tb_result.AppendText(NL + "");
                    tb_result.AppendText(NL + "GCD: " + result);
                    tb_result.AppendText(NL + "Fraction: " + numerator/result + "/" + denominator/result);
                    tb_result.AppendText(NL + "Time: " + stopwatch.ElapsedMilliseconds + "ms");
                    break;

                default:
                    MessageBox.Show("Select a Method.");
                    break;
            }
        }
        
        private int sub(int a, int b)
        {
            step = 0;
            stopwatch = Stopwatch.StartNew();
            while (b != 0)
            {
                step++;
                if (a > b){
                    a -= b;
                    tb_result.AppendText(NL + "Step: " + step + " | A - B = " + a);
                }
                else{
                    b -= a;
                    tb_result.AppendText(NL + "Step: " + step + " | B - A = " + b);
                }
            }
            stopwatch.Stop();
            return a;
        }

        private int mod(int a, int b)
        {
            step = 0;
            stopwatch = Stopwatch.StartNew();
            while (a != 0 && b != 0)
            {
                step++;
                if (a > b){
                    a %= b;
                    tb_result.AppendText(NL + "Step: " + step + " | A % B = " + a); 
                }
                else{
                    b %= a;
                    tb_result.AppendText(NL + "Step: " + step + " | B % A = " + b); 
                }
            }
            stopwatch.Stop();
            if (a == 0)
                return b;
            else
                return a;
        }

        private int prime(int a, int b)
        {
            step = 0;
            stopwatch = Stopwatch.StartNew();



            stopwatch.Stop();
            return a;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
