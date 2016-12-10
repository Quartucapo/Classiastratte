using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Ippopotamo : Mammifero_Fluviale, Quadrupede
    {
        public Ippopotamo(): base("ippopotamo", "terrestre", "fiume", 4, "mammifero")
        {

        }
        public override string Muove()
        {
            return "cammina";
        }
        public string getmantopeloso()
        {
            return "pelle";
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
