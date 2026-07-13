Console.WriteLine("## Classes e Métodos##\n");


Pessoa pessoa = new Pessoa();
pessoa.Nome = "Mbappé";
pessoa.Idade = 25;
pessoa.Nacionalidade = "Francesa";

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Haaland";
pessoa2.Idade = 22;
pessoa2.Nacionalidade = "Norueguesa";


Console.WriteLine($"{pessoa.Nome} {pessoa.Idade} {pessoa.Nacionalidade}");
Console.WriteLine($"{pessoa2.Nome} {pessoa2.Idade} {pessoa2.Nacionalidade}");

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Nacionalidade { get; set; }
}