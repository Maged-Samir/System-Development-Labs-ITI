using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_11
{
    public partial class MovingBall : Form
    {
        Rectangle ball = new(100, 310, 100, 100);
        bool direction = false;

        public MovingBall()
        {
            InitializeComponent();
            //this.timer1.Tick += new System.EventHandler(this.Move);
        }

        

        private void Move(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(new SolidBrush(BackColor), ball);
            graphics.DrawEllipse(new Pen(BackColor), ball);


            if (ball.X == 800) 
                direction = true;

            if (ball.X == 100) 
                direction = false;

            if (direction)
            {
                ball = new(ball.X - 50, ball.Y, 100, 100);
            }
            else
            {
                ball = new(ball.X + 50, ball.Y, 100, 100);
            }
            graphics.FillEllipse(Brushes.Black, ball);
            graphics.DrawEllipse(Pens.Black, ball);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, new(10, 0, 100, 100));
            e.Graphics.DrawLine(Pens.Black, new(60, 100), new(60, 350));


            e.Graphics.DrawEllipse(Pens.Black, new(850, 0, 100, 100));
            e.Graphics.DrawLine(Pens.Black, new(900, 100), new(900, 350));
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    Move();
        //}
    }
}
