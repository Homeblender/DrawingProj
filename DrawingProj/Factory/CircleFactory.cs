using System.Drawing;

namespace Drawing
{
    class CircleFactory:ShapeFactory
    {
        protected static CircleFactory Factory;

        private CircleFactory(){}
        public static CircleFactory getCircleFactory()
        {
            if (Factory == null)
            {
                Factory = new CircleFactory();
            }
            return Factory;
        }
        public override Shape GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Circle(x, y, width, height, Line, Fill);
        }
    }
}
