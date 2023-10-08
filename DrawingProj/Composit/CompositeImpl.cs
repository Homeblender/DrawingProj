using System.Collections.Generic;
using System.Drawing;

namespace Drawing.Composit
{
    public class CompositeImpl : Shape, Composite
    {
        private List<Shape> list = new List<Shape>();
        
        
        public CompositeImpl(float x, float y, float width, float height, Color Line, Color Fill) : base(x, y, width, height, Line, Fill) {}

        public override void Draw(Graphics G)
        {
            Pen pen = new Pen(Color.Blue, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            G.DrawRectangle(pen, this.x - 8, this.y - 8, width + 16, height + 16);
        }

        public void add(Shape shape)
        {
            if (!list.Contains(shape))
            {
                list.Add(shape);
            }
        }

        public override void Move(float x, float y)
        {
            this.x = x - DX;
            this.y = y - DY;
            
            foreach (var item in list)
            {
                item.Move(x, y);
            }
        }

        public List<Shape> getElement()
        {
            return list;
        }

        public void remove(Shape shape)
        {
            list.Remove(shape);
        }

        public override bool Touch(float x, float y)
        {
            return false;
        }

        public void CountDelta(float x, float y)
        {
            foreach (var item in list)
            {
                item.DX = x - item.X;
                item.DY = y - item.Y;
            }
            DX = x - X;
            DY = y - Y;
        }

        public void Update()
        {
            foreach (var item in list)
            {
                if (item.X < X)
                {
                    X = item.X;
                }
                if (item.Y < Y)
                {
                    Y = item.Y;
                }
            }

            foreach (var item in list)
            {
                if (item.X + item.Width >= X + Width)
                {
                    Width = item.X + item.Width - X;
                }
                if (item.Y + item.Height >= Y + Height)
                {
                    Height = item.Y + item.Height - Y;
                }
            }
        }
    }
}