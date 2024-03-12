using System;

public class Data
{
    private readonly int dia;
    private readonly int mes;
    private readonly int ano;
    private readonly int hora;
    private readonly int minuto;
    private readonly int segundo;

    public const int FORMATO_12H = 12;
    public const int FORMATO_24H = 24;

    // Construtor para apenas data
    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    // Construtor para data e hora
    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        if (hora < 0 || hora > 23)
        {
            throw new ArgumentException("Hora deve estar entre 0 e 23.");
        }

        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
    }

    public int Dia
    {
        get { return dia; }
    }

    public int Mes
    {
        get { return mes; }
    }

    public int Ano
    {
        get { return ano; }
    }

    public int Hora
    {
        get { return hora; }
    }

    public int Minuto
    {
        get { return minuto; }
    }

    public int Segundo
    {
        get { return segundo; }
    }

    public void Imprimir(int formatoHora)
    {
        string data = $"{dia:D2}/{mes:D2}/{ano:D4}";

        if (hora != 0 && minuto != 0 && segundo != 0)
        {
            if (formatoHora == FORMATO_12H)
            {
                string periodo = (hora < 12) ? "AM" : "PM";
                int hora12h = (hora < 12) ? hora : hora - 12;
                if (hora12h == 0)
                {
                    hora12h = 12;
                }
                Console.WriteLine($"{data} {hora12h:D2}:{minuto:D2}:{segundo:D2} {periodo}");
            }
            else if (formatoHora == FORMATO_24H)
            {
                Console.WriteLine($"{data} {hora:D2}:{minuto:D2}:{segundo:D2}");
            }
            else
            {
                throw new ArgumentException("Formato de hora inválido.");
            }
        }
        else
        {
            Console.WriteLine(data);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando objeto Data com data e hora
        Data dataComHora = new Data(10, 3, 2000, 10, 30, 10);
        Console.WriteLine("Data com hora no formato 12 horas:");
        dataComHora.Imprimir(Data.FORMATO_12H);
        Console.WriteLine("Data com hora no formato 24 horas:");
        dataComHora.Imprimir(Data.FORMATO_24H);

        // Criando objeto Data com apenas data
        Data apenasData = new Data(25, 6, 2023);
        Console.WriteLine("Data apenas:");
        apenasData.Imprimir(Data.FORMATO_24H); // Sem efeito, pois não tem hora
    }
}
