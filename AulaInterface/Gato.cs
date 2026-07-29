using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterface
{
    internal class Gato:IAnimal
    {
    
            public void Falar()
            {
                Console.WriteLine("O gato faz: Miau!");
            }

            public void Mover()
            {
                Console.WriteLine("O gato está andando.");
            }
        }

    }

