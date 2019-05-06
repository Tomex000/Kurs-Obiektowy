using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AdresReposytory
    {
        /// <summary>
        /// Tworzy instancje klasy Adres i przekazuje zadany identyfikator
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            Adres adres = new Adres(adresId);
            
            //pobieranie zdefiniowanego adresu

            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Krakowska";
                adres.Miasto = "Krakow";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "23-323";
            }
            return adres;
        }
        /// <summary>
        /// Pobiera wszystkie zdefiniowane adresy dla id klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            //tymczasowe zestaw adresow
            var listaAdresow = new List<Adres>();
            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "jakas",
                Kraj = "Polska",
                Miasto = "Kazimierz",
                KodPocztowy = "12-345"
            };
            listaAdresow.Add(adres);
            adres = new Adres(2)
            {
                AdresTyp = 3,
                Ulica = "costam",
                Kraj = "Polska",
                Miasto = "Kolobrzeg",
                KodPocztowy = "12-789"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }
        public bool Zapisz(Adres adres)
        {
            return true;
        }
    }
}
