namespace _132HerancaVirtualOverride;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Clube time = new();
        time.Nome = "Arsenal";
        time.LaLiga = "Premier League";
        time.ExibeNome();

        Time time1 = new();
        time1.Nome = "PSG";
        time1.ExibeNome();
        
        
        Console.ReadKey();
    }
    
    
    //Classe Base
    class Liga
    {
        public string? Nome { get; set; }
        public string? LaLiga { get; set; }
        public virtual void ExibeNome() //A palavra 'virtual' é utilizada para indicar que o método pode ser extendido ou sobre-escrito nas classes derivadas.
        {
            Console.WriteLine($"O nome do clube é {Nome}.");
        }
    }
    
    //Classe Derivada
    class Clube : Liga
    {
        public override void ExibeNome() //A palavra 'override' é utilizada para sinalizar o método sobreescrito pela classe derivada
        {
            Console.WriteLine($"O clube é {Nome} que pertence a {LaLiga}.");
        }
    }

    class Time : Liga
    {
        
    }
}