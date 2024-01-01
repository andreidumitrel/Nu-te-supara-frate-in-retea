using System.Runtime.CompilerServices;

namespace Nu_te_supara_frate
{
    internal class JucatorRosu : Jucator
    {   
        fereastraJoc ferJoc {  get; set; }
        Rosu rosu = new Rosu();
        Albastru albastru = new Albastru();
        private int[] locatie_curenta;
        private bool poateMuta;
        public JucatorRosu() {
            locatie_curenta = new int[5];
            locatie_curenta[1] = -1;
            locatie_curenta[2] = -1;
            locatie_curenta[3] = -1;
            locatie_curenta[4] = -1;
            poateMuta= false;
        }


        
        public void mutaPionRosu1(fereastraJoc ferJoc, int numarzar)
        {

            /*if (locatie_curenta[1] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[1] = 0;
            else if (locatie_curenta[1] != -1 && poateMuta == true)
                locatie_curenta[1] += numarzar;
            if (locatie_curenta[1] != -1) { 
                ferJoc.pRosu1.Location = rosu.Coordonate[locatie_curenta[1]];
            poateMuta = false;
            }
            castig(ferJoc);*/
            mutaPion("Rosu",1,numarzar, ferJoc);
        }
        public void mutaPionRosu2(fereastraJoc ferJoc, int numarzar)
        {
            /*if (locatie_curenta[2] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[2] = 0;
            else if (locatie_curenta[2] != -1 && poateMuta == true)
                locatie_curenta[2] += numarzar;
            if (locatie_curenta[2] != -1) { 
                ferJoc.pRosu2.Location = rosu.Coordonate[locatie_curenta[2]];
            poateMuta = false;
            }
            castig(ferJoc);*/
            mutaPion("Rosu", 2, numarzar, ferJoc);
        }
        public void mutaPionRosu3(fereastraJoc ferJoc, int numarzar)
        {
            if (locatie_curenta[3] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[3] = 0;
            else if (locatie_curenta[3] != -1 && poateMuta == true)
                locatie_curenta[3] += numarzar;
            if (locatie_curenta[3] != -1) { 
            ferJoc.pRosu3.Location = rosu.Coordonate[locatie_curenta[3]];
            poateMuta = false;
            }
            castig(ferJoc);
        }
        public void mutaPionRosu4(fereastraJoc ferJoc, int numarzar) {
            if (locatie_curenta[4] == -1 && numarzar == 6 && poateMuta)
                locatie_curenta[4] = 0;
            else if (locatie_curenta[4] != -1 && poateMuta == true)
                locatie_curenta[4] += numarzar;
            if (locatie_curenta[4] != -1)
            {
                ferJoc.pRosu4.Location = rosu.Coordonate[locatie_curenta[4]];
                poateMuta = false;
            }
            castig(ferJoc);
        }
        private void castig(fereastraJoc ferJoc)
        {
            if (((locatie_curenta[1] == 40) || (locatie_curenta[2] == 40) || (locatie_curenta[3] == 40) || (locatie_curenta[4] == 40)) &&
                ((locatie_curenta[1] == 41) || (locatie_curenta[2] == 41) || (locatie_curenta[3] == 41) || (locatie_curenta[4] == 41)) &&
                ((locatie_curenta[1] == 42) || (locatie_curenta[2] == 42) || (locatie_curenta[3] == 42) || (locatie_curenta[4] == 42)) &&
                ((locatie_curenta[1] == 43) || (locatie_curenta[2] == 43) || (locatie_curenta[3] == 43) || (locatie_curenta[4] == 43)))
            {
                FereastraCastig ferCastig = new FereastraCastig();
                ferCastig.Show();
                ferJoc.Hide();
            }
        }
        public void setPoateMuta(bool poate)
        {
            poateMuta = poate;
        }
    }
}
