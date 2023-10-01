using System.Drawing;

namespace Drawing
{
    class TriangleFactory:ShapeFactory
    {
        protected static TriangleFactory Factory;

        private TriangleFactory(){}
        public static TriangleFactory getTriangleFactory()
        {
            if (Factory == null)
            {
                Factory = new TriangleFactory();
            }
            return Factory;
        }
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Triangle(x, y, width, height, Line, Fill);
        }
    }
}
