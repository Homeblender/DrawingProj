using System.Drawing;

namespace Drawing
{
    class DecoratorFactory : ShapeFactory
    {
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Decorator.Decorator(x,  y,  width, height, Line, Fill);
        }
    }
}
