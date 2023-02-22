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
    public partial class MickeyForm : Form
    {
        public MickeyForm()
        {
            this.FormBorderStyle= FormBorderStyle.None;
            this.BackColor= Color.Black;
            this.TransparencyKey= Color.Black;

            InitializeComponent();
            INIT();
        }
        private Point firstPoint=new Point();
        public void INIT()
        {
            panel1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;

                }
            };
            panel1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    Point temp =Control.MousePosition; 
                    Point res=new Point(firstPoint.X-temp.X, firstPoint.Y-temp.Y);

                    panel1.Location=new Point (panel1.Location.X-res.X, panel1.Location.Y-res.Y);

                    firstPoint = temp;
                }
            };
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INIT();
        }
    }
}
