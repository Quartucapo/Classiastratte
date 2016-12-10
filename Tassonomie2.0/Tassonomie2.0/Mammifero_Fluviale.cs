using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Mammifero_Fluviale : Animale_Terrestre
    {
        public Mammifero_Fluviale(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "terrestre", "fiume", zampe, "mammifero")
        {

        }
        public override string Muove()
        {
            return "nuota e cammina";
        }
    }
}
