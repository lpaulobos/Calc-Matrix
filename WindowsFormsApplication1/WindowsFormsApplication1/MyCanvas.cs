﻿using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class MyCanvas : PictureBox
    {
        private bool desenho1 = true;
        private bool desenhar = true;
        public List<Point> points = new List<Point>();
        public Point[] pts;
        public bool Desenho1
        {
            get
            {
                return this.desenho1;
            }
            set
            {
                this.desenho1 = value;
                this.Invalidate();
            }
        }
        public bool Desenhar
        {
            get
            {
                return this.desenhar;
            }
            set
            {
                this.desenhar = value;

                this.Invalidate();
            }
        }

        public MyCanvas()
        {
            
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {

            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Pen grayPen = new Pen(Color.FromArgb(55, 0, 0, 0));
            SolidBrush brush = new SolidBrush(Color.Black);
            FillMode fMode = FillMode.Winding;
            grayPen.Width = 2f;

            for (int i = 0; i < 800; i += 25) {

                if (i == 400 && grayPen.Color == Color.FromArgb(55, 0, 0, 0) && i < 800)
                {
                    grayPen.Color = Color.FromArgb(255, 0, 0, 0);
                    e.Graphics.DrawLine(grayPen, new Point(i, 0), new Point(i, 600));
                }
                else if (i < 800)
                    e.Graphics.DrawLine(grayPen, new Point(i, 0), new Point(i, 600));

                if (i == 200 && grayPen.Color == Color.FromArgb(55, 0, 0, 0) && i < 400)
                {
                    grayPen.Color = Color.FromArgb(255, 0, 0, 0);
                    e.Graphics.DrawLine(grayPen, new Point(0, i), new Point(800, i));
                }
                else if (i < 400)
                    e.Graphics.DrawLine(grayPen, new Point(0, i), new Point(800, i));

                grayPen.Color = Color.FromArgb(55, 0, 0, 0);
            }
            //if (Desenho1) e.Graphics.DrawPolygon(pen, pts);
            for (int i = 0; i < 8; i++) { 
                points.Add( new Point(10 + 10 * i, 10 + 8 * i));
            }
                 if (desenhar) {
                     e.Graphics.FillPolygon(brush, points.ToArray(),fMode);
                 }
     
        }

    }
       
}
