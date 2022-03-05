using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, radius);
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;
            for (double y = this.radius; y >= -this.radius; --y)
            {
                for (double x = -this.radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                       sb.Append("*");
                    else
                       sb.Append(" ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
