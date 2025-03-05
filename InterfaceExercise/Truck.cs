using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool Has4WD { get; set; }
        public bool HasExtendedCab { get; set; }
        public bool HasTrunk { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public bool HasAutoStart { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public string Logo { get ; set ; }
        public bool FreeTestDrive { get ; set ; }


        

        public void DisplayDetails()
        {
            Console.WriteLine($"This {Logo} truck has the following features: " +
                    $"Has 4WD capabilities{Has4WD} " +
                    $"Has auto start: {HasAutoStart} " +
                    $"Has {NumberOfWheels} wheels and {NumberOfDoors} doors " +
                    $"Has extended cab: {HasExtendedCab} " +
                    $"Can you test drive for free today?  Of course! That's {FreeTestDrive}! ");
        }
    }
}
