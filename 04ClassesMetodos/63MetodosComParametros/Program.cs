Console.WriteLine("## Métodos pt.2 ##");

Copa26 Atleta01 = new Copa26();//Cria o objeto Atleta01 derivado da classe Copa26

Atleta01.Atleta("Haaland", 8);


Console.ReadKey();

public class Copa26
{
    public void Atleta(string nome, int gols) //Não pode ser static
    {
        Console.WriteLine($"O jogador {nome} tem {gols} gol(s).");
    }
}