using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Uccello : Animale_Terrestre
    {
        public Uccello(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "terrestre", "terra", 2, "uccello")
        {

        }
        public override string Muove()
        {
            return "vola e cammina";
        }
    }
}
