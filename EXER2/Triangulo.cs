namespace EXER2
{
    public class Triangulo : IFormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Triangulo(double b, double h, double l1, double l2)
        {
            Base = b;
            Altura = h;
            Lado1 = l1;
            Lado2 = l2;
        }

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public double CalcularPerimetro()
        {
            return Base + Lado1 + Lado2;
        }
    }
}
