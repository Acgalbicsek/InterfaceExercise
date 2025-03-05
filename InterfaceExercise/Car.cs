using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasHeatedSeats { get; set; }
        public bool HasAWD { get; set; }
        public bool HasTrunk { get ; set ; }
        public int NumberOfWheels { get ; set; }
        public bool HasAutoStart { get ; set ; }
        public int NumberOfDoors { get; set ; }
        public string Logo { get ; set ; }
        public bool FreeTestDrive { get ; set ; }

       

        public void DisplayDetails()
        {
            Console.WriteLine($"This {Logo} car has the following features: " +
                    $"Has AWD capabilities{HasAWD} " +
                    $"Has auto start: {HasAutoStart} " +
                    $"Has {NumberOfWheels} wheels and {NumberOfDoors} doors " +
                    $"Has heated seats: {HasHeatedSeats} " +
                    $"Can you test drive for free today?  Of course! That's {FreeTestDrive}! ");
        }
    }


      
    

       
    
}
