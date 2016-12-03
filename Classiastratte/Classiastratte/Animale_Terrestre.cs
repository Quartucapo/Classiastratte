using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
     class Animale_Terrestre : Animale
    {
         public Animale_Terrestre (string nome, string tipo, string abitat, int zampe): base ( nome, "terrestre", "terra", zampe)
        {
 
        }
         public override string simuove()
         {
             return "cammina, corre";
         }
    }
}
