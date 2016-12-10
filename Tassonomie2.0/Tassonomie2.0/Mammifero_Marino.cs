using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Mammifero_Marino : Animale_Marino
    {
        public Mammifero_Marino(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "marino", "mare", 0, "mammifero marino")
        {

        }
        public override string Muove()
        {
            return "nuota";
        }
    }
}
