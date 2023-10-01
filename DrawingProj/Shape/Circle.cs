using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Drawing
{
    [Serializable]
    class Circle : Shape
    {
        public Circle(float x, float y, float width, float height, Color Line, Color Fill)
            : base(x, y, width, height, Line, Fill)
        {

        }
        public override void Draw(Graphics G)
        {
            G.FillEllipse(new SolidBrush(Fill), x, y, width, height);
            G.DrawEllipse(new Pen(Line), x, y, width, height);           
        }
        public override bool Touch(float x, float y)
        {
            GraphicsPath pt = new GraphicsPath();
            pt.AddEllipse(this.x, this.y, width, height);
            return pt.IsVisible(x, y);
        }
    }
}
