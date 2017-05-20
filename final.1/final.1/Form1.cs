using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final._1
{
    public partial class Form1 : Form
    {
        public int a=0;
        public int b=1;
        public int c = 1;
        public int res;
        public int qw;
        public int qw1;
                public int qw2;
        public int qw3;
        public int qw4;
        public int qw5;
        public int qw6;
        public int qw7;
        public int qw8;
        


        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw = qw + b;
            button1.Text =Convert.ToString(qw);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw1 = qw1 + b;
            button2.Text = Convert.ToString(qw1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw2 = qw2 + b;
            button3.Text = Convert.ToString(qw2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw3 = qw3 + b;
            button4.Text = Convert.ToString(qw3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw4 = qw4 + b;
            button5.Text = Convert.ToString(qw4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw5 = qw5 + b;
            button6.Text = Convert.ToString(qw5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw6 = qw6 + b;
            button7.Text = Convert.ToString(qw6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            display.Text = Convert.ToString(res);
            res = res + b;
            qw7 = qw7 + b;
            button8.Text = Convert.ToString(qw7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            display.Text = Convert.ToString(res);
            res = res + b;
            qw8 = qw8 + b;
            button9.Text = Convert.ToString(qw8);
        }
    }
}
