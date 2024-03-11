using System;

public class C1
{
    public void Imprimir()
    {
        Console.WriteLine("Objeto da classe C1");
    }
}

public class C2
{
    public void Imprimir()
    {
        Console.WriteLine("Objeto da classe C2");
    }
}

public class C3
{
    public void Imprimir()
    {
        Console.WriteLine("Objeto da classe C2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        C1 objetoC1 = new C1();
        C2 objetoC2 = new C2();
        C3 objetoC3 = new C3();

        objetoC3 = objetoC2
        objetoC2 = objetoC1
        objetoC1 = null;

        objetoC1.Imprimir();
        objetoC2.Imprimir();
        objetoC3.Imprimir();
    }
}
