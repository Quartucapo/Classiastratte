using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Animale_Marino : Animale
    {
        public Animale_Marino(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "marino", "mare", zampe, sp)
        {

        }
        public override string Muove()
        {
            return "nuota";
        }
    }
}
