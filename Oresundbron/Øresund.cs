using System;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    public class Øresund
    {
        

        public double BridgeC(Car cAr)
        {

            cAr.brobizz = true;
            if (cAr.brobizz)
            {
                return 161;
            }

            return 410;
        }
            
        public double BridgeM(MC mc)
        {

            mc.brobizz = true;
            if (mc.brobizz)
            {
                return 73;
            }
            return 210;
        }

        public string BridgeText1(BaseInformation CarText)
        {



            Car car = new Car();
            if (car.VehicleType()== CarText.VehicleType())
            {
                return "Oresund car";
            }

            return "Oresund MC";




        }





    }
}
