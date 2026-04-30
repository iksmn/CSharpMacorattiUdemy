/*
/*
Console.WriteLine("## Classes e Métodos ##\n");/////////////////////////////////////////////////////////

Pessoa pessoa1 = new();
pessoa1.Nome = "Henrique";
pessoa1.Idade = 38;
pessoa1.Nacionalidade = "Brasileira";

Pessoa pessoa2 = new();
pessoa2.Nome = "Karl";
pessoa2.Idade = 26;
pessoa2.Nacionalidade = "Alemã";

Console.WriteLine($"{pessoa1.Nome}, {pessoa1.Idade}, {pessoa1.Nacionalidade}");
Console.WriteLine($"{pessoa2.Nome}, {pessoa2.Idade}, {pessoa2.Nacionalidade}");


Console.ReadKey();
class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
}
#1#


Console.WriteLine("## Classes e Métodos ##\n");//////////////////////////////////////////////////////////

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();

Console.ReadKey();


class MinhaClasse
{
    public void Saudacao() // a informação 'public' diz que o método é visível fora da classe também.
    {
        Console.WriteLine("Hello, Class!");
        ExibirDataAtual();
    }

    void ExibirDataAtual() // sem o 'public' o método é visível somente dentro da classe.
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}
*/

/*
Console.WriteLine("## Classes e Métodos ##\n"); /////////////////////////////////////////////////////////////////

MinhaClasse minhaClasse = new MinhaClasse();
MinhaClasse meuObjeto = new MinhaClasse();
//valores dos argumentos
minhaClasse.Saudacao("Engels", DateTime.Now.ToLongDateString());
meuObjeto.Saudacao("Ho Chi Min", DateTime.Now.ToLongTimeString());


Console.ReadKey();


public class MinhaClasse
{
    //parâmetros do método
    public void Saudacao(string nome, string data) 
    {
        Console.WriteLine(nome);
        Console.WriteLine(data); 
    }
}
*/
