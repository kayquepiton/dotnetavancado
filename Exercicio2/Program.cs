using System;

class Program
{
    static void Main()
    {
        try
        {
            object o = null;
            o.ToString(); 
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("O objeto é nulo. Não é possível chamar o método ToString().");
        }
    }
}
