using System.Drawing.Drawing2D;

namespace electrigreen.ComponentControls
{
    internal class MyRectangle
    {
        private float x, y, width, height, radius;
        private Point _location;
        private GraphicsPath _graphicsPath;

        // Set rectangle
        public MyRectangle(float width, float height, float radius, float x=0F, float y=0F)
        {
            this._location = new Point(0, 0);
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.radius = radius;
            _graphicsPath = new GraphicsPath();

            if (radius <= 0F)
            {
                _graphicsPath.AddRectangle(new RectangleF(x, y, width, height));
            }
            else
            {
                _graphicsPath.AddArc(new RectangleF(x, y, 2F * radius, 2F * radius), 180F, 90F);
                _graphicsPath.AddArc(new RectangleF(width-(2F * radius)-1F,x,2F * radius, 2F * radius), 270F, 90F);
                _graphicsPath.AddArc(new RectangleF(width-(2F * radius)-1F, height-(2F * radius)-1F, 2F * radius, 2F * radius), 0F, 90F);
                _graphicsPath.AddArc(new RectangleF(x, height-(2F * radius)-1F, 2F * radius, 2F * radius),90F, 90F);
                _graphicsPath.CloseAllFigures();
            }
        }

        public GraphicsPath path => _graphicsPath;
        public RectangleF Rect => new RectangleF(x, y, width, height);
        public float Radius { get => radius; set => radius = value; }

    }
}