namespace Shapes.Shapes
{
    public class Rectangle : Shape
    {
        private int heigh;
        private int width;

        public Rectangle(int heigh, int width)
        {
            this.Heigh = heigh;
            this.Width = width;
        }

        public int Heigh
        {
            get 
            { 
                return heigh; 
            }
            private set 
            { 
                heigh = value; 
            }
        }

        public int Width
        {
            get
            { 
                return width;
            }
            private set 
            { 
                width = value; 
            }
        }

        public override double CalculatePerimeter()
        {
            return this.width * this.heigh;
        }

        public override double CalculateArea()
        {
            return 0;
        }
        public override string Draw()
        {
            return base.Draw();
        }
    }
}
