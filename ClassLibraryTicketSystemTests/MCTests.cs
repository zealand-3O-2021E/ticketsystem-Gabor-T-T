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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            var pr1 = new MC();
            //act
            double actualPr = pr1.Price();
            //assert
            Assert.AreEqual(125, actualPr);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //arrange
            var m1 = new MC();

            //act
            string text = m1.VehicleType();
            //assert
            Assert.AreSame("MC", text);
        }


        [TestMethod()]
        public void Discount()
        {
            //arrange
            var pr3 = new MC();

            pr3.brobizz = true;
            //act
            double actualPr3 = pr3.Price();
            double expected = 118.75;
            //assert
            Assert.AreEqual(expected, actualPr3, 0.5d);
        }
    }
}