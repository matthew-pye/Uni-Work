using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace BaseUnit
{
    public class RAMemory
    {
        public RAMType Ram
        {
            get => default(RAMType);
            set
            {
            }
        }
        public int Size
        {
            get => default(int);
            set
            {
            }
        }

        public RAMemory(RAMType ram, int size)
        {
            Ram = ram;
            Size = size;
        }

        public override string ToString()
        {
            string StringTemp = "RAM - \n";
            StringTemp += "Ram type: " + Ram;
            StringTemp += "Size: " + Size;
            return StringTemp;
        }
    }
}