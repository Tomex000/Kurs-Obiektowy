using System;
using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KlientTest
{
    [TestClass]
    public class ProduktRepoTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            //Arrange
            var produktRepo = new ProduktReposytory();
            var oczekiwane = new Produkt(5)
            {
                NazwaProduktu = "klocki", Opis = "dla dzieci", AktualnaCena = 89.99M

            };
            //Act
            var aktualne = produktRepo.Pobierz(5);
            //Assert
            Assert.AreEqual(oczekiwane.NazwaProduktu, aktualne.NazwaProduktu);
            Assert.AreEqual(oczekiwane.Opis, aktualne.Opis);
            Assert.AreEqual(oczekiwane.AktualnaCena, aktualne.AktualnaCena);
        }
    }
}
