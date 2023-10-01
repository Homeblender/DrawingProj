using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    class RectangleFactory:ShapeFactory
    {
        protected new static RectangleFactory Factory;

        private RectangleFactory(){}
        public static RectangleFactory getRectangleFactory()
        {
            if (Factory == null)
            {
                Factory = new RectangleFactory();
            }
            return Factory;
        }
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Rectangle(x, y, width, height, Line, Fill);
        }
    }
}
