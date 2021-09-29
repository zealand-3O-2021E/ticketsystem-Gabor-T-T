using ClassLibraryTicketSystem;
using System;

namespace StoreBaeltTicketLibrary
{
    public class Weekend
    {



        public double Discount(Car cAR)
        {
            if (cAR.DateTIme.DayOfWeek == DayOfWeek.Saturday || cAR.DateTIme.DayOfWeek == DayOfWeek.Sunday)
            {
                return cAR.Price() * 0.80;
            }


            return cAR.Price();
   



           



        }








    }
}
