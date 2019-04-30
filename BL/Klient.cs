﻿using System.Collections.Generic;

namespace BL
{
    public class Klient
    {
        public Klient()
        {

        }
        public Klient(int klientId)
        {
            KlientId = klientId;
        }
        
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

        public string HomeAddres { get; set; }
        public string WorkAddres { get; set; }

        //Metody
        public bool Zwaliduj()
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
    }
}
