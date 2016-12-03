using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Salmone : Animale_Fluviale
    {
        
         public Salmone (): base ( "salmone", "fluviale", "fiume", 0)
        {
 
        }
         public override string simuove()
         {
             return "no";
         }
    }
}
