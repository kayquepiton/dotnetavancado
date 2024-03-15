using System;

public enum Exercicio
{
    Academia = 1,
    Luta = 2,
    Corrida = 3
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Opções de exercícios disponíveis:");
        foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
        {
            Console.WriteLine($"{(int)exercicio}: {exercicio}");
        }

        Console.WriteLine("Digite o número correspondente ao exercício desejado:");
        try
        {
            int opcao = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(Exercicio), opcao))
            {
                Exercicio escolha = (Exercicio)opcao;
                Console.WriteLine($"Você escolheu o exercício: {escolha}");
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha um número válido.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato inválido. Por favor, insira um número válido.");
        }
    }
}