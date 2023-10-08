using System.Collections.Generic;

namespace Drawing.Composit
{
    public interface Composite
    {
        void add(Shape shape);
        List<Shape> getElement();
        void remove(Shape shape);

    }
}