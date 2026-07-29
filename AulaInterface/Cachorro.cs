using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{
    public class Cachorro : IAnimal
    {
        public void Falar()
        {
            Console.WriteLine("O cachorro faz: Au Au!");
        }

        public void Mover()
        {
            Console.WriteLine("O cachorro está correndo.");
        }
    }
}
