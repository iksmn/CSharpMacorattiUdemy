namespace _46InstrucaoIfElse;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução if-else ##\n");
        Console.WriteLine("Informar média de gols por jogo \t");
        var gols = Convert.ToDouble(Console.ReadLine());
        
        if (gols >= 3.50)
        {
            Console.WriteLine("É o craque, não tem jeito!");
        }
        else
        {
            Console.WriteLine("E vai pra Copa ainda?");
        }

        Console.ReadKey();


    }
}