namespace Shapes
{
    public class Rectangle : Area, Sides
    {
        private double _Height;
        private int _NoSides;
        private double _Width;

        private double Height
        {
            get => _Height;
            set { _Height = Height; }
        }
        private int NoSides
        {
            get => _NoSides;
            set { _NoSides = NoSides; }
        }
        private double Width
        {
            get => _Width;
            set { _Width = Width; }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            NoSides = 4;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public int NumberOfSides()
        {
            return NoSides;
        }

        public override string ToString()
        {
            string StringTemp = "";

            StringTemp += "Width:" + Width;
            StringTemp += "\nHeight:" + Height;
            StringTemp += "\n# Of Sides:" + NoSides;

            return StringTemp;
        }
    }
}