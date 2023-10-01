using System;
using System.Drawing;

namespace Drawing
{
    [Serializable]
    class Shape
    {
        
        public Shape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.Line = Line;
            this.Fill = Fill;
        }
        protected float x, y, width, height;
        protected float dx, dy;

        protected Color Line, Fill;

        
        public virtual void Draw(Graphics G) {}

        public float X
        {
            get => x;
            set => x = value;
        }
        public float Y
        {
            get => y;
            set => y = value;
        }
        public float DX
        {
            get => dx;
            set => dx = value;
        }
        public float DY
        {
            get => dy;
            set => dy = value;
        }
        public Color line
        {
            get => Line;
            set => Line = value;
        }
        public Color fill
        {
            get => Fill;
            set => Fill = value;
        }
        public float Width
        {
            get => width;
            set => width = value;
        }
        public float Height
        {
            get => height;
            set => height = value;
        }
        public virtual bool Touch(float x, float y)
        {
            return true;
        }
        public virtual void Move(float x, float y)
        {
            this.x = x - DX;
            this.y = y - DY;
        }
    }
}
