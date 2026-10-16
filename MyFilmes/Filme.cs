
namespace sistemaFilme;

public class Filme
{
    public string Nome { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public int AnoLancamento { get; set; }
    public double Avaliacao { get; set; }
    public bool Favorito = false;
}