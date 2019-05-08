using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using BL;

namespace CommonTest
{
    [TestClass]
    public class ObslugaLogowaniaTest
    {
        [TestMethod]
        public void PiszDoPliku()
        {
            var zmienioneElementy = new List<ILogowanie>();
            var klient = new Klient(1)
            {
                Email="damad.@gazeta.pl",
                Imie = "Tomek",
                Nazwisko= "Nowak",
                ListaAdresow=null
            };

            zmienioneElementy.Add(klient as ILogowanie);

            var produkt = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki do zabawy",
                AktualnaCena = 100M
            };
            zmienioneElementy.Add(produkt as ILogowanie);

            var zamowienie = new Zamowienie(11)
            {
                DataZamowienia= new DateTime(2019,9,12,11,0,0)
                            };
            zmienioneElementy.Add(zamowienie);
            UslugaLogowania.PiszDoPliku(zmienioneElementy);
        }
    }
}
