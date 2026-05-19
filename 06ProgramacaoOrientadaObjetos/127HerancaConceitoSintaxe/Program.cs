Console.WriteLine(" ### Herança - Conceito e Sintaxe ### ");

Funcionario funcionario01 = new();
funcionario01.Nome = "Asterix";
funcionario01.Email = "asterix@email.fr";
funcionario01.Empresa = "Irredutíveis";
funcionario01.Salario = 9000;

Console.WriteLine("Funcionário");
Console.WriteLine(funcionario01.Empresa);
Console.WriteLine(funcionario01.Salario);
funcionario01.Identificar();

Aluno aluno01 = new();
aluno01.Nome = "Obelix";
aluno01.Email = "obelix@email.fr";
aluno01.Curso = "Engenharia";
aluno01.Nota = 10;

Console.WriteLine("\nAluno\n");
Console.WriteLine(aluno01.Curso);
Console.WriteLine(aluno01.Nota);
aluno01.Identificar();



Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}");
    }
    
}

public class Funcionario :  Pessoa
{ 
    public string? Empresa { get; set; }
    public decimal Salario { get; set; } 
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}