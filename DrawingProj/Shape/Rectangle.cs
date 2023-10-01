using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Drawing
{
    [Serializable]
    class Rectangle:Shape
    {
        public Rectangle(float x, float y, float width, float height, Color Line, Color Fill)
    : base(x, y, width, height, Line, Fill)
        {

        }
        public override void Draw(Graphics G)
        {
            G.FillRectangle(new SolidBrush(Fill), x, y, width, height);
            G.DrawRectangle(new Pen(Line), x, y, width, height);            
        }
        public override bool Touch(float x, float y)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new RectangleF(this.x, this.y, width, height));
            graphicsPath.IsVisible(x, y);
            return graphicsPath.IsVisible(x, y);
        }
    }
}
