using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final4
{
    public partial class Form1 : Form
    {
        enum Position { Up,Down }
        
        Graphics g;
        private int x;
        private int y;
        private Position objPosition;
        
        public Form1()
        {
            InitializeComponent();
            
            objPosition = Position.Down;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
            e.Graphics.FillEllipse(Brushes.Blue, 50, y, 30, 30);
            e.Graphics.FillEllipse(Brushes.Blue, 90, y, 30,30);
            e.Graphics.FillEllipse(Brushes.Blue, 130, y, 30,30);
            e.Graphics.FillEllipse(Brushes.Blue, 10, y, 30, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            objPosition = Position.Down;

            if (objPosition == Position.Down)
            {
                y += 10;
            }
            Invalidate();
           
        }
    }
}
