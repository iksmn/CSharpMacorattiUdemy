namespace _129HerancaConstrutores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Herança - Construtores ##");


        DerivadaAluno aluno = new();
        
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
        public DerivadaAluno()
        {
            Console.WriteLine("Construtor da classe DerivadaAluno");
        }

        public DerivadaAluno(string nome)
        {
            Console.WriteLine("Construtor da classe DerivadaALuno com parâmetro.");
        }
    }
    
    
}