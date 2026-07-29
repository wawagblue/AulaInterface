using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal cachorro = new Cachorro();
            IAnimal gato = new Gato();
            IAnimal passaro = new Passaro();

            cachorro.Falar();
            cachorro.Mover();

            gato.Falar();
            gato.Mover();

            passaro.Falar();
            passaro.Mover();
        }
    }
}
