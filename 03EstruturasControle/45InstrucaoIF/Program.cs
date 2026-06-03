namespace _45InstrucaoIF;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução IF ## \n");
        Console.WriteLine("Cliente Especial (S/N)");

        var resposta = Console.ReadLine();

        if (resposta == "S")
        {
            Console.WriteLine("Desconto de 10%");
            
            Console.WriteLine("Aplicar desconto? (true/false)");
            var resposta2 = Convert.ToBoolean(Console.ReadLine());

            if (resposta2)
            {
                Console.WriteLine("Desconto aplicado.");
            }
        }
        
        Console.WriteLine("Fim do processamento");
        Console.ReadKey();
    }
}