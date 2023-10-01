using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Drawing.Decorator
{
    class Decorator : Shape
    {
        public SelectType Type { get; set; }
        public Shape Shape { get; set; }

        public Color shapeLine;
        public Color shapeFill;


        public Decorator(float x, float y, float width, float height, Color Line, Color Fill)
            : base(x, y, width, height, Line, Fill)
        {
            Type = SelectType.NONE;
        }
        
        public void SetType(float x, float y)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new RectangleF(this.x, this.y, width/5, height/5));
            if (graphicsPath.IsVisible(x, y))
            {
                Type = SelectType.TOP_LEFT;
                return;
            }
            graphicsPath.Reset();
            
            graphicsPath.AddRectangle(new RectangleF(this.x+width-width/5, this.y, width/5, height/5));
            if (graphicsPath.IsVisible(x, y))
            {
                Type = SelectType.TOP_RIGHT;
                return;
            }
            graphicsPath.Reset();
            
            graphicsPath.AddRectangle(new RectangleF(this.x, this.y+height-height/5, width/5, height/5));
            if (graphicsPath.IsVisible(x, y))
            {
                Type = SelectType.BOTTOM_LEFT;
                return;
            }
            graphicsPath.Reset();
            
            graphicsPath.AddRectangle(new RectangleF(this.x+width-width/5, this.y+height-height/5, width/5, height/5));
            if (graphicsPath.IsVisible(x, y))
            {
                Type = SelectType.BOTTOM_RIGHT;
                return;
            }
            graphicsPath.Reset();
            
            graphicsPath.AddRectangle(new RectangleF(this.x, this.y, width, height));
            if (graphicsPath.IsVisible(x, y))
            {
                Type = SelectType.CENTER;
                return;
            }
            graphicsPath.Reset();
        }
        

        public void Update()
        {
            Shape.X = X;
            Shape.Y = Y;
            Shape.Width = Width;
            Shape.Height = Height;
            Shape.line = shapeLine;
            Shape.fill = shapeFill;
        }
        public override bool Touch(float x, float y)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new RectangleF( this.x - 8, this.y - 8, width + 16, height + 16));
            graphicsPath.IsVisible(x, y);
            return graphicsPath.IsVisible(x, y);
        }

        public void Assign(Shape shape, MouseEventArgs e)
        {
            Shape = shape;
            shapeLine = shape.line;
            shapeFill = shape.fill;
            
            shape.DX = e.X - shape.X;
            shape.DY = e.Y - shape.Y;

            DX = e.X - X;
            DY = e.Y - Y;
            
            Move(e.X, e.Y);
            SetType(e.X, e.Y);
        }
        
        public override void Draw(Graphics G)
        {
            Pen pen = new Pen(Color.Blue, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            G.DrawRectangle(pen, this.x - 8, this.y - 8, width + 16, height + 16);
        }
        public void Drag(float x, float y)
        {
            if (Type == SelectType.CENTER)
            {
                this.x = x - DX;
                this.y = y - DY;
                Move(x, y);
            }
            else if (Type == SelectType.TOP_RIGHT)
            {
                width = x - X;
                float deltaY = y - Y;
                Y = y;
                height -= deltaY;
            }
            else if (Type == SelectType.TOP_LEFT)
            {
                float deltaY = y - Y;
                float deltaX = x - X;
                Y = y;
                X = x;
                height -= deltaY;
                width -= deltaX;
            }
            else if (Type == SelectType.BOTTOM_RIGHT)
            {
                height = y - Y;
                width = x - X;
            }
            else if (Type == SelectType.BOTTOM_LEFT)
            {
                height = y - Y;
                float deltaX = x - X;
                X = x;
                width -= deltaX;
            }

            width = width <= 15 ? 14 : width;
            height = height <= 15 ? 14 : height;
            SetType(x,y);
            Update();

        }
    }
}