using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nu_te_supara_frate
{
    internal class Joc : Jucator
    {
        private string rand;
        fereastraJoc fereastra;
        public Joc(fereastraJoc ferJoc) : base(ferJoc)
        { 
            
            Jucator jucator = new Jucator(ferJoc);
            Zar zar = new Zar();
            this.fereastra = ferJoc;
            rand = "Rosu";
        }

        public void setRand(string randNou)
        {
            rand = randNou;
            fereastra.setLabelRand(rand);
        }

        public string getRand()
        {
            return rand;
        }



        public void Muta(string culoare, int numarPion, int numarZar, fereastraJoc ferJoc)
        {
            switch (culoare)
            {
                case "Albastru":
                    if (rand == "Albastru")
                    {
                        switch (numarPion)
                        {
                            case 1:
                                mutaPion("Albastru",1,numarZar, ferJoc);
                                if(numarZar != 6)
                                    setRand("Rosu");
                                break;
                            case 2:
                                mutaPion("Albastru", 2, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Rosu");
                                break;
                            case 3:
                                mutaPion("Albastru", 3, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Rosu");
                                break;
                            case 4:
                                mutaPion("Albastru", 4, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Rosu");
                                break;
                        }
                    }
                    break;
                case "Rosu":
                    if (rand == "Rosu")
                    {
                        switch (numarPion)
                        {
                            case 1:
                                mutaPion("Rosu", 1, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Albastru");
                                break;
                            case 2:
                                mutaPion("Rosu", 2, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Albastru");
                                break;
                            case 3:
                                mutaPion("Rosu", 3, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Albastru");
                                break;
                            case 4:
                                mutaPion("Rosu", 4, numarZar, ferJoc);
                                if (numarZar != 6)
                                    setRand("Albastru");
                                break;
                        }
                    }
                    break;
            }
            verificareCastigator();

        }
    }
}
