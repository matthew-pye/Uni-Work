namespace BaseUnit
{
    public class Motherboard
    {
        public Motherboard(string make, string model)
        {
            Model = model;
            Make = make;
        }

        public string Make
        {
            get => default(string);
            set
            {
            }
        }
        public string Model
        {
            get => default(string);
            set
            {
            }
        }

        public override string ToString()
        {
            string StringTemp = "";
            StringTemp += "Motherboard - \n";
            StringTemp += "Make: " + Make;
            StringTemp += "\nModel: " + Model;
            return StringTemp;
        }
    }
}