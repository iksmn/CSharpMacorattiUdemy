Console.WriteLine("## Métodos com Retorno");

Calculadora calc = new();// Instância da classe Calculadora (Objeto da classe Calculadora)

var valor = calc.Somar(10, 20);
Console.WriteLine(valor);
Console.WriteLine(calc.Somar(10, 20));



Console.WriteLine("Pressione uma tecla para sair.");
Console.ReadKey();

public class Calculadora
{
    public int Somar (int x, int y) //Método de instância
    {
        return x + y;
    }
    public int Subtrair (int x, int y) //Método de instância
    {
        return x - y;
    }
    public int Multiplicar (int x, int y) //Método de instância
    {
        return x * y;
    }
    public int Dividir (int x, int y) //Método de instância
    {
        return x / y;
    }
}