using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace electrigreen.ComponentControls
{
    public class AuthButton : Button
    {
        private int _borderSize = 0;
        private int _borderRadius = 20;
        private Color _borderColor = Color.FromArgb(114, 199, 72);
        public AuthButton()
        {
            this.BackColor = Color.FromArgb(114, 199, 72);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Segoe UI", 9.00F, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Size = new Size(150, 40);
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8f, this.Height-1);

            if (_borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    if (_borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (_borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(_borderColor, _borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
