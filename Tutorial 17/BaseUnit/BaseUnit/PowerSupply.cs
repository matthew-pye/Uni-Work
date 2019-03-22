using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseUnit
{
    public class PowerSupply
    {
        public PowerSupply(int watt)
        {
            Watt = watt;
        }

        public int Watt
        {
            get => default(int);
            set
            {
            }
        }

        public override string ToString()
        {
            string StringTemp = "";
            StringTemp += "Power Supply - \n";
            StringTemp += "Watt: " + Watt;
            return StringTemp;
        }
    }
}