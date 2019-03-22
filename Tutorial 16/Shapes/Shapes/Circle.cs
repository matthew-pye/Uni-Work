using System;

namespace Shapes
{
    public class Circle : Area
    {
        private double _Radius;

        public double Radius
        {
            get => _Radius;
            set { _Radius = Radius; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double getArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string ToString()
        {
            return Convert.ToString(Radius);
        }
    }
}