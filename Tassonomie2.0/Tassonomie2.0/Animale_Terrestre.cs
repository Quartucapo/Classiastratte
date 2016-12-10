using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Animale_Terrestre : Animale
    {
        public Animale_Terrestre(string nome, string tipo, string abitat, int zampe, string sp): base(nome, "terrestre", "terra", zampe, sp)
        {

        }
        public override string Muove()
        {
            return "cammina, corre";
        }
    }
}
