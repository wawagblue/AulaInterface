using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER2
{
    using System;

    class Program
    {
        static void Main()
        {
            IFormaGeometrica ret = new Retangulo(100, 50);
            IFormaGeometrica circ = new Circulo(16);
            IFormaGeometrica tri = new Triangulo(6, 4, 5, 5);

            Console.WriteLine($"Área Retângulo: {ret.CalcularArea()}");
            Console.WriteLine($"Perímetro Retângulo: {ret.CalcularPerimetro()}");

            Console.WriteLine($"Área Círculo: {circ.CalcularArea():F2}");
            Console.WriteLine($"Perímetro Círculo: {circ.CalcularPerimetro():F2}");

            Console.WriteLine($"Área Triângulo: {tri.CalcularArea()}");
            Console.WriteLine($"Perímetro Triângulo: {tri.CalcularPerimetro()}");
        }
    }
}
