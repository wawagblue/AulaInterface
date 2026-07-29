namespace EXER5
{
    using System;

    public class Carro : ITransporte
    {
        public void IniciarViagem(string destino)
        {
            Console.WriteLine($"Carro iniciando viagem para {destino}.");
        }

        public void FinalizarViagem()
        {
            Console.WriteLine("Carro chegou ao destino.");
        }
    }
}
