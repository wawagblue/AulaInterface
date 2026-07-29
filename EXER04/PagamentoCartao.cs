using EXER04;
using System;


public class PagamentoCartao : IPagamento

{
    public void Processar(double valor)
    {
        Console.WriteLine("/n [CARTÃO] Conectando com a operadora....");
        Console.WriteLine($"Transacao  de R${valor} aprovado na maquininha");
    }
    public void CancelarPagamento()
    {
        Console.WriteLine("Pagamento no Cartão cancelado.");
    }
}