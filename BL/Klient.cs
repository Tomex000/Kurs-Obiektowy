using System.Collections.Generic;
using Common;

namespace BL
{
    public class Klient : KlasaBazowa, ILogowanie
    {
        #region konstruktory
        public Klient() :this(0)
        {

        }
        public Klient(int klientId)
        {
            KlientId = klientId;
            ListaAdresow = new List<Adres>();
        }
        #endregion

        #region właściwości
        //Właściwości
        public static int Licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nazwisko = value;
                }

            }
        }

        private string _imie;

        public string Imie
        {
            get
            {
                return _imie;
            }
            set
            {
                _imie = value;
            }
        }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }
        
        public List<Adres> ListaAdresow { get; set; }

        public int KlientTyp { get; set; }

        #endregion

        #region metody
        //Metody
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
            {
                poprawne = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                poprawne = false;
            }
            return poprawne;
        }
        /// <summary>
        /// Pobiera nowego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            return new Klient();
        }
        /// <summary>
        /// Zapis klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
        /// <summary>
        /// Pobieranie wszystkich klientow
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            // pobiera wszystkich klientów
            return new List<Klient>();
        }

        public string Log()
        {
            var log = KlientId + ":" + ImieNazwisko + " " + "Email: " + Email + " " + "Status: " + StanObiektu.ToString();

            return log;
        }
        #endregion
    }
}
