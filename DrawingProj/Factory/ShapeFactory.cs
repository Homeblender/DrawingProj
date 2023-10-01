using System.Drawing;

namespace Drawing
{
    class ShapeFactory
    {
        protected static ShapeFactory factory;

        public  virtual Shape  GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Shape(x,  y,  width, height, Line, Fill);
        }
    }
}
