using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool SavesOnGas { get; set; } = true;
        public bool HasTrunk { get; set; } = true;
        public bool VehicleMovesForward { get; set; } = true;
        public bool VehicleReverses { get; set; } = true;
        public bool HasHorn { get; set; } = true;
        public bool NeedsGas { get; set; } = true;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Tercel";


        

    }
}
