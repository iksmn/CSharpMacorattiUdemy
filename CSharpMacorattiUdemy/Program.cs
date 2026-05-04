Console.WriteLine("## THIS ##");



Console.ReadKey();

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: " + t.Num1);
        Console.WriteLine("Num2: " + t.Num2);
    }

    public void Exibir()
    {
        //passando "this" como um parâmetro (a classe Teste)
        PassarParametro(this);
    }
}