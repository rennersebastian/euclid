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
        private ulong numerator;
        private ulong denominator;
        private ulong step;
        private ulong result;
        string NL = Environment.NewLine;
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            numerator = Convert.ToUInt64(nud_num.Value);
            denominator = Convert.ToUInt64(nud_den.Value);
        }

        private void nud_num_ValueChanged(object sender, EventArgs e)
        {
            numerator = Convert.ToUInt64(nud_num.Value);
        }

        private void nud_den_ValueChanged(object sender, EventArgs e)
        {
            denominator = Convert.ToUInt64(nud_den.Value);
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
                    result = prime(numerator, denominator);
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
        
        private ulong sub(ulong a, ulong b)
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

        private ulong mod(ulong a, ulong b)
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

        private ulong prime(ulong a, ulong b)
        {
            step = 0;
            stopwatch = Stopwatch.StartNew();

            List<ulong> primes = getPrimes(a);
            ulong temp = a;
            List<ulong> factorsA = new List<ulong>();
            List<ulong> factorsB = new List<ulong>();

            while (temp > 1)
            {
                for (int i = 0; i < primes.Count; i++)
                {
                    if (temp % primes.ElementAt(i) == 0)
                    {
                        factorsA.Add(primes.ElementAt(i));
                        temp = temp / primes.ElementAt(i);
                        break;
                    }
                }
            }
            
            primes = getPrimes(b);
            temp = b;

            while (temp > 1)
            {
                for (int i = 0; i < primes.Count; i++)
                {
                    if (temp % primes.ElementAt(i) == 0)
                    {
                        factorsB.Add(primes.ElementAt(i));
                        temp = temp / primes.ElementAt(i);
                        break;
                    }
                }
            }
            List<ulong> results = new List<ulong>();
            foreach (ulong u in factorsA)
            {
                if (factorsB.Contains(u))
                {
                    results.Add(u);
                    factorsB.Remove(u);
                }
            }

            temp = 1;
            foreach (ulong u in results)
            {
                temp *= u;
            }
            stopwatch.Stop();
            return temp;
        }

        private List<ulong> getPrimes(ulong n)
        {
            List<ulong> primes = new List<ulong>();

            primes.Add(2);
            ulong factor = n/2;
            bool isPrime;
            for (ulong i = 3; i <= factor; i += 2)
            {
                isPrime = true;
                for (ulong j = 3; j * j <= i; j += 2)
                {
                    if (i % j == 0)
                        isPrime = false;
                }
                if (isPrime)
                    primes.Add(i);
            }
            return primes;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
