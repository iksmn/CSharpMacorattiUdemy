namespace _84ExercicioPraticoVI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Exercício Prático VI ##");
        
        Console.WriteLine($"O valor do IPVA é: {Carro.ObterValorIPVA()}");
    }
    
    public class Carro
    {
        public static double ValorIpva;

        public static double ObterValorIPVA()
        {
            ValorIpva = 4.0;
            return ValorIpva;
        }
    }
}