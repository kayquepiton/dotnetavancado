using System;

namespace Conta
{
    public class ContaBancaria
    {
        private double saldo;

        public ContaBancaria(double saldoInicial)
        {
            if (saldoInicial < 0)
            {
                throw new ValorInvalidoException("Saldo inicial não pode ser negativo.", saldoInicial);
            }

            saldo = saldoInicial;
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor, int idConta)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor de depósito inválido.", valor);
            }

            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso para a conta {idConta}. Saldo atual: {saldo}");
        }

        public void Sacar(double valor, int idConta)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor de saque inválido.", valor);
            }

            if (valor > saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para realizar o saque.", saldo);
            }

            saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado com sucesso para a conta {idConta}. Saldo atual: {saldo}");
        }

        public void Transferir(double valor, ContaBancaria contaDestino, int idContaOrigem, int idContaDestino)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor de transferência inválido.", valor);
            }

            if (valor > saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para realizar a transferência.", saldo);
            }

            saldo -= valor;
            contaDestino.Depositar(valor, idContaDestino);
            Console.WriteLine($"Transferência de {valor} realizada com sucesso da conta {idContaOrigem} para a conta {idContaDestino}. Saldo atual: {saldo} da conta {idContaDestino}");
        }
    }
}
