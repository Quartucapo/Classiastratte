using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Animale_Fluviale : Animale
    {
         public Animale_Fluviale (string nome, string tipo, string abitat, int zampe): base ( nome, "fluviale", "fiume", 0)
        {
 
        }
         public override string simuove()
         {
             return "nuota";
         }
    }
}
