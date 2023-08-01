using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Method1(double x)
        {
            double y = x * (Math.Sin(x)) / 2;
            return y;
        }
        public double Method2(double x)
        {
            double y = Math.Sqrt(x) / 2 * x;
            return y;
        }
        public double Method3(double x)
        {
            double y = Math.Pow(x, 2) + 3.5;
            return y;
        }
        public double DoubleRes(double y)
        {
            return y *= 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x1 = textBox1.Text;
                double y = 0;
                double x = Convert.ToDouble(x1);
                if (x <= 0)
                {
                    y = Method1(x);
                    radio1.Checked = true;
                }
                if (0 < x & x < 3)
                {
                    y = Method2(x);
                    radio2.Checked = true;
                }
                if (x >= 3)
                {
                    y = Method3(x);
                    radio3.Checked = true;
                }
                if (checkBox1.Checked) { y *= 2; }
                labelRes.Text = "Result: " + y;
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorect input");
                textBox1.Focus();
                return;
            }
        }
    }
}