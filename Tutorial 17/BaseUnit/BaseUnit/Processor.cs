using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseUnit
{
    public class Processor
    {
        public Processor(string cpu, float ghz)
        {
            CPU = cpu;
            Ghz = ghz;
        }

        public string CPU
        {
            get => default(string);
            set
            {
            }
        }
        public float Ghz
        {
            get => default(int);
            set
            {
            }
        }

        public override string ToString()
        {
            string StringTemp = "";
            StringTemp += "Processor - \n";
            StringTemp += "CPU: " + CPU;
            StringTemp += "\nGhz: " + Ghz;
            return StringTemp;
        }
    }
}