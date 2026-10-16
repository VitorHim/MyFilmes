using System;
using System.Collections.Generic;
using System.Threading;

namespace sistemaFilme;

class Program
{
    static void Main(string[] args)
    {
        //Declaração de variáveis
        string opcaoSelecionada = string.Empty;
        
        // Lista para armazenar filmes cadastrados
        var filmes = new List<Filme>();

        // Exibe o menu pelo menos uma vez e depois repete enquanto o usuário desejar cadastrar filmes
        do
        {
            ExibirMenu();

            // Lê a opção selecionada pelo usuário.
            opcaoSelecionada = Console.ReadLine();

            switch (opcaoSelecionada)   
            {
                case "1":
                    CadastrarFilme(filmes);
                    break;

                case "2":
                    ListarFilmes(filmes);
                    break;

                default:
                    break;
            }

        } while (opcaoSelecionada != "9");
            
        Console.Clear();
        Console.WriteLine("Programa encerrado pelo usuário.\n");
        Console.WriteLine("Obrigado por utilizar o sistema de cadastro de filmes!");
        Thread.Sleep(2000);
        
    }

    // Método para exibir o menu do sistema
    public static void ExibirMenu()
    {
        ExibirHeader();
        Console.WriteLine("Bem-vindo ao sistema de cadastro de filmes!");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(" > [1] Cadastrar filme");
        Console.WriteLine(" > [2] Listar filmes cadastrados");
        Console.WriteLine(" > [3] Favoritar filme");
        Console.WriteLine(" > [4] Pesquisar filme por genêro");
        Console.WriteLine(" > [9] Sair");
        Console.WriteLine("--------------------------------------------------");
        Console.Write("Digite a opção desejada: ");
    }

    // Método para exibir o cabeçalho do sistema
    public static void ExibirHeader()
    {
        //Pode ser gerado através do site:
        //https://coddy.tech/tools/ascii-art-generator
        Console.Clear();
        Console.WriteLine(@"█   █ █   █ █████ ███ █     █   █ █████  ████   
██ ██░ █ █ ░█░░░░░ █░░█░    ██ ██░█░░░░░█ ░░░░  
█░█ █░░ █ ░ ████░░░█░░█░░   █░█ █░████░░░███░░░ 
█░░░█░░ █░ ░█░░░░  █░░█░░   █░░░█░█░░░░   ░░█   
█░░ █░░ █░░ █░░░░░███░█████ █░░ █░█████░████░░  
░░  ░░  ░░  ░░    ░░░ ░░░░░ ░░  ░░░░░░░ ░░░░ ░ 
░   ░   ░   ░     ░░░ ░░░░░ ░   ░ ░░░░░ ░░░░  ");
        Console.WriteLine("");
        
    }

    // Método para cadastrar um filme
    public static void CadastrarFilme(List<Filme> filmes)
    {
        ExibirHeader();
        Console.WriteLine("Vamos cadastrar um novo filme!!!");

        var filme = new Filme();
        Console.Write("Digite o nome do filme: ");
        filme.Nome = Console.ReadLine();

        Console.Write("\nDigite o gênero do filme: ");
        filme.Genero = Console.ReadLine();

        Console.Write("\nDigite o ano de lançamento do filme: ");
        filme.AnoLancamento = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("\nDigite a avaliação do filme: ");
        filme.Avaliacao = double.Parse(Console.ReadLine() ?? "0");

        // Adiciona o filme cadastrado na lista
        filmes.Add(filme);
        Console.Write("\nFilme cadastrado com sucesso!");

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        ExibirMenu();
    }

    // Método para listar os filmes cadastrados
    public static void ListarFilmes(List<Filme> filmes)
    {
        ExibirHeader();
        Console.WriteLine("Vamos listar os filmes cadastrados!!!");

        if (filmes.Count == 0)
        {
            Console.WriteLine("Nenhum filme cadastrado.");
            return;
        }
        Console.WriteLine("Filmes cadastrados:");
        Console.WriteLine("--------------------------------------------------\n");
        foreach (var filme in filmes)
        {
            Console.WriteLine($"Titulo: {filme.Nome} | Gênero: {filme.Genero} | Ano de Lançamento: {filme.AnoLancamento} | Avaliação: {filme.Avaliacao}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        ExibirMenu();
    }



}
