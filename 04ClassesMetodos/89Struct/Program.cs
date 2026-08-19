Console.WriteLine("## Structs ##");

Cidade cidade = new();
cidade.Nome = "Barcelona";
cidade.Idade = 2200;

Console.WriteLine($"{cidade.Nome} {cidade.Idade}");

Console.ReadKey();

public struct Cidade
{
    public string Nome  { get; set; }
    public int Idade   { get; set; }

    public Cidade(string? nome, int idade)
    {
            Nome = nome;
            Idade = idade;
    }
}