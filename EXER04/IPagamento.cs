
public interface IPagamento
{
    void Processar(double valor);
    void CancelarPagamento();
}