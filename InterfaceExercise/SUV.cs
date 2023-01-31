using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HasThirdRowSeating { get; set; } = true;
        public bool IsBeingDrivenBySoccerMom { get; set; } = true;
        public bool VehicleMovesForward { get; set; } = true;
        public bool VehicleReverses { get ; set; } = true;
        public bool HasHorn { get ; set ; } = true;
        public bool NeedsGas { get; set ; } = true;
        public string Make { get; set; } = "Kia";
        public string Model { get; set; } = "Sorento";

        
        
    }

        
    
}
