using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            var zamowienieReposytory = new ZamowienieReposytory();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "jacek",
                Nazwisko = "Kowalski",
                DataZamowienia = new DateTimeOffset(2018, 4, 21, 12, 00, 00, new TimeSpan(5, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "jeden",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "12-555"
                },
                WyswitlaniePozycjiZamowienia = new List<wyswietlaniePozycjiZamowienia>()
                {
                    new wyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc =10
                    },
                    new wyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu="Blat",
                        CenaZakupu=50.33M,
                        Ilosc=5
                    }
                }
            };

            var aktualna = zamowienieReposytory.PobierzZamowienieDoWyswietlenia(10);

            Assert.AreEqual(oczekiwana.ZamowieniaId, aktualna.ZamowieniaId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswitlaniePozycjiZamowienia[i].NazwaProduktu, aktualna.WyswitlaniePozycjiZamowienia[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswitlaniePozycjiZamowienia[i].Ilosc, aktualna.WyswitlaniePozycjiZamowienia[i].Ilosc);
                Assert.AreEqual(oczekiwana.WyswitlaniePozycjiZamowienia[i].CenaZakupu, aktualna.WyswitlaniePozycjiZamowienia[i].CenaZakupu);
            }
        }
    }
}
