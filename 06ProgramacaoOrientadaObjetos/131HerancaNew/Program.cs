namespace _131HerancaNew;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Estudante aluno = new();
        aluno.Nome = "Lenin";
        aluno.Curso = "Mecânica";
        Console.WriteLine(aluno.Saudacao());
        
        Console.ReadKey();
    }


    class Pessoa
    {
        public string? Nome { get; set; }

        public string Saudacao() => $"Olá, eu sou o (a) {Nome}";
    }

    class Estudante : Pessoa
    {
        public string? Curso { get; set; }

        public new string Saudacao() // Utiliza-se a palavra 'new' para afirmar ao compilador que se quer sobre-escrever o método da classe base.
            => $"Olá, eu sou o (a) {Nome} do curso de : {Curso}";
    }
    
    
}