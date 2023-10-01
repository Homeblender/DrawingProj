using System.Drawing;

namespace Drawing
{
    class RectangleFactory : ShapeFactory
    {
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Rectangle(x, y, width, height, Line, Fill);
        }
    }
}
