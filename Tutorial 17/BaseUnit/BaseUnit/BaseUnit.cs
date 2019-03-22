using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseUnit
{
    public class BaseUnit
    {
        private GraphicsCard GC;
        private Motherboard MBoard;
        private PowerSupply PSU;
        private Processor CPU;
        private List<RAMemory> ramList = new List<RAMemory>();

        public BaseUnit(GraphicsCard graphicsCard, Motherboard motherboard, PowerSupply powersupply, Processor processor)
        {
            GC = graphicsCard;
            MBoard = motherboard;
            PSU = powersupply;
            CPU = processor;
        }

        public override string ToString()
        {
            string StringTemp = "";
            StringTemp += MBoard.ToString() + "\n\n";
            StringTemp += PSU.ToString() + "\n\n";
            StringTemp += CPU.ToString() + "\n\n";
            StringTemp += GC.ToString() +"\n\n";
            foreach (var r in ramList)
            {
                StringTemp += r.ToString() + "\n\n";

            }
      
            return StringTemp;
        }

        public void AddRAM(RAMemory ram)
        {
            ramList.Add(ram);
        }
        public bool TestRAM()
        {
            if (ramList.Count >= 2)
            {
                return true;
            }

            return false;
        }
    }
}