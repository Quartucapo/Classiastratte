using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Uomo : Mammifero_Terrestre, Animale_Peloso, Bipede
    {
        public Uomo(): base("uomo", "terrestre", "terra", 2, "mammifero")
        {

        }
        public override string Muove()
        {
            return "cammina e corre";
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
            return 2;
        }
        public override int Zampe()
        {
            return getzampe();
        }
    }
}
