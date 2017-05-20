using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final3
{
    public partial class Form1 : Form
    {
        public int a = 0;
        public int b = 1;
        public int res;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = res + b;
            button1.Text = Convert.ToString(res);

            switch ()
            {
                case "button1_Click = 1":
                    label1.ForeColor = Color.Red;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;

                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    label12.ForeColor = Color.Black;
                    break;
                case "button1_Click = 2":
                    label2.ForeColor = Color.Red;
                    label1.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;

                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    label12.ForeColor = Color.Black;
                    break;
                case "button1_Click = 3":

                    label3.ForeColor = Color.Red;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;

                    label4.ForeColor = Color.Black;

                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    label12.ForeColor = Color.Black;

                    break;

            }




            /* label1.ForeColor = Color.Red;
             label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;

            label5.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            label7.ForeColor = Color.Red;
            label8.ForeColor = Color.Red;
            label9.ForeColor = Color.Red;
            label10.ForeColor = Color.Red;
            label11.ForeColor = Color.Red;
            label12.ForeColor = Color.Red;
            
            label1.ForeColor = Color.Black;
             label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;

            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
             
             
             
             */

        }

    
    }

       
    }

