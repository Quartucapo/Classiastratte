using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    abstract class Animale
    {


        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;
        protected int siMuove;


        public Animale(string nome, string tipo, string abitat, int Zampe)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            habitat = abitat;
            numeroZampe = Zampe;
        }

        public abstract string simuove();

        public void riepilogo()
        {
            Console.WriteLine(nomeAnimale);
            Console.WriteLine(tipoAnimale);
            Console.WriteLine(habitat);
            Console.WriteLine(numeroZampe);
        }
        
    }
}
