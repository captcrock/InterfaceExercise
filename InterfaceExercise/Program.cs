using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
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
            var suv1 = new SUV();
            suv1.AWD = true;
            suv1.NumberOfSeats = 7;
            suv1.Make = "Toyota";
            suv1.MainColor = "Red";
            suv1.NumberOfDoors = 4;
            suv1.TireSize = 33125020;
            suv1.WorldWide = true;
            suv1.Year = 2015;
           

            var truck1 = new Truck();
            truck1.TypeOfBed = "short";
            truck1.FWD = true;
            truck1.Year = 2011;
            truck1.Make = "Ford";
            truck1.NumberOfDoors = 4;
            truck1.MainColor = "Blue";
            truck1.TireSize = 2755520;
            truck1.WorldWide = true;
           

            var car1 = new Car();
            car1.CoupOrHatchback = "Coup";
            car1.SportsCar = false;
            car1.MainColor = "gray";
            car1.Make = "Tesla";
            car1.NumberOfDoors = 2;
            car1.TireSize = 2055016;
            car1.WorldWide = true;
            car1.Year = 2019;



            //Creatively display and organize their values

            Console.WriteLine($"Today we're giving away 3 free vehicles! A {truck1.Make} {truck1.MainColor} {truck1.NumberOfDoors} {truck1.TypeOfBed} {truck1.Year}. And 2 others! Stay tuned to find out what they are!");
        }
    }
}
