using EXER04;
using System;



public class PagamentoBoleto : IPagamento
{
    public void CancelarPagamento()
    {
        Console.WriteLine("Boleto cancelado.");
    }

    public void Processar(double valor)
    {
        Console.WriteLine("\n[BOLETO] Gerando código de barras");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine("| ||| || || | | || | || ||| || | || ||| |");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine($"Boleto gerado no valor de R${valor}");
    }
}