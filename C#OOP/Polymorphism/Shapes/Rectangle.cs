using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }


        public int Width
        {
            get { return width; }
            private set { width = value; }
        }

        public override double CalculatePerimeter()
        {
            return (width * 2) + (height * 2);
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
           sb.Append( DrawLine(this.width, '*', '*'));
            for (int i = 1; i < this.height - 1; ++i)
                sb.Append(DrawLine(this.width, '*', ' '));
            sb.Append(DrawLine(this.width, '*', '*'));
            return sb.ToString();
        }

        private string DrawLine(int width, char end, char mid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(end);
            for (int i = 1; i < width - 1; ++i)
               sb.Append(mid);
            sb.AppendLine(end.ToString());
            return sb.ToString();
        }
    }
}
