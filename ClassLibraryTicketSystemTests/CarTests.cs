using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            var p1 = new Car();
            //act
            double actualvalue = p1.Price();
            //assert
            Assert.AreEqual(240, actualvalue);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //arrange
            var v1 = new Car();
            //act
            string carbrand = v1.VehicleType();
            //assert
            Assert.AreSame("Car", carbrand);
           
        }


        [TestMethod()]
        public void Brobizz()
        {
            //arrange
            var b1 = new Car();

            b1.brobizz = true;
            //act
            double actualb1 = b1.Price();
            double expected = 228;

            //assert
            Assert.AreEqual(expected, actualb1, 0.5d);

        }
    }
}