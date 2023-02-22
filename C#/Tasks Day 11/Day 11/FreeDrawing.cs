using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day_11
{
    public partial class FreeDrawing : Form
    {
        public FreeDrawing()
        {
            InitializeComponent();
            panel1.BackColor = Color.White;

        }
        int pointX = 0;
        int pointY = 0;
        Pen p;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode= SmoothingMode.AntiAlias;
            p = new Pen(colorDialog1.Color, 2);
            g.DrawEllipse(p, pointX, pointY, 2, 2);


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointX = e.X;
                pointY = e.Y;
                panel1_Paint(this, null);
            }
            else 
            {
                pointX = e.X;
                pointY = e.Y;
                Graphics g = panel1.CreateGraphics();
                Pen p = new Pen(Color.White, 2);
                g.DrawEllipse(p, pointX, pointY, 2, 2);
                
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //ColorDialog colorDlg = new ColorDialog();
            //colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.ForeColor = colorDlg.Color;
                p.Color = colorDialog1.Color;
            }
        }
    }
}
