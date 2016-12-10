﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    class Tonno : Pesce
    {
        public Tonno(): base("tonno", "marino", "mare", 0, "animale marino")
        {

        }
        public override string Muove()
        {
            return "nuota";
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
