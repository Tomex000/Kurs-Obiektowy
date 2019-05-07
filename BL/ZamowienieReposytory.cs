using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ZamowienieReposytory
    {
        /// <summary>
        /// Zapis zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Zamowienie zamowienie)
        {
            var sukces = true;
            if (zamowienie.MaZmiany && zamowienie.DanePrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    //insert do bazy
                }
                else
                {
                    //update do bazy
                }
            }
            return sukces;
        }
        /// <summary>
        /// Pobiera 1 zamowienia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            if (zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2019, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return zamowienie;
        }
        /// <summary>
        /// Pobieranie wszystkich zamowień
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            // pobiera wszystkich klientów
            return new List<Zamowienie>();
        }
        /// <summary>
        /// Pobieranie 1 zamowienia do wyswietlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();
            //pobieranie zdefiniowanego zamowienia

            //tymczasowe
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "jacek";
                wyswietlanieZamowienia.Nazwisko = "Kowalski";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 4, 21, 12, 00, 00, new TimeSpan(5, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "jeden",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "12-555"
                };
                wyswietlanieZamowienia.WyswitlaniePozycjiZamowienia = new List<wyswietlaniePozycjiZamowienia>();

                //kod pobierania elementow zamowienia

                //tymczasowe
                if (zamowienieId == 10)
                {
                    var wyswietlaniePozycjiZamowienia = new wyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc = 10

                    };
                    wyswietlanieZamowienia.WyswitlaniePozycjiZamowienia.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new wyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5

                    };
                    wyswietlanieZamowienia.WyswitlaniePozycjiZamowienia.Add(wyswietlaniePozycjiZamowienia);
                }


            }
            return wyswietlanieZamowienia;
        }
    }
}
