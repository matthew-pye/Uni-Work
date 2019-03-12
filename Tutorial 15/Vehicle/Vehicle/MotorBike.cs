using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class MotorBike : MotorVehicle
    {
        public string SwingType;

        public MotorBike(string colour, int engineSize, string swingType)
        {
            Colour = colour;
            EngineSize = engineSize;
            SwingType = swingType;
        }

        public string ToString()
        {
            return "MotorBike:\nColour:"+ Colour +"\nEngine:"+ EngineSize +"\nSwing Type:"+ SwingType;
        }
    }
}