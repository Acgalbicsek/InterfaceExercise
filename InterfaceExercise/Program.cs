using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SUV suv = new SUV()
            {
                MPG = 31,
                HasThirdRow = true,
                HasTrunk = true,
                NumberOfWheels = 4,
                HasAutoStart = true,
                NumberOfDoors = 4,
                Logo = "KIA",
                FreeTestDrive = true,
            };
            suv.DisplayDetails();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Car car = new Car()
            {
                HasTrunk = true,
                NumberOfWheels = 4,
                HasAutoStart = true,
                NumberOfDoors = 4,
                Logo = "Honda",
                FreeTestDrive = true,
                HasAWD = true,
                HasHeatedSeats = true
            };
            car.DisplayDetails();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Truck truck = new Truck()
            {
                Has4WD = true,
                HasExtendedCab = true,
                HasTrunk = false,
                HasAutoStart = false,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                FreeTestDrive = true,
                Logo = "Chevy"
            };
            truck.DisplayDetails();
            
               
        
            

               
        
        }
            

           

            

            
                
               
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        
    }
}
