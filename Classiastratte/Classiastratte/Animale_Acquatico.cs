using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Animale_Acquatico : Animale
    {
        public Animale_Acquatico (string nome, string tipo, string abitat, int zampe): base ( nome, "acquatico", "fiume", 0)
        {
 
        }
        public override string simuove()
        {
            return "nuota";
        }
        
    
    }
}
