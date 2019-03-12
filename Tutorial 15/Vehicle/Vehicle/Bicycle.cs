using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Bicycle : Vehicle
    {
        public int Gears;
        public bool Bell;

        public Bicycle(bool bell, string colour, int gears)
        {
            Gears = gears;
            Bell = bell;
            Colour = colour;
        }

        public string ToString()
        {
            return ("Bicycle:\nColour:"+ Colour +"\nNo Of Gears:"+ Gears +"\nBell:" + Bell);
        }
    }
}
