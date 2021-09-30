using System;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    /// <summary>
    /// Dont use danske Ø 
    /// </summary>
    public class Øresund : BaseInformation
    {
        private BaseInformation Vehicle { get; set; }

        public Øresund(BaseInformation vehicle)
        {
            Vehicle = vehicle;
        }
        //public double BridgeC(Car cAr)
        //{

        //    cAr.brobizz = true;
        //    if (cAr.brobizz)
        //    {
        //        return 161;
        //    }

        //    return 410;
        //}

        //public double BridgeM(MC mc)
        //{
        //NOOOOOOOO
        //    mc.brobizz = true;
        //    if (mc.brobizz)
        //    {
        //        return 73;
        //    }
        //    return 210;
        //}
        ///// <summary>
        ///// BridgeText1 - name says nothing
        ///// </summary>
        ///// <param name="CarText"> its not just car but also a MC - Bad name </param>
        ///// <returns></returns>
        //public string BridgeText1(BaseInformation CarText)
        //{



        //    Car car = new Car();
        //    if (car.VehicleType()== CarText.VehicleType())
        //    {
        //        return "Oresund car";
        //    }

        //    return "Oresund MC";




        //}


        public override double Price()
        {
            switch (Vehicle)
            {
                case Car car:
                    if (Vehicle.brobizz)
                        return 161;
                    return 410;
                case MC mc:
                    if (mc.brobizz)
                        return 73;
                    return 210;
            }
            return 0;
        }

        public override string VehicleType()
        {
            switch (Vehicle)
            {
                case Car car:
                   return "Oresund car";
                case MC mc:
                    return "Oresund MC";
            }
            return null;
        }
    }
}
