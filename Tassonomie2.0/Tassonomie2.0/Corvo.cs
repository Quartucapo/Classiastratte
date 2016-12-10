using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Corvo : Uccello
    {
        public Corvo(): base("corvo", "terrestre", "terra", 2, "mammifero")
        {

        }
        public override string Muove()
        {
            return "cammina e vola";
        }
        public string getmantopiumato()
        {
            return "piumato";
        }
        public override string Manto()
        {
            return getmantopiumato();
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
