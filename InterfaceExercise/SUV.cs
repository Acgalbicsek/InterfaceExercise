using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int MPG { get; set; }
        public bool HasThirdRow { get; set; }
        public bool HasTrunk { get ; set ; }
        public int NumberOfWheels { get ; set; }
        public bool HasAutoStart { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public string Logo { get ; set ; }
        public bool FreeTestDrive { get; set ; }

      

        public void DisplayDetails()
        {
            Console.WriteLine($"This {Logo} SUV has the following features: "  +
                    $"Has third row: {HasThirdRow} " +
                    $"Has auto start: {HasAutoStart} " +
                    $"Has {NumberOfWheels} wheels and {NumberOfDoors} doors " +
                    $"Has an MPG rating of {MPG} " +
                    $"Can you test drive for free today?  Of course! That's {FreeTestDrive}!" );
        }
    }
}
