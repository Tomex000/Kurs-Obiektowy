﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KlientReposytory
    {
        /// <summary>
        /// Zapis klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
        /// <summary>
        /// Pobiera nowego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            Klient klient = new Klient(klientId);

            if (klientId==1)
            {
                klient.Email = "jakismail@ggg.pl";
                klient.Imie = "Tomek";
                klient.Nazwisko = "kowalski";                               
            }
            return klient;
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