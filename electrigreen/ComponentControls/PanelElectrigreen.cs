using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electrigreen.ComponentControls
{
    public class PanelElectrigreen : Panel
    {
        private int borderRadius = 1;
        private float gradientAngle = 45;
        private Color gradientTopColor = Color.White;
        private Color gradientBottomColor = Color.White;
        private float borderWidth = 2;
        private Color borderColor = Color.FromArgb(230, 230, 230);

        public PanelElectrigreen()
        {
            this.BackColor = Color.White;
            this.ForeColor = SystemColors.ControlText;
            this.Size = new Size(350, 200);
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public float GradientAngle { 
            get => gradientAngle; 
            set {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        public Color GradientTopColor { 
            get => gradientTopColor; 
            set {
                gradientTopColor = value;
                this.Invalidate();
            }
        }
        public Color GradientBottomColor { 
            get => gradientBottomColor; set {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }

        public float BorderWidth { 
            get => borderWidth; 
            set {
                borderWidth = value;
                this.Invalidate();
            }
        }

        public Color BorderColor { 
            get => borderColor; 
            set {
                borderColor = value;
                this.Invalidate();
            }
        }

        private GraphicsPath GetPaint(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width-radius, rectangle.Height-radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();

            return path;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, gradientTopColor, gradientBottomColor, gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);
            

            RectangleF rectangle = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetPaint(rectangle, borderRadius))
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    this.Region = new Region(path);
                    graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rectangle);
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    graphics.DrawRectangle(pen, 0, 0, this.Width - borderWidth, this.Height - borderWidth);
                }
            }
        }
    }
}
