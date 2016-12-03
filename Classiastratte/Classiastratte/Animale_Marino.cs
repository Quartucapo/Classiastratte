using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Animale_Marino : Animale
    {
         public Animale_Marino (string nome, string tipo, string abitat, int zampe): base ( nome, "marino", "mare", 0)
        {
 
        }
         public override string simuove()
         {
             return "nuota";
         }

    }
    
}
