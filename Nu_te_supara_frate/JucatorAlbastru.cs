using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nu_te_supara_frate
{
    internal class JucatorAlbastru 
    {
        fereastraJoc ferJoc { get; set; }
        Albastru albastru = new Albastru();
        private int[] locatie_curenta;
        private bool poateMuta;
        public JucatorAlbastru()
        {
            locatie_curenta = new int[5];
            locatie_curenta[1] = -1;
            locatie_curenta[2] = -1;
            locatie_curenta[3] = -1;
            locatie_curenta[4] = -1;
            poateMuta = false;
        }

        public void mutaPionAlbastru1(fereastraJoc ferJoc, int numarzar)
        {

            if (locatie_curenta[1] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[1] = 0;
            else if (locatie_curenta[1] != -1 && poateMuta == true)
                locatie_curenta[1] += numarzar;
            if (locatie_curenta[1] != -1)
            {
                ferJoc.pAlbastru1.Location = albastru.Coordonate[locatie_curenta[1]];
                poateMuta = false;
            }
        }
        public void mutaPionAlbastru2(fereastraJoc ferJoc, int numarzar)
        {
            if (locatie_curenta[2] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[2] = 0;
            else if (locatie_curenta[2] != -1 && poateMuta == true)
                locatie_curenta[2] += numarzar;
            if (locatie_curenta[2] != -1)
            {
                ferJoc.pAlbastru2.Location = albastru.Coordonate[locatie_curenta[2]];
                poateMuta = false;
            }
        }
        public void mutaPionAlbastru3(fereastraJoc ferJoc, int numarzar)
        {
            if (locatie_curenta[3] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[3] = 0;
            else if (locatie_curenta[3] != -1 && poateMuta == true)
                locatie_curenta[3] += numarzar;
            if (locatie_curenta[3] != -1)
            {
                ferJoc.pAlbastru3.Location = albastru.Coordonate[locatie_curenta[3]];
                poateMuta = false;
            }
        }
        public void mutaPionAlbastru4(fereastraJoc ferJoc, int numarzar)
        {
            if (locatie_curenta[4] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[4] = 0;
            else if (locatie_curenta[4] != -1 && poateMuta == true)
                locatie_curenta[4] += numarzar;
            if (locatie_curenta[4] != -1)
            {
                ferJoc.pAlbastru4.Location = albastru.Coordonate[locatie_curenta[4]];
                poateMuta = false;
            }
        }
        public void setPoateMuta(bool poate)
        {
            poateMuta = poate;
        }
    }
}
