using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Task.WhenAll(DoWorkAsync("Tarefa 1"), DoWorkAsync("Tarefa 2"));
        Console.WriteLine("Ambas as tarefas foram concluídas.");
    }

    static async Task DoWorkAsync(string taskName)
    {
        Console.WriteLine($"Iniciando {taskName}");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{taskName} está realizando o trabalho {i}...");
            await Task.Delay(1000); 
        }
        Console.WriteLine($"{taskName} concluída.");
    }
}
