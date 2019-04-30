using System;
using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlientTest
{
    [TestClass]
    public class ZamowienieReposytoryTest
    {
        [TestMethod]
        public void PobierzZamowienieReposytoryTest()
        {
            //Arrange
            var zamowienieRepo = new ZamowienieReposytory();
            var oczekiwane = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2019, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))

            };
            //Act
            var aktualne = zamowienieRepo.Pobierz(10);
            //Assert
            Assert.AreEqual(oczekiwane.ZamowienieID, aktualne.ZamowienieID);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);
            
        }
    }
}
