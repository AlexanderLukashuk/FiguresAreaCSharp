using System;
namespace FiguresArea.Shapes
{
	public class Circle : Shape
	{
        private double radius;

		public Circle(double radius)
		{
            this.radius = radius;
		}

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

