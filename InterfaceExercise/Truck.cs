using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool IsAPickup { get; set; }

        public int TireSize {  get; set; }
        public int NumberOfWheels { get; set; }
        public int HorsePower { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string Logo { get; set; }

        public string CountryOfOrigin { get; set; }

    }
}
