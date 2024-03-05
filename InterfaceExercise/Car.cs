using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }

        public bool IsConvertible { get; set; }

        public int NumberOfWheels { get; set; }

        public int HorsePower { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Logo { get; set; }

        public string CountryOfOrigin { get; set; }

        
    }
}
