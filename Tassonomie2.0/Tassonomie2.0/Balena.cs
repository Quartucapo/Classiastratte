using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Balena : Mammifero_Marino
    {
        public Balena(): base("balena", "marino", "mare", 0, "mammifero")
        {

        }
        public override string Muove()
        {
            return "corre";
        }
        public string getmantopeloso()
        {
            return "pelle";
        }
        public override string Manto()
        {
            return getmantopeloso();
        }
        public int getzampe()
        {
            return 0;
        }
        public override int Zampe()
        {
            return getzampe();
        }
        
    }
}
