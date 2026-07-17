Console.WriteLine("## Métodos - Parâmetros ##\n");


Selecoes selecao = new Selecoes();
selecao.Consultar(); 

Console.ReadKey();

public class Selecoes
{
    public string? Nome;
    public int Titulos;
    public string? Confederacao;


    public void Consultar()
    {
        var selecao = new Selecoes();

        Console.WriteLine("Seleção: ");
        selecao.Nome = Console.ReadLine();
        Console.WriteLine("Títulos: ");
        selecao.Titulos = Convert.ToInt32(Console.ReadLine()); //Prestar atenção na conversão de int
        Console.WriteLine("Confederacao: ");
        selecao.Confederacao = Console.ReadLine();


        var copas = new Copas();
        copas.Resultado(selecao);
    }
}

public class Copas
{
    public void Resultado(Selecoes selecao)
    {
        Console.WriteLine($"\nA selção {selecao.Nome}, da {selecao.Confederacao} tem {selecao.Titulos} título(s)!");
        if (selecao.Titulos == 5)
            Console.WriteLine("É PENTA!!!!");
        else
            Console.WriteLine("\nPode melhorar...");        
    }
}
