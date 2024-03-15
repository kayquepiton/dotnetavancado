using System;

namespace Conta
{
    public class ValorInvalidoException : Exception
    {
        public double Valor { get; }

        public ValorInvalidoException(string mensagem, double valor) : base(mensagem)
        {
            Valor = valor;
        }
    }
}
