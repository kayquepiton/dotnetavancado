using System;

public class Lampada
{
    private bool ligada;

    public Lampada(bool ligada)
    {
        this.ligada = ligada;
    }

    public void Ligar()
    {
        ligada = true;
        Imprimir();
    }

    public void Desligar()
    {
        ligada = false;
        Imprimir();
    }

    public void Imprimir()
    {
        if (ligada)
        {
            Console.WriteLine("Lâmpada ligada");
        }
        else
        {
            Console.WriteLine("Lâmpada desligada");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lâmpada inicialmente ligada
        Lampada lampada = new Lampada(ligada: true);
        lampada.Imprimir();

        // Desligando a lâmpada
        lampada.Desligar();

        // Ligando a lâmpada novamente
        lampada.Ligar();
    }
}
