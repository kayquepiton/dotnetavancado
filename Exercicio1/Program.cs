using System;
using Conta;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ContaBancaria conta1 = new ContaBancaria(1000);
            ContaBancaria conta2 = new ContaBancaria(500);

            int idConta1 = 1;
            int idConta2 = 2;

            conta1.Depositar(500, idConta1);
            conta1.Sacar(200, idConta1);
            conta1.Transferir(300, conta2, idConta1, idConta2);
            conta1.Sacar(-100, idConta1);
        }
        catch (ValorInvalidoException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Valor inválido: {ex.Valor}");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Saldo disponível: {ex.SaldoDisponivel}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
