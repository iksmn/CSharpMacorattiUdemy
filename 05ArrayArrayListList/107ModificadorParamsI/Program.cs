Console.WriteLine("\nDoma de números inteiros utilizando array no método\n");


int[] valores = { 1, 2, 3 };
var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma((new int[] { 10, 20, 30 }));
Console.WriteLine(resultado2);


Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();


public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}