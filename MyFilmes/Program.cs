using System;
using System.Collections.Generic;

namespace sistemaFilme;

class Program
{
    static void Main(string[] args)
    {
       
        

        string opcao;
        // Lista para armazenar filmes cadastrados
        var filmes = new List<Filme>();

        
        do
        {
            // Adiciona um novo filme e preenche com os dados do usuário
            var filme = new Filme();

            Console.WriteLine("Digite o nome do filme:");
            filme.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite o gênero do filme:");
            filme.Genero = Console.ReadLine();

            Console.WriteLine("\nDigite o ano de lançamento do filme:");
            filme.AnoLancamento = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("\nDigite a avaliação do filme:");
            filme.Avaliacao = double.Parse(Console.ReadLine() ?? "0");

            //Limpar a tela daqui para cima 
            Console.Clear();

            // Adiciona o filme cadastrado na lista
            filmes.Add(filme);

            Console.WriteLine("Filme cadastrado com sucesso!\n");
            Console.WriteLine("Deseja cadastrar outro filme? (s/n)");
                opcao = Console.ReadLine().ToLower();

            Console.WriteLine("lista de filmes cadastrados:");
            Console.WriteLine("--------------------------------------------------");

            // Exibe a lista de filmes cadastrados
            foreach (var f in filmes)
            {
                Console.WriteLine(
                    $"{f.Nome} | {f.Genero} | " +
                    $"{f.AnoLancamento} | Nota: {f.Avaliacao}");

            }


        } while (opcao == "s");
            
            Console.Clear();
        Console.WriteLine("Programa encerrado.");
          

        
    }   
}
