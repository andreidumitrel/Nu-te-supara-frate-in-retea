using Nu_te_supara_frate.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Nu_te_supara_frate
{
    internal class Zar
    {   private
            int numar_zar;
        public Zar() {
            numar_zar = 1;
        }
        private int getZar() { 
            Random rnd = new Random();  
            int numarRandom = rnd.Next(1,7);
            return numarRandom;
        }
        public void daCuZarul(fereastraJoc ferJoc)
        {
            
            int numar_zar = this.getZar();



            switch (numar_zar)
            {   

                case 1:
                    ferJoc.zar1.Image = Resources.zar1;
                    break;
                case 2:
                    ferJoc.zar1.Image = Resources.zar2;
                    break;
                case 3:
                    ferJoc.zar1.Image = Resources.zar3;
                    break;
                case 4:
                    ferJoc.zar1.Image = Resources.zar4;
                    break;
                case 5:
                    ferJoc.zar1.Image = Resources.zar5;
                    break;
                case 6:
                    ferJoc.zar1.Image = Resources.zar6;
                    break;
            }

        }
    }
}
