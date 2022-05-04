using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int ch_x(double x)
        {
            x = (x + 14) * 16;
            return (int)x;
        }

        public static int ch_y(double y)
        {
            y = (19 - y) * 16;
            return (int)y;
        }

        public void shtrih(Point[] points, Pen pen, Graphics g)
        {
            
              
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 2);
            Brush brush_black = new SolidBrush(Color.Black);
            Brush brush_yellow = new SolidBrush(Color.Yellow);
            Brush brush_white = new SolidBrush(Color.White);
            Brush brush_red = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Black, 2);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


            g.DrawRectangle(pen, new Rectangle(5, 5, Width-50, Height-50));

            Point[] L_ear_b;
            L_ear_b = new Point[4];
            L_ear_b[0] = new Point(ch_x(-10), ch_y(8));
            L_ear_b[1] = new Point(ch_x(-11.5), ch_y(10));
            L_ear_b[2] = new Point(ch_x(-13.5), ch_y(13));
            L_ear_b[3] = new Point(ch_x(-11), ch_y(12));
            //g.DrawPolygon(pen, L_ear_b);
            
            //g.FillEllipse(brush_black, new Rectangle(144, 256, 24, 24));
            shtrih(L_ear_b, pen, g);
            Point[] L_ear_y = new Point[5];
            L_ear_y[0] = new Point(ch_x(-6), ch_y(7));
            L_ear_y[1] = new Point(ch_x(-10), ch_y(8));
            L_ear_y[2] = new Point(ch_x(-11), ch_y(12));
            L_ear_y[3] = new Point(ch_x(-7), ch_y(10));
            L_ear_y[4] = new Point(ch_x(-5), ch_y(8));
            
            Point[] L_head_y = new Point[22];
            L_head_y[8] = new Point(ch_x(-5), ch_y(8));
            L_head_y[9] = new Point(ch_x(-3), ch_y(8.5));
            L_head_y[10] = new Point(ch_x(-1), ch_y(9));
            L_head_y[11] = new Point(ch_x(1), ch_y(9));
            L_head_y[12] = new Point(ch_x(3), ch_y(8.5));
            L_head_y[13] = new Point(ch_x(4.5), ch_y(7));
            L_head_y[14] = new Point(ch_x(5), ch_y(5.5));
            L_head_y[15] = new Point(ch_x(6), ch_y(4));
            L_head_y[16] = new Point(ch_x(6.5), ch_y(3));
            L_head_y[17] = new Point(ch_x(7), ch_y(1));
            L_head_y[18] = new Point(ch_x(7), ch_y(0));
            L_head_y[19] = new Point(ch_x(6.5), ch_y(-1));
            L_head_y[20] = new Point(ch_x(6), ch_y(-1.5));
            L_head_y[21] = new Point(ch_x(5), ch_y(-2.5));
            L_head_y[0] = new Point(ch_x(-6), ch_y(-3));
            L_head_y[1] = new Point(ch_x(-7.5), ch_y(-2.5));
            L_head_y[2] = new Point(ch_x(-8), ch_y(-2));
            L_head_y[3] = new Point(ch_x(-8.5), ch_y(-1));
            L_head_y[4] = new Point(ch_x(-8.5), ch_y(1));
            L_head_y[5] = new Point(ch_x(-8), ch_y(3));
            L_head_y[6] = new Point(ch_x(-7.5), ch_y(5.5));
            L_head_y[7] = new Point(ch_x(-6), ch_y(7));

            Point[] Nose = new Point[3];
            Nose[0] = new Point(ch_x(-1.5), ch_y(1.5));
            Nose[1] = new Point(ch_x(0.5), ch_y(1.5));
            Nose[2] = new Point(ch_x(-0.5), ch_y(1));

            Point[] Smile = new Point[6];
            Smile[0] = new Point(ch_x(-3), ch_y(-0.5));
            Smile[1] = new Point(ch_x(-2), ch_y(-1));
            Smile[2] = new Point(ch_x(-1), ch_y(-0.5));
            Smile[3] = new Point(ch_x(-0.5), ch_y(-0.5));
            Smile[4] = new Point(ch_x(1), ch_y(-1));
            Smile[5] = new Point(ch_x(2), ch_y(-0.5));

            Point[] Body = new Point[32];
            Body[0] = new Point(ch_x(6), ch_y(-1.5));
            Body[1] = new Point(ch_x(7), ch_y(-3));
            Body[2] = new Point(ch_x(7.5), ch_y(-5));
            Body[3] = new Point(ch_x(7.5), ch_y(-7.5));
            Body[4] = new Point(ch_x(7.5), ch_y(-10));
            Body[5] = new Point(ch_x(7), ch_y(-12));
            Body[6] = new Point(ch_x(6.5), ch_y(-13));
            Body[7] = new Point(ch_x(6), ch_y(-13.5));
            Body[8] = new Point(ch_x(5), ch_y(-14));
            Body[9] = new Point(ch_x(4.5), ch_y(-14));
            Body[10] = new Point(ch_x(4), ch_y(-14));
            Body[11] = new Point(ch_x(6), ch_y(-15.5));
            Body[12] = new Point(ch_x(5), ch_y(-15.5));
            Body[13] = new Point(ch_x(5.5), ch_y(-16));
            Body[14] = new Point(ch_x(4.5), ch_y(-15.5));
            Body[15] = new Point(ch_x(5), ch_y(-17));
            Body[16] = new Point(ch_x(3), ch_y(-14.5));
            Body[17] = new Point(ch_x(0), ch_y(-14));
            Body[18] = new Point(ch_x(-2.5), ch_y(-14.5));
            Body[19] = new Point(ch_x(-4), ch_y(-16.5));
            Body[20] = new Point(ch_x(-4), ch_y(-15.5));
            Body[21] = new Point(ch_x(-4.5), ch_y(-16));
            Body[22] = new Point(ch_x(-4.5), ch_y(-15.5));
            Body[23] = new Point(ch_x(-5.5), ch_y(-16));
            Body[24] = new Point(ch_x(-5), ch_y(-14.5));
            Body[25] = new Point(ch_x(-6), ch_y(-14));
            Body[26] = new Point(ch_x(-7), ch_y(-13));
            Body[27] = new Point(ch_x(-7.5), ch_y(-12));
            Body[28] = new Point(ch_x(-8.5), ch_y(-10));
            Body[29] = new Point(ch_x(-8.5), ch_y(-8));
            Body[30] = new Point(ch_x(-8), ch_y(-5));
            Body[31] = new Point(ch_x(-7.5), ch_y(-2.5));

            Point[] L_hand = new Point[8];
            L_hand[0] = new Point(ch_x(-5.5), ch_y(-4.5));
            L_hand[1] = new Point(ch_x(-3), ch_y(-9));
            L_hand[2] = new Point(ch_x(-3), ch_y(-10));
            L_hand[3] = new Point(ch_x(-3.5), ch_y(-9.5));
            L_hand[4] = new Point(ch_x(-3.5), ch_y(-10.5));
            L_hand[5] = new Point(ch_x(-4), ch_y(-10));
            L_hand[6] = new Point(ch_x(-4), ch_y(-11));
            L_hand[7] = new Point(ch_x(-7), ch_y(-8));

            Point[] R_hand = new Point[7];
            R_hand[0] = new Point(ch_x(3.5), ch_y(-5));
            R_hand[1] = new Point(ch_x(2.5), ch_y(-9.5));
            R_hand[2] = new Point(ch_x(3), ch_y(-9));
            R_hand[3] = new Point(ch_x(3), ch_y(-10));
            R_hand[4] = new Point(ch_x(4), ch_y(-9));
            R_hand[5] = new Point(ch_x(4), ch_y(-10));
            R_hand[6] = new Point(ch_x(6.5), ch_y(-6));

            Point[] R_ear_y = new Point[5];
            R_ear_y[0] = new Point(ch_x(3), ch_y(8.5));
            R_ear_y[1] = new Point(ch_x(7), ch_y(9.5));
            R_ear_y[2] = new Point(ch_x(11), ch_y(10));
            R_ear_y[3] = new Point(ch_x(8), ch_y(6.5));
            R_ear_y[4] = new Point(ch_x(4.5), ch_y(7));

            Point[] R_ear_b = new Point[3];
            R_ear_b[0] = new Point(ch_x(8), ch_y(6.5));
            R_ear_b[1] = new Point(ch_x(13), ch_y(9.5));
            R_ear_b[2] = new Point(ch_x(11), ch_y(10));

            Point[] tail = new Point[14];
            tail[0] = new Point(ch_x(7.5), ch_y(-7.5));
            tail[1] = new Point(ch_x(9), ch_y(-7));
            tail[2] = new Point(ch_x(7.5), ch_y(-5));
            tail[3] = new Point(ch_x(9.5), ch_y(-3.5));
            tail[4] = new Point(ch_x(7.5), ch_y(-1));
            tail[5] = new Point(ch_x(9), ch_y(2));
            tail[6] = new Point(ch_x(14), ch_y(8));
            tail[7] = new Point(ch_x(14), ch_y(0.5));
            tail[8] = new Point(ch_x(11.5), ch_y(-1.5));
            tail[9] = new Point(ch_x(13), ch_y(-3.5));
            tail[10] = new Point(ch_x(9.5), ch_y(-5.5));
            tail[11] = new Point(ch_x(10.5), ch_y(-7.5));
            tail[12] = new Point(ch_x(9), ch_y(-9.5));
            tail[13] = new Point(ch_x(7), ch_y(-12));

            g.FillPolygon(brush_yellow, tail);
            g.DrawLines(pen, tail);

            g.FillPolygon(brush_black, L_ear_b);
            g.DrawLines(pen, L_ear_b);

            g.FillPolygon(brush_black, R_ear_b);
            g.DrawLines(pen, R_ear_b);

            g.FillPolygon(brush_yellow, Body);
            g.DrawLines(pen, Body);

            g.FillPolygon(brush_yellow, L_head_y);
            g.DrawLines(pen, L_head_y);

            g.FillPolygon(brush_black, Nose);
            g.DrawCurve(pen, Smile);

            g.FillPolygon(brush_yellow, L_ear_y);
            g.DrawLines(pen, L_ear_y);

            g.FillPolygon(brush_yellow, R_ear_y);
            g.DrawLines(pen, R_ear_y);

            g.DrawLines(p, L_hand);
            g.DrawLines(p, R_hand);

            Rectangle R_eye = new Rectangle(ch_x(2), ch_y(4.5), (8 * 5), (8 * 5));
            Rectangle L_eye = new Rectangle(ch_x(-6.5), ch_y(4.5), 16 * 3, 16 * 3);

            g.FillEllipse(brush_black, R_eye);
            g.FillEllipse(brush_black, L_eye);
            g.FillEllipse(brush_white, ch_x(2.75), ch_y(4), 8, 16);
            g.FillEllipse(brush_white, ch_x(-5.75), ch_y(3.85), 12, 16);
            
            
            g.FillEllipse(brush_red, ch_x(-7.5), ch_y(0.5), 32, 40);
            g.FillEllipse(brush_red, ch_x(4), ch_y(1), 32, 40);
            
            g.DrawArc(new Pen(Color.Pink, 2), ch_x(-7), ch_y(0), 16, 20, 180, 180);
            g.DrawArc(new Pen(Color.Pink, 2), ch_x(4.5), ch_y(0.5), 16, 20, 180, 180);

            g.FillPie(new SolidBrush(Color.Pink), ch_x(-7), ch_y(0), 16, 20, -45, 270);
            g.FillPie(new SolidBrush(Color.Pink), ch_x(4.5), ch_y(0.5), 16, 20, -45, 270);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
