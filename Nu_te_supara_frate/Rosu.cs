using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nu_te_supara_frate
{
    internal class Rosu
    {   
        public List<Point> Coordonate { get; private set; }
        public Rosu() {
            Coordonate = new List<Point>();

            Coordonate.Add(new Point(0, 0));
            Coordonate.Add(new Point(1, 0));
            Coordonate.Add(new Point(2, 0));
        }
        
    }
}
