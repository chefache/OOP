namespace Shapes.Shapes
{
    using System;

    class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get 
            {
                return radius; 
            }
            protected set
            { 
                radius = value; 
            }
        }


        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
           return Math.PI * (this.radius * this.radius);
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
