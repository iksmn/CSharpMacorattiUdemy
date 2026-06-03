namespace _102Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Declaração de Array
        int[] numeros;
        
        //Alocação de memória
        numeros = new int[10] {1,2,3,4,5,6,7,8,9,70};

        string[] nomes = new string[5] { "Aida", "Vitoria", "Ayla", "Eduarda", "Astarte" };
        string[] nomes1 = new string[] { "Aida", "Vitoria", "Ayla", "Eduarda", "Astarte" };
        string[] nomes2 = { "Aida", "Vitoria", "Ayla", "Eduarda", "Astarte" };
        
        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes[1]);
        Console.WriteLine(nomes[2]);
        Console.WriteLine(nomes[3]);
        Console.WriteLine(nomes[4]);
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

    }
}