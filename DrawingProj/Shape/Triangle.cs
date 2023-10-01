using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Drawing
{
    [Serializable]
    class Triangle:Shape
    {
        public Triangle(float x, float y, float width, float height, Color Line, Color Fill)
            : base(x, y, width, height, Line,Fill)
        {

        }
        PointF[] points = new PointF[3];

        public override void Draw(Graphics G)
        {           
            points[0].X = x;
            points[1].X = x+width;
            points[2].X = x;
            points[0].Y = y;
            points[1].Y = y+height;
            points[2].Y = y+height;
            G.FillPolygon(new SolidBrush(Fill), points);
            G.DrawPolygon(new Pen(Line), points);
        }
        public override bool Touch(float x, float y)
        {
            GraphicsPath pt = new GraphicsPath();
            pt.AddPolygon(points);
            pt.IsVisible(x, y);
            if (pt.IsVisible(x, y))
            {
                return true;
            }
            else
                return false;
        }
    }
}
