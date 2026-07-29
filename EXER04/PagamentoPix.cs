using EXER04;
using System;


public class PagamentoPix : IPagamento
{
    public void Processar(double valor)
    {
        Console.WriteLine("[PIX] GERANDO QR CODE");
        Console.WriteLine("████████████████████████");
        Console.WriteLine("█ ▄▄▄▄▄ █ ▄ ▀█▀▄ ▄▀▄ ▄█");
        Console.WriteLine("█ █   █ █▄█ ▀█ ▀█▀█ ▀▄█");
        Console.WriteLine("█ █ █ █ █   ▀ █▀█▀  ▀▄█");
        Console.WriteLine("█ █▄▄▄█ █▀█▀ ▀▄█  █▀  █");
        Console.WriteLine("█       █▀▄▄▀█▀  ▄ ▀▀▀▀█");
        Console.WriteLine("█ ▄▄▄▄▄ █▀▄▀ ▀█▀█ ▀ ▀▀ █");
        Console.WriteLine("█       █ ▀▀▄█▀  ▀█▄█▀▀█");
        Console.WriteLine("████████████████████████");
        
        Console.WriteLine("Pagamento APROVADO!");
    }
    public void CancelarPagamento()
    {
        Console.WriteLine("Pagamento no QR_CODE cancelado.");
    }
}