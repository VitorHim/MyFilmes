using System;
using System.Collections.Generic;

namespace sistemaFilme;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar filmes cadastrados
        var filmes = new List<Filme>();

        // Cria um novo filme e preenche com os dados do usuário
        var filme = new Filme();

        Console.WriteLine("Digite o nome do filme:");
        filme.Nome = Console.ReadLine();

        Console.WriteLine("Digite o gênero do filme:");
        filme.Genero = Console.ReadLine();

        Console.WriteLine("Digite o ano de lançamento do filme:");
        filme.AnoLancamento = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a avaliação do filme:");
        filme.Avaliacao = double.Parse(Console.ReadLine() ?? "0");

        // Adiciona o filme cadastrado na lista
        filmes.Add(filme);

        Console.WriteLine("Filme cadastrado com sucesso!");
        Console.WriteLine("lista de filmes cadastrados:");
        foreach (var f in filmes)
        {
            Console.WriteLine($"Nome: {f.Nome}, Gênero: {f.Genero}, Ano: {f.AnoLancamento}, Avaliação: {f.Avaliacao}");
        }
    }   
}
