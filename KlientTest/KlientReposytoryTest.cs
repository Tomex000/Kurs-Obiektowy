using System;
using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlientTest
{
    [TestClass]
    public class KlientReposytoryTest
    {
        [TestMethod]
        public void PobierzKlientTest()
        {
            //Arrange
            var klientRepo = new KlientReposytory();
            var oczekiwana = new Klient(1)
            {
                Email = "jakismail@ggg.pl",
                Imie = "Tomek",
                Nazwisko = "kowalski"
            };
            //Act
            var aktualna = klientRepo.Pobierz(1);
            //Assert
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

        }
    }
}
