using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{//In ICompany: 

    /* Create 2 members that are specific to each every company
     * regardless of vehicle type.
     * Example: public string Logo { get; set; }
     */

    public interface ICompany
    {
        public string Logo { get; set; }

        public string CountryOfOrigin { get; set; }
    }
}
