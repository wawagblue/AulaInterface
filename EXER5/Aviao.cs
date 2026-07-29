namespace EXER5
{
    using System;

    public class Aviao : ITransporte
    {
        public void IniciarViagem(string destino)
        {
            Console.WriteLine($"Avião decolando para {destino}.");
        }

        public void FinalizarViagem()
        {
            Console.WriteLine("Avião pousou no destino.");
        }
    }
}
