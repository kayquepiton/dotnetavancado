using System;
using Fabrica;

public class Program
{
    static void Main(string[] args)
    {

        ServicoFabrica<Servico> fabrica = new ServicoFabrica<Servico>();
        Servico servico = fabrica.NovaInstancia();
        
        servico.Executar();
    }
}
