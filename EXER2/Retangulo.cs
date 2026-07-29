namespace EXER2
{
    public class Retangulo : IFormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
