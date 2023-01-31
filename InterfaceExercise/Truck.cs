using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany 
    {
        public bool IsLifted { get; set; }  = true;
        public bool CanTowABoat { get; set; } = true;   
        public bool VehicleMovesForward { get; set ; } = true;
        public bool VehicleReverses { get; set; } = true;
        public bool HasHorn { get ; set ; } = true;
        public bool NeedsGas { get ; set ; } = true;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "2500";
    }
}
