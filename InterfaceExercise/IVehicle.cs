using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */

    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }

        public int HorsePower{ get; set; }

        public string Make {  get; set; }

        public string Model { get; set; }

    }
}
