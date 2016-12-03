using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Program
    {
        static void Main(string[] args)
        {
            Cavallo c = new Cavallo();
            Uomo u = new Uomo();
            Corvo cr = new Corvo();
            Tonno t = new Tonno();
            Salmone s = new Salmone();
            Pinguino p = new Pinguino();
            c.riepilogo();
            Console.WriteLine("--------------------------------------");
            u.riepilogo();
            Console.WriteLine("--------------------------------------");
            cr.riepilogo();
            Console.WriteLine("--------------------------------------");
            t.riepilogo();
            Console.WriteLine("--------------------------------------");
            s.riepilogo();
            Console.WriteLine("--------------------------------------");
            p.riepilogo();
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();
        }
    }
}
