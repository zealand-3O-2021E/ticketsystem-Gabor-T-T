using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car : BaseInformation
    {



        public override double Price()
        {
            if (brobizz== true)
            {
                return 240 * 0.95;
            }
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }









    }
}
