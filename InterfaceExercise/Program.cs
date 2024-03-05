using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
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

            

            Car myMustang = new Car()
            {
                HasTrunk = true,
                IsConvertible = false,
                NumberOfWheels = 4,
                HorsePower = 400,
                Make = "Ford",
                Model = "Shelby",
                Logo = "Cobra",
                CountryOfOrigin = "USA"
            };
                
            SUV myHonda = new SUV()
            {
                TrunkSpace = 18,
                IsFourWheelDrive = true,
                NumberOfWheels = 4,
                HorsePower = 285,
                Make = "Honda",
                Model = "Pilot",
                Logo = "H",
                CountryOfOrigin = "Japan"
            };

            Truck myTruck = new Truck()
            {
                IsAPickup = true,
                TireSize = 22,
                NumberOfWheels = 4,
                HorsePower = 305,
                Make = "Ram",
                Model = "1500",
                Logo = "RAM",
                CountryOfOrigin = "USA"

            };
            List<IVehicle> vehicles = new List<IVehicle> { myMustang, myHonda, myTruck };

            foreach (var automobile in vehicles)

            {
                Console.WriteLine($"\t Make: {automobile.Make}\t Model: {automobile.Model}\n");
                Console.WriteLine($"\t Number of Wheels: {automobile.NumberOfWheels}\t HorsePower: {automobile.HorsePower}\n");

                if (automobile is ICompany company)
                {
                    Console.WriteLine($"\t Logo: {company.Logo}\t Country of Origin: {company.CountryOfOrigin}\n");
                }
                if (automobile is Truck myPickUp)

                {
                    Console.WriteLine($"\t This is a Pickup Truck: {myPickUp.IsAPickup}\t Tire Size is: {myPickUp.TireSize} inches\n\n");
                }
                if (automobile is SUV mySUV)
                {
                    Console.WriteLine($"\t Trunk Space: {mySUV.TrunkSpace}\t Is this vehicle 4 wheel drive = {mySUV.IsFourWheelDrive}\n\n");
                }
                if (automobile is Car myCar)
                {
                    Console.WriteLine($"\t This Car has a Trunk: {myCar.HasTrunk}\t This Car has is a Convertible: {myCar.IsConvertible}\n\n");
                }


                //Option for displaying values: 
                //Create a stubbed out method called DisplayDetails in your IVehicle interface.
                //Implement the stubbed out method in the derived classes.
                //In the scope of them method, use string interpolation to display property values.
                //In order to also interpolate values from ICompany, research how to extend interfaces.
            }
        }
                
    }
}
