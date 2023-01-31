using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {



        static void Main(string[] args)
        {
            var car1 = new Car() { Make = "Toyota Tercel"};
           

            var truck1 = new Truck() {Make = "Chevy 2500"};
         

            var SUV1 = new SUV() { Make = "Kia Sorento"};
           

            var vehicles = new List<IVehicle>();

            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(SUV1);






            foreach (var vehicle in vehicles)
            {

                Console.WriteLine($"Does it use gas? {vehicle.NeedsGas} \nDoes it have a horn? {vehicle.HasHorn} \nVehicle can drive forward? {vehicle.VehicleMovesForward} \nVehicle can reverse? {vehicle.VehicleReverses}");
                Console.WriteLine();

            }








            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // done Create 2 Interfaces called IVehicle & ICompany

            //Done Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            // DONE Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
