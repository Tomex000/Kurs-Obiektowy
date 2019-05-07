using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KlientReposytory
    {
        private AdresReposytory adresReposytory { get; set; }
        public KlientReposytory()
        {
            adresReposytory = new AdresReposytory();
        }

        /// <summary>
        /// Zapis klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Klient klient)
        {
            var sukces = true;
            if (klient.MaZmiany && klient.DanePrawidlowe)
            {
                if (klient.JestNowy)
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
        /// Pobiera nowego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresReposytory.PobierzPoKlientId(klientId).ToList();
           //pobieranie okreslonego klienta z bazy
            
            //tymczasowe
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
