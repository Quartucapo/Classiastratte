using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Uccello_Marino : Animale_Marino
    {
        public Uccello_Marino(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "marino", "mare", 2, "uccello marino")
        {

        }
        public override string Muove()
        {
            return "nuota";
        }
    }
}
