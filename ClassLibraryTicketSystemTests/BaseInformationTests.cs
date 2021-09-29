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
    public class BaseInformationTests
    {
        [TestMethod()]
        public void LisencePlateCharacterTest()
        {

            //arrange
            var plate1 = new Car();
            //act

            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => plate1.LisencePlate = "12345678");

        }

       
    }
}