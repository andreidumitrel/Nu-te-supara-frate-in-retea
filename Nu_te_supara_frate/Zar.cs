using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nu_te_supara_frate
{
    internal class Zar
    {   private
            const int numar_limita=6;
            int numar_zar;
        public Zar() {
            numar_zar = 1;
        }
        public int getZar() { 
            Random rnd = new Random();  
            int numarRandom = rnd.Next(1,numar_limita+1);
            return numarRandom;
        }
    }
}
