namespace EXER5
{
    using System;

    public class Trem : ITransporte
    {
        public void IniciarViagem(string destino)
        {
            Console.WriteLine($"Trem partindo para {destino}.");
        }

        public void FinalizarViagem()
        {
            Console.WriteLine("Trem chegou à estação final.");
        }
    }
}
