using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool VehicleMovesForward {get; set;}

        public bool VehicleReverses {get; set;}

        public bool HasHorn { get; set; }

        public bool NeedsGas { get; set; }
        
        

    }
}
