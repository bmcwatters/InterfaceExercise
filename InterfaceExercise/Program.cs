using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car {Year = "1995", Make = "Ford", Model = "Escort", Wheels = 4, HasTrunk = true};
            Truck myFirstTruck = new Truck { Year = "1998", Make = "Ford", Model = "F-150", Wheels = 4, HasBed = true };
            SUV myFirstSUV = new SUV { Year = "2005", Make = "Hyundai", Model = "Santa Fe", Wheels = 4, HasBed = false };

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstSUV);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make}, Model: {vehicle.Model}, Wheels: {vehicle.Wheels}");
                Console.WriteLine();
                vehicle.Drive();
                Console.WriteLine();
            }














            Console.ReadLine();


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
