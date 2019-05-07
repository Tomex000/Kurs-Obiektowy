using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            //Arrange
            var zrodlo = "StółOgrodowy";
            var oczekiwana = "Stół Ogrodowy";

           

            //Act

            var aktualna = zrodlo.WstawSpacje();


            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZSpacja()
        {
            //Arrange
            var zrodlo = "Stół Ogrodowy";
            var oczekiwana = "Stół Ogrodowy";

            

            //Act

            var aktualna = zrodlo.WstawSpacje();


            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
