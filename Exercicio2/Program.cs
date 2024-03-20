using System;
using System.Collections.Generic;
using System.Linq;

public enum Tipo
{
    Comida,
    Bebida,
    Higiene,
    Limpeza
}

public class ItemMercado
{
    public string Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }
}

public class Programa
{
    public static void Main()
    {
        List<ItemMercado> itens = new List<ItemMercado>
        {
            new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 },
            new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 },
            new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.50 },
            new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 },
            new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.40 },
            new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 },
            new ItemMercado { Nome = "Sabão em pó", Tipo = Tipo.Limpeza, Preco = 8.20 },
            new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 },
            new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 }
        };

        // Expressões LINQ para retornar informações:
        var higieneOrdenadosPorPrecoDesc = itens.Where(i => i.Tipo == Tipo.Higiene)
                                                .OrderByDescending(i => i.Preco)
                                                .ToList();

        var precoMaiorOuIgualCincoOrdemCrescente = itens.Where(i => i.Preco >= 5.00)
                                                       .OrderBy(i => i.Preco)
                                                       .ToList();

        var comidaBebidaOrdemAlfabetica = itens.Where(i => i.Tipo == Tipo.Comida || i.Tipo == Tipo.Bebida)
                                               .OrderBy(i => i.Nome)
                                               .ToList();

        var quantidadePorTipo = itens.GroupBy(i => i.Tipo)
                                     .Select(g => new 
                                     {
                                         g.Key,
                                         Quantidade = g.Count()
                                     })
                                     .ToList();

        var precoStatsPorTipo = itens.GroupBy(i => i.Tipo).Select(g => new 
                                    {
                                        g.Key,
                                        MaxPrice = g.Max(x => x.Preco),
                                        MinPrice = g.Min(x => x.Preco),
                                        AveragePrice = g.Average(x => x.Preco) 
                                    }).ToList();

        // Imprimir os resultados:
        Console.WriteLine("Itens de Higiene (ordenados por preço decrescente):");
        foreach (var item in higieneOrdenadosPorPrecoDesc)
        {
            Console.WriteLine($"{item.Nome} - {item.Preco:C}");
        }

        Console.WriteLine("\nItens com preço maior ou igual a R$ 5,00 (ordenados por preço crescente):");
        foreach (var item in precoMaiorOuIgualCincoOrdemCrescente)
        {
            Console.WriteLine($"{item.Nome} - {item.Preco:C}");
        }

        Console.WriteLine("\nItens de Comida ou Bebida (ordenados por nome alfabeticamente):");
        foreach (var item in comidaBebidaOrdemAlfabetica)
        {
            Console.WriteLine($"{item.Nome} ({item.Tipo})");
        }

        Console.WriteLine("\nQuantidade de itens por tipo:");
        foreach (var tipo in quantidadePorTipo)
        {
            Console.WriteLine($"{tipo.Key}: {tipo.Quantidade}");
        }

        Console.WriteLine("\nEstatísticas de preço por tipo:");
        foreach (var stats in precoStatsPorTipo)
        {
            Console.WriteLine($"{stats.Key}: Máximo {stats.MaxPrice:C} | Mínimo {stats.MinPrice:C} | Média {stats.AveragePrice:C}");
        }
    }
}
