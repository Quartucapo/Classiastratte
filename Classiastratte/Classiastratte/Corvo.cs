using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Corvo : Uccello
    {
         public Corvo (): base ( "corvo", "terrestre", "terra", 2)
        {
 
        }
         public override string simuove()
         {
             return "vola e cammina";
         }
    }
}
