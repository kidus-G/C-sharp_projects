using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Rectangle : Ishape
    {
        private double width, height;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePeremeter()
        {
            return 2 * (height + width);
        }

    }

    class circle : Ishape
    {
        static double PI = 3.14;

        public double Radius { get; set; }

        public override double CalculateArea()
        {
            double result;
            return result = (Radius * Radius) * PI;
        }

        public override double CalculatePeremeter()
        {
            return 2 * PI * Radius;
        }
    }
}

