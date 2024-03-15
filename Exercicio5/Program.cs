using System;

public struct Ponto<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }

    public Ponto(T x, T y, T z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public struct Triangulo<T>
{
    public Ponto<T> P1 { get; set; }
    public Ponto<T> P2 { get; set; }
    public Ponto<T> P3 { get; set; }

    public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Ponto<int> pontoInt = new Ponto<int>(1, 2, 3);
        Ponto<double> pontoDouble = new Ponto<double>(1.5, 2.5, 3.5);
        Ponto<string> pontoString = new Ponto<string>("A", "B", "C");

        Triangulo<int> trianguloInt = new Triangulo<int>(pontoInt, pontoInt, pontoInt);
        Triangulo<double> trianguloDouble = new Triangulo<double>(pontoDouble, pontoDouble, pontoDouble);
        Triangulo<string> trianguloString = new Triangulo<string>(pontoString, pontoString, pontoString);

        Console.WriteLine("Triângulo com inteiros:");
        ExibirTriangulo(trianguloInt);
        
        Console.WriteLine("\nTriângulo com doubles:");
        ExibirTriangulo(trianguloDouble);
        
        Console.WriteLine("\nTriângulo com strings:");
        ExibirTriangulo(trianguloString);
    }

    static void ExibirTriangulo<T>(Triangulo<T> triangulo)
    {
        Console.WriteLine($"P1: ({triangulo.P1.X}, {triangulo.P1.Y}, {triangulo.P1.Z})");
        Console.WriteLine($"P2: ({triangulo.P2.X}, {triangulo.P2.Y}, {triangulo.P2.Z})");
        Console.WriteLine($"P3: ({triangulo.P3.X}, {triangulo.P3.Y}, {triangulo.P3.Z})");
    }
}
