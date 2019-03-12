using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : MotorVehicle
    {
        public int NoOfDoors;

        public Car(string colour, int engineSize, int noOfDoors)
        {
            NoOfDoors = noOfDoors;
            Colour = colour;
            EngineSize = engineSize;
        }

        public string ToString()
        {
            return "Car:\nColour:"+ Colour +"\nEngine Size:"+ EngineSize +"\nNo Of Doors:"+ NoOfDoors ;
        }
    }
}