using System;
using System.Collections.Generic;
using Common;

namespace BL
{
    public class Produkt : KlasaBazowa, ILogowanie
    {
        //Konstruktor
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        //Properties

        public int ProduktId { get; private set; }
        public decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }

        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get
            {
                return _NazwaProduktu.WstawSpacje();
            }
            set { _NazwaProduktu = value; }
        }


        //Metody
        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
            {
                poprawne = false;
            }
            if (AktualnaCena == null)
            {
                poprawne = false;
            }

            return poprawne;
        }
        /// <summary>
        /// Pobiera 1 produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            return new Produkt();
        }
        /// <summary>
        /// Zapis produktu
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
        /// <summary>
        /// Pobieranie wszystkich produktów
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            // pobiera wszystkich klientów
            return new List<Produkt>();
        }

        public string Log()
        {
            var log = ProduktId + ":" + NazwaProduktu + " " + "Opis: " + Opis + " " + "Status: " + StanObiektu.ToString();

            return log;
        }
    }
}
