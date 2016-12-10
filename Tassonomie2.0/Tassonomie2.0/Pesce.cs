using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Pesce : Animale_Marino,Animale_Squamoso
    {
        public Pesce(string nome, string tipo, string abitat, int zampe, string sp) : base(nome, "marino", "mare", 0, "pesce")
        {

        }
        public override string Muove()
        {
            return "nuota";
        }
        public string getmantosquamoso()
        {
            return "squamoso";
        }
        public override string Manto()
        {
            return getmantosquamoso();
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
