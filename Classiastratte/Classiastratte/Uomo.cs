using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Uomo : Bipede
    {
         public Uomo (): base ( "uomo", "terrestre", "terra", 2)
        {
 
        }
         public override string simuove()
         {
             return "si";
         }
    }
}
