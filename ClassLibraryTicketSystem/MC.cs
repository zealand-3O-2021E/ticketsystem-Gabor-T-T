using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
   public class MC : BaseInformation
    {

      


        public override double Price()
        {
            if (brobizz)
            {
                return 125*0.95;
            }

            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }

    }
}
