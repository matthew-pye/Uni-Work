using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        static int count = 0;
        public string Colour;
        

        public Vehicle()
        {
            count++;
        }
        public int GetCount()
        {
            return count;
        }
    }
}
