using System;

namespace EXER04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("     SISTEMA DE PAGAMENTOS");
            Console.WriteLine("=================================");
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - Cartão");
            Console.WriteLine("2 - Boleto");
            Console.WriteLine("3 - Pix");
            Console.WriteLine("4 - PayPal");
            Console.Write("Opção: ");

            int opcao;

            try
            {
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                return;
            }

            IPagamento pagamento;

            switch (opcao)
            {
                case 1:
                    pagamento = new PagamentoCartao();
                    break;

                case 2:
                    pagamento = new PagamentoBoleto();
                    break;

                case 3:
                    pagamento = new PagamentoPix();
                    break;

                case 4:
                    pagamento = new PagamentoPayPal();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }


            Confimar(pagamento);

            Console.WriteLine();
            Console.Write("Digite o valor do pagamento: R$ ");

            double valor;

            try
            {
                valor = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido!");
                return;
            }
            Confimar(pagamento);
            Console.WriteLine();
            pagamento.Processar(valor);

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }

         static void Confimar(IPagamento pagamento){
            Console.WriteLine();
            Console.WriteLine("Deseja continuar com o pagamento?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Cancelar");
            Console.Write("Opção: ");

            int confirmar;

            try
            {
                confirmar = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida!");
                return;
            }

            if (confirmar == 2)
            {
                pagamento.CancelarPagamento();
                return;
            }
            else if (confirmar != 1)
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

        }
    }
}