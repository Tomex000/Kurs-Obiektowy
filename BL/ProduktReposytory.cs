using System.Collections.Generic;

namespace BL
{
    public class ProduktReposytory
    {
        /// <summary>
        /// Pobiera 1 produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // tworzenie isntancji produktu
            Produkt produkt = new Produkt(produktId);

            if (produktId==5)
            {
                produkt.NazwaProduktu = "klocki";
                produkt.Opis = "dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }

            return produkt;
        }
        /// <summary>
        /// Zapis produktu
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {

            var sukces = true;
            if (produkt.MaZmiany && produkt.DanePrawidlowe)
            {
                if (produkt.JestNowy)
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
        /// Pobieranie wszystkich produktów
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            // pobiera wszystkich klientów
            return new List<Produkt>();
        }
    }
}
