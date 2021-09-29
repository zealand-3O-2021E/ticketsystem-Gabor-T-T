using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class WeekendTests
    {
        [TestMethod()]
        public void WeekendDiscount()
        {
            //arrenge
            var p1 = new Weekend();

            Car c1 = new Car();

            //act
            c1.DateTIme = new DateTime(2021,10,02);
            double actualPrice = p1.Discount(c1);
            double expected =  192;
            //assert
            Assert.AreEqual(expected, actualPrice, 0.5d);

        }
    }
}