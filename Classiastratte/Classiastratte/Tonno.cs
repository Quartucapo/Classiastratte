using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Tonno : Pesce
    {
        
         public Tonno (): base ( "Tonno", "marino", "mare", 0)
        {
 
        }
         public override string simuove()
         {
             return "nuota";
         }
    }
}
