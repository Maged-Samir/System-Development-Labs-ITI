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
    public partial class DragAndDropRect : Form


    {

        private Point MouseDownLocation;
        public DragAndDropRect()
        {
            InitializeComponent();
        }

        Rectangle rec = new Rectangle(50, 50, 200, 150);

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, rec);         
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rec = new Rectangle(e.X, e.Y, 0, 0);
                //Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                MouseDownLocation = e.Location;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rec.Width = e.X - rec.X;
                rec.Height = e.Y - rec.Y;
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                //rec.Location = new Point((e.X - MouseDownLocation.X) + rec.Left, (e.Y - MouseDownLocation.Y) + rec.Top);
                //MouseDownLocation = e.Location;
                //this.Invalidate();
            }
        }



    }
}
