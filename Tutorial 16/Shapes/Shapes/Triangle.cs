namespace Shapes
{
    public class Triangle : Area, Sides
    {
        private double _Bottom;
        private double _Height;
        private int _NoSides;

        public double Bottom
        {
            get => _Bottom;
            set { _Bottom = Bottom; }
        }
        public double Height
        {
            get => _Height;
            set => _Height = Height;
        }
        public int NoSides
        {
            get => _NoSides;
            set => _NoSides = NoSides;
        }

        public Triangle(double bottom, double height)
        {
            Bottom = bottom;
            Height = height;
            NoSides = 3;
        }

        public double GetArea()
        {
            return (Bottom /2) * Height;
        }

        public int NumberOfSides()
        {
            return NoSides;
        }

        public override string ToString()
        {
            string StringTemp = "";
            StringTemp += "Bottom: " + Bottom;
            StringTemp += "\nHeight: " + Height;
            StringTemp += "\n# of sides: " + NoSides;

            return StringTemp;
        }
    }
}