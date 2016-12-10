using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Cavallo : Mammifero_Terrestre, Animale_Peloso, Quadrupede
    {
        public Cavallo(): base("cavallo", "terrestre", "terra", 4, "mammifero")
        {

        }
        public override string Muove()
        {
            return "corre";
        }
        public string getmantopeloso()
        {
            return "semipeloso";
        }
        public override string Manto()
        {
            return getmantopeloso();
        }
        public int getzampe()
        {
            return 4;
        }
        public override int Zampe()
        {
            return getzampe();
        }
    }
}
