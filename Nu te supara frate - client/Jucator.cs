using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nu_te_supara_frate
{
    internal class Jucator
    {
        private fereastraJoc fereastra;
        public Jucator(fereastraJoc ferJoc)
        {
            fereastra = ferJoc;
            locatie_curentaAlbastru = new int[5];
            locatie_curentaAlbastru[1] = -1;
            locatie_curentaAlbastru[2] = -1;
            locatie_curentaAlbastru[3] = -1;
            locatie_curentaAlbastru[4] = -1;

            locatie_curentaRosu = new int[5];
            locatie_curentaRosu[1] = -1;
            locatie_curentaRosu[2] = -1;
            locatie_curentaRosu[3] = -1;
            locatie_curentaRosu[4] = -1;
        }

        Rosu rosu = new Rosu();
        Albastru albastru = new Albastru();
        private int[] locatie_curentaAlbastru;
        private int[] locatie_curentaRosu;

        bool albastruIesit = false;
        bool rosuIesit = false;

        public bool getAlbastruIesit()
        {
            return albastruIesit;
        }

        public bool getRosuIesit()
        {
            return rosuIesit;
        }

        protected void verificareCastigator()
        {
            if (((locatie_curentaAlbastru[1] == 40) || (locatie_curentaAlbastru[2] == 40) ||
                 (locatie_curentaAlbastru[3] == 40) || (locatie_curentaAlbastru[4] == 40)) &&
                ((locatie_curentaAlbastru[1] == 41) || (locatie_curentaAlbastru[2] == 41) ||
                 (locatie_curentaAlbastru[3] == 41) || (locatie_curentaAlbastru[4] == 41)) &&
                ((locatie_curentaAlbastru[1] == 42) || (locatie_curentaAlbastru[2] == 42) ||
                 (locatie_curentaAlbastru[3] == 42) || (locatie_curentaAlbastru[4] == 42)) &&
                ((locatie_curentaAlbastru[1] == 43) || (locatie_curentaAlbastru[2] == 43) ||
                 (locatie_curentaAlbastru[3] == 43) || (locatie_curentaAlbastru[4] == 43)))
            {
                fereastra.castig(fereastra.getNumeJucator());
            }
            else if (((locatie_curentaAlbastru[1] == 40) || (locatie_curentaAlbastru[2] == 40) ||
                      (locatie_curentaAlbastru[3] == 40) || (locatie_curentaAlbastru[4] == 40)) &&
                     ((locatie_curentaAlbastru[1] == 41) || (locatie_curentaAlbastru[2] == 41) ||
                      (locatie_curentaAlbastru[3] == 41) || (locatie_curentaAlbastru[4] == 41)) &&
                     ((locatie_curentaAlbastru[1] == 42) || (locatie_curentaAlbastru[2] == 42) ||
                      (locatie_curentaAlbastru[3] == 42) || (locatie_curentaAlbastru[4] == 42)) &&
                     ((locatie_curentaAlbastru[1] == 43) || (locatie_curentaAlbastru[2] == 43) ||
                      (locatie_curentaAlbastru[3] == 43) || (locatie_curentaAlbastru[4] == 43)))
            {
                fereastra.castig("Inamicul");
            }

        }

        protected void mutaPion(string culoare, int numarPion,int numarzar,fereastraJoc ferJoc)
        {
            switch (culoare)
            {
                case "Albastru":
                    switch (numarPion)
                    {
                        case 1:
                            if (locatie_curentaAlbastru[1] == -1 && numarzar == 6 )
                            {   locatie_curentaAlbastru[1] = 0;
                                albastruIesit = true;

                            }
                            else if (locatie_curentaAlbastru[1] != -1 )
                                locatie_curentaAlbastru[1] += numarzar;
                            if (locatie_curentaAlbastru[1] != -1)
                            {
                                ferJoc.pAlbastru1.Location = albastru.Coordonate[locatie_curentaAlbastru[1]];
                            }
                            //castig(ferJoc);
                            break;
                        case 2:
                            if (locatie_curentaAlbastru[2] == -1 && numarzar == 6)
                            {
                                locatie_curentaAlbastru[2] = 0;
                                albastruIesit = true;

                            }
                            else if (locatie_curentaAlbastru[2] != -1)
                                locatie_curentaAlbastru[2] += numarzar;
                            if (locatie_curentaAlbastru[2] != -1)
                            {
                                ferJoc.pAlbastru2.Location = albastru.Coordonate[locatie_curentaAlbastru[2]];
                            }
                            //castig(ferJoc);
                            break;
                        case 3:
                            if (locatie_curentaAlbastru[3] == -1 && numarzar == 6)
                            {
                                locatie_curentaAlbastru[3] = 0;
                                albastruIesit = true;

                            }
                            else if (locatie_curentaAlbastru[3] != -1)
                                locatie_curentaAlbastru[3] += numarzar;
                            if (locatie_curentaAlbastru[3] != -1)
                            {
                                ferJoc.pAlbastru3.Location = albastru.Coordonate[locatie_curentaAlbastru[3]];
                            }
                            //castig(ferJoc);
                            break;
                        case 4:
                            if (locatie_curentaAlbastru[4] == -1 && numarzar == 6)
                            {
                                locatie_curentaAlbastru[4] = 0;
                                albastruIesit = true;

                            }
                            else if (locatie_curentaAlbastru[4] != -1)
                                locatie_curentaAlbastru[4] += numarzar;
                            if (locatie_curentaAlbastru[4] != -1)
                            {
                                ferJoc.pAlbastru4.Location = albastru.Coordonate[locatie_curentaAlbastru[4]];
                            }
                            //castig(ferJoc);
                            break;
                        default:
                            break;
                    }
                    break;
                case "Rosu":
                    switch (numarPion)
                    {
                        case 1:
                            if (locatie_curentaRosu[1] == -1 && numarzar == 6)
                            {
                                locatie_curentaRosu[1] = 0;
                                rosuIesit = true;

                            }
                            else if (locatie_curentaRosu[1] != -1)
                                locatie_curentaRosu[1] += numarzar;
                            if (locatie_curentaRosu[1] != -1)
                            {
                                ferJoc.pRosu1.Location = rosu.Coordonate[locatie_curentaRosu[1]];
                            }
                            //castig(ferJoc);
                            break;
                        case 2:
                            if (locatie_curentaRosu[2] == -1 && numarzar == 6)
                            {
                                locatie_curentaRosu[2] = 0;
                                rosuIesit = true;

                            }
                            else if (locatie_curentaRosu[2] != -1)
                                locatie_curentaRosu[2] += numarzar;
                            if (locatie_curentaRosu[2] != -1)
                            {
                                ferJoc.pRosu2.Location = rosu.Coordonate[locatie_curentaRosu[2]];
                            }
                            //castig(ferJoc);
                            break;
                        case 3:
                            if (locatie_curentaRosu[3] == -1 && numarzar == 6)
                            {
                                locatie_curentaRosu[3] = 0;
                                rosuIesit = true;

                            }
                            else if (locatie_curentaRosu[3] != -1)
                                locatie_curentaRosu[3] += numarzar;
                            if (locatie_curentaRosu[3] != -1)
                            {
                                ferJoc.pRosu3.Location = rosu.Coordonate[locatie_curentaRosu[3]];
                            }
                            //castig(ferJoc);
                            break;
                        case 4:
                            if (locatie_curentaRosu[4] == -1 && numarzar == 6)
                            {
                                locatie_curentaRosu[4] = 0;
                                rosuIesit = true;

                            }
                            else if (locatie_curentaRosu[4] != -1)
                                locatie_curentaRosu[4] += numarzar;
                            if (locatie_curentaRosu[4] != -1)
                            {
                                ferJoc.pRosu4.Location = rosu.Coordonate[locatie_curentaRosu[4]];
                            }
                            //castig(ferJoc);
                            break;
                    } break;
            }

        }

    }
}
