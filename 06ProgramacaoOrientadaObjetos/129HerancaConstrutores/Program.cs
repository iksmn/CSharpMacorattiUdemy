namespace _129HerancaConstrutores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Herança - Construtores ##");

        DerivadaAluno aluno1 = new();
        DerivadaAluno aluno2 = new("José");
        
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
    
    
    //Construtores tem o mesmo nome da classe, incluido o Case
    class BasePessoa
    {
        public BasePessoa()
        {
            Console.WriteLine("Construtor da classe BasePessoa");
        }

        public BasePessoa(string nome)
        {
            Console.WriteLine("Construtor da classe BasePessoa com parâmetro.");
        }
    }

    class DerivadaAluno : BasePessoa 
    {
        public DerivadaAluno() : base()
        {
            Console.WriteLine("Construtor da classe DerivadaAluno");
        }

        public DerivadaAluno(string nome) : base(nome)
        {
            Console.WriteLine("Construtor da classe DerivadaAluno com parâmetro.");
        }
    }
    
    
}