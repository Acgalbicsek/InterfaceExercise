using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {

        public bool HasTrunk { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasAutoStart { get; set; }
        public int NumberOfDoors { get; set; }

        public void DisplayDetails();
    }
}
