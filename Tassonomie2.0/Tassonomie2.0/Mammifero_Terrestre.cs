using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Mammifero_Terrestre : Animale_Terrestre
    {
        public Mammifero_Terrestre(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "terrestre", "terra", zampe, "mammifero")
        {

        }
        public override string Muove()
        {
            return "cammina";
        }
    }
}
