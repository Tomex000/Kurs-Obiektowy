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
        public bool Zapisz()
        {
            return true;
        }
        /// <summary>
        /// Pobiera 1 zamowienia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            if (zamowienieId==10)
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
    }
}
