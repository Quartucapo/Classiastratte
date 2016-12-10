using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie2._0
{
    abstract class Animale
    {
        protected string manto;
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;
        protected string siMuove;
        protected string specie;
        public abstract int Zampe();
        public abstract string Muove();
        public abstract string Manto();



        public Animale(string nome, string tipo, string abitat, int Zampe, string sp)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            habitat = abitat;
            numeroZampe = Zampe;
            specie = sp;
        }

        

        public void riepilogo()
        {
            Console.WriteLine(nomeAnimale);
            Console.WriteLine(tipoAnimale);
            Console.WriteLine(habitat);
            Console.WriteLine(numeroZampe);
            Console.WriteLine(specie);
        }
        
    }
}
