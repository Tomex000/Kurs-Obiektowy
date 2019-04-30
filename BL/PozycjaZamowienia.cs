namespace BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }
        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }
        //*
        //Properites
        //*
        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        //Metody
        /// <summary>
        /// Sprawdza dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
            {
                poprawne = false;
            }
            if (ProduktId <= 0)
            {
                poprawne = false;
            }
            if (CenaZakupu == 0)
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
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            return new PozycjaZamowienia();
        }

    }
}
