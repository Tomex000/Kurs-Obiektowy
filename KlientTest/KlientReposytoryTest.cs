using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            var klientRepository = new KlientReposytory();
            var oczekiwana = new Klient(1)
            {
                Email = "jakismail@ggg.pl",
                Imie = "Tomek",
                Nazwisko = "kowalski",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                        AdresTyp = 1,
                        Ulica = "jakas",
                        Kraj = "Polska",
                        Miasto = "Kazimierz",
                        KodPocztowy = "12-345"
                    },
                    new Adres()
                    {
                        AdresTyp = 3,
                        Ulica = "costam",
                        Kraj = "Polska",
                        Miasto = "Kolobrzeg",
                        KodPocztowy = "12-789"
                    }

                }
            };
            var aktualna = klientRepository.Pobierz(1);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
            }
        }
    }
}
