using Shapes.Shapes;
using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            IDrawable drawRectangle = new Rectangle(10, 4);
            drawRectangle.Draw();

            IDrawable drawCircle = new Circle(20);
            drawCircle.Draw();
        }
    }
}
