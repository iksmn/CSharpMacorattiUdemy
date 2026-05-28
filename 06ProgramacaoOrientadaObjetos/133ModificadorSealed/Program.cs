namespace _133ModificadorSealed;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Modificador Sealed ##");

        Planeta P1 = new();
        //P1.Nome = "Vega";
        P1.ExibeNome();
        
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();




    }

    sealed class Estrela //O atributo 'sealed' impede que a classe seja herdada por outras classes.
    {
        public string?  Nome { get; set; }

        public void ExibeNome()
        {
            Console.WriteLine($"A estrela observada é {Nome}");
        }
    }

    class Planeta //: Estrela
    {
        public new void ExibeNome()
        {
            //Console.WriteLine(($"\nO planeta orbita a estrela {Nome}."));
        }
    }
}