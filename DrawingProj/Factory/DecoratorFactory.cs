using System.Drawing;

namespace Drawing
{
    class DecoratorFactory: ShapeFactory
    {
        protected new static DecoratorFactory Factory;

        private DecoratorFactory(){}
        public static DecoratorFactory getDecoratorFactory()
        {
            if (Factory == null)
            {
                Factory = new DecoratorFactory();
            }
            return Factory;
        }

        public  virtual Shape  GetShape(float x, float y, float width, float height, Color Line, Color Fill)
        {
            return new Shape(x,  y,  width, height, Line, Fill);
        }
    }
}
