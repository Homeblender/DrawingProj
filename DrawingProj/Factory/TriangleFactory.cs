using System.Drawing;

namespace Drawing
{
    class TriangleFactory:ShapeFactory
    {
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Triangle(x, y, width, height, Line, Fill);
        }
    }
}
