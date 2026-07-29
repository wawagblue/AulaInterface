using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{

    public class Passaro : IAnimal
    {
        public void Falar()
        {
            Console.WriteLine("O pássaro faz: Piu Piu!");
        }

        public void Mover()
        {
            Console.WriteLine("O pássaro está voando.");
        }
    }
}
