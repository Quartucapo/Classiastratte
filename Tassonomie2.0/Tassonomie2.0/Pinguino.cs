using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Pinguino : Uccello_Marino, Animale_Piumoso
    {
        public Pinguino()
            : base("pinguino", "terrestre", "terra", 2, "mammifero")
        {

        }
        public override string Muove()
        {
            return "cammina e nuota";
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
