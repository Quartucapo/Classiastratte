using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Pinguino : Animale_Terrestre
    {
         public Pinguino (): base ( "pinguino", "terrestre", "terre fredde(polo)", 2)
        {
 
        }
         public override string simuove()
         {
             return "cammina, nuota";
         }
    }
}
