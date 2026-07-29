using System;

namespace EXER04
{
    internal class PagamentoPayPal : IPagamento
    {
      
        public void Processar(double valor)
        {
            Console.WriteLine($"Pagamento de R$ {valor:F2} realizado via PayPal.");
        }

        public void CancelarPagamento()
        {
            Console.WriteLine("Pagamento PayPal cancelado.");
        }

    }

}