using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Zamowienie
    {
        #region kosntruktory
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieId)
        {
            ZamowienieID = zamowienieId;
        }
        //Properties
        public int ZamowienieID { get;private set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        #endregion

        #region wlasciwosci
        public List<PozycjaZamowienia> pozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }

        #endregion

        #region metody
        //Metody
        /// <summary>
        /// Sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
            {
                poprawne = false;
            }

            return poprawne;
        }
       
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
            return new Zamowienie();
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
        #endregion
    }
}
