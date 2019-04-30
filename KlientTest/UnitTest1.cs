using System;
using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlientTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange          
            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Robert, Kowal";
            //Act
            string aktualna = klient.ImieNazwisko;

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }
        [TestMethod]
        public void ImiePusteTest()
        {
            //Arrange          
            Klient klient = new Klient();
            //klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Kowal";
            //Act
            string aktualna = klient.ImieNazwisko;

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange          
            var kln1 = new Klient();
            kln1.Imie = "Robert";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln1.Imie = "Maciek";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln1.Imie = "Bartek";
            Klient.Licznik += 1;

            //Act


            //Assert
            Assert.AreEqual(3, Klient.Licznik);

        }
        [TestMethod]
        public void ZwalidujTest()
        {
            //Arrange
            var klient =new Klient();
            klient.Nazwisko = "Kwoal";
            klient.Email = "asd@gazeta.pl";
            var oczekiwana = true;

            //Act
            var aktualna = klient.Zwaliduj();

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            //Arrange
            var klient = new Klient();
            //klient.Nazwisko = "Kwoal";
            klient.Email = "asd@gazeta.pl";
            var oczekiwana = false;

            //Act
            var aktualna = klient.Zwaliduj();

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void ZwalidujBrakEmailTest()
        {
            //Arrange
            var klient = new Klient();
            klient.Nazwisko = "Kwoal";
            //klient.Email = "asd@gazeta.pl";
            var oczekiwana = false;

            //Act
            var aktualna = klient.Zwaliduj();

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
