using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseUnit
{
    public class GraphicsCard
    {
        public GraphicsCard(string model, float speed)
        {
            Model = model;
            Speed = speed;
        }

        public string Model
        {
            get => default(string);
            set
            {
            }
        }
        public float Speed
        {
            get => default(int);
            set
            {
            }
        }

        public override string ToString()
        {
            string StringTemp = "";
            StringTemp += "Graphics Card - \n";
            StringTemp += "Model: " + Model;
            StringTemp += "\nSpeed: " + Speed;
            return StringTemp;
        }
    }
}