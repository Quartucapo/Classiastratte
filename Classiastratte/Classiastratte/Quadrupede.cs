using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Quadrupede : Animale_Terrestre
    {
         public Quadrupede (string nome, string tipo, string abitat, int zampe): base ( nome, "terrestre", "terra", 4)
        {
 
        }
    }
}
