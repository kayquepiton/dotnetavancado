using System;
using System.Threading;

class Worker
{
    public void Work()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Trabalhador {Thread.CurrentThread.Name} está realizando o trabalho {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine($"Trabalhador {Thread.CurrentThread.Name} concluiu o trabalho.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker worker1 = new Worker();
        Worker worker2 = new Worker();

        Thread thread1 = new Thread(worker1.Work);
        thread1.Name = "1";
        Thread thread2 = new Thread(worker2.Work);
        thread2.Name = "2";

        // Inicia as duas threads
        thread1.Start();
        thread2.Start();

        // Aguarda até que ambas as threads tenham terminado de executar
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Ambas as threads terminaram. Programa encerrado.");
    }
}
