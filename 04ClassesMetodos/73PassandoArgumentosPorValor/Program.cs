Console.WriteLine(" ## Passando argumentos por valor ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por 'Dobrar' " + x);

Calculo calc = new();
calc.Dobrar(x);


Console.WriteLine("\nValor do argumento x depois de passar por 'Dobrar' " + x);



Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2; // y = y * 2
        Console.WriteLine("\n Valor do parâmetro y no método Dobrar " + y);
    }
}