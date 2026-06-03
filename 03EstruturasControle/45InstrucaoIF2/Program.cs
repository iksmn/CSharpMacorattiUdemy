namespace _45InstrucaoIF2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução IF ##");
        
        Console.WriteLine("Informe o valor de x \t");
        int x = Convert.ToInt32(Console.ReadLine());
       
        
        Console.WriteLine("Informe o valor de y");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
        {
            Console.WriteLine(" x é maior que y");
        }

        if (x < y)
        {
            Console.WriteLine(" x é menor que y");
        }

        if (x == y)
        {
            Console.WriteLine("x é igual a y");
        }
    }
}