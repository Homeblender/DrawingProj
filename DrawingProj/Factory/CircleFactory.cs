using System.Drawing;

namespace Drawing
{
    class CircleFactory:ShapeFactory
    {
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Circle(x, y, width, height, Line, Fill);
        }
    }
}
