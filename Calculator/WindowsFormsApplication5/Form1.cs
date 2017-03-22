using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double a;
        public double b;
        public char c;

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(display.Text);
                c = '+';
                display.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text += "00";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(display.Text);
                c = '-';
                display.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(display.Text);
                c = '*';
                display.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(display.Text);
                c = '/';
                display.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(display.Text);
            display.Text = "";
            switch (c)
            {
                case '+':
                    display.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    display.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    display.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    display.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            display.Text += ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(Math.Pow(a, 2));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            display.Text = "";
            a = 0;
            b = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string s = display.Text;
            s = s.Substring(0, s.Length - 1);
            display.Text = s;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

