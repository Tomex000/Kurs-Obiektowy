using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class KlasaBazowa
    {
        public bool JestNowy { get; set; }
        public bool MaZmiany { get; set; }
        public StanObiektuOpcje StanObiektu { get; set; }

        public bool DanePrawidlowe
        {
            get
            {
                return Zwaliduj();
            }
            
        }
        public abstract bool Zwaliduj();
        

        
    }

    public enum StanObiektuOpcje
    {
        Aktwny,
        Usuniety
    }
}
