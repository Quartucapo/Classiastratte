using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Cavallo : Quadrupede
    {
         public Cavallo (): base ( "Cavallo", "terrestre", "terra", 4)
        {
 
        }
         public override string simuove()
         {
             return "si";
         }
    }
}
