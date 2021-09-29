using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
   public abstract class BaseInformation
    {
        private string LisencePlateChar;

        public string LisencePlate
        {
            get { return LisencePlateChar; }
            
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("Lisence Plate characters must be less than 7 Character!");
                }
                else
                { LisencePlateChar = value; }
            }
        }
        
        public DateTime DateTIme { get; set; }

        public bool  brobizz { get; set; }

       



        public abstract double Price();



        public abstract string VehicleType();







    }



}

