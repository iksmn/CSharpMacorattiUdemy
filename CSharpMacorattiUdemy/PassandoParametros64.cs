/*Console.WriteLine("## Métodos - Parâmetros ##\n");////////////////////////////////////////////////////////////////////

Aluno aluno = new (); //cria o objeto 'aluno' com todos os atributos da classe aluno

Console.WriteLine("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Idade do Aluno: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine()); //Converte pra int pois recebe string
Console.WriteLine("Nacionalidade do Aluno: ");
aluno.Nacionalidade = Console.ReadLine();
Console.WriteLine("Aprovado (S)im (N)ão: ");
aluno.Aprovado = Console.ReadLine();

Curso objCurso = new (); //cria o objeto 'curso' com os atributos da classe Curso
objCurso.Resultado(aluno.Nome, aluno.Idade, aluno.Nacionalidade, aluno.Aprovado); //invoca o método 'resultado' da classe curso


Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(string nome, int idade, string nacionalidade, string aprovado)
    {
        Console.WriteLine($"\nO aluno {nome}, de nacionalidade {nacionalidade} com {idade} anos");
        if (aprovado == "S")
            Console.WriteLine("\nfoi Aprovado");
        else
            Console.WriteLine("\n foi Reprovado");
    }
}*/


/*Console.WriteLine("## Métodos - Parâmetros ##\n");////////////////////////////////////////////////////////////////////

Aluno aluno = new (); //cria o objeto 'aluno' com todos os atributos da classe aluno

Console.WriteLine("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Idade do Aluno: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine()); //Converte pra int pois recebe string
Console.WriteLine("Nacionalidade do Aluno: ");
aluno.Nacionalidade = Console.ReadLine();
Console.WriteLine("Aprovado (S)im (N)ão: ");
aluno.Aprovado = Console.ReadLine();

Curso objCurso = new (); //cria o objeto 'curso' com os atributos da classe Curso
objCurso.Resultado(aluno); //invoca o método 'resultado' da classe curso


Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, de nacionalidade {aluno.Nacionalidade} com {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
            Console.WriteLine("\nfoi Aprovado");
        else
            Console.WriteLine("\n foi Reprovado");
    }
}*/

/*Console.WriteLine("## Métodos - Parâmetros ##\n");////////////////////////////////////////////////////////////////////


Aluno aluno = new ();
aluno.Consultar();

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;

    public void Consultar()
    {
        Aluno aluno = new (); //cria o objeto 'aluno' com todos os atributos da classe aluno

        Console.WriteLine("Nome do Aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Idade do Aluno: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine()); //Converte pra int pois recebe string
        Console.WriteLine("Nacionalidade do Aluno: ");
        aluno.Nacionalidade = Console.ReadLine();
        Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso objCurso = new (); //cria o objeto 'curso' com os atributos da classe Curso
        objCurso.Resultado(aluno); //invoca o método 'resultado' da classe curso
    }
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, de nacionalidade {aluno.Nacionalidade} com {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
            Console.WriteLine("\nfoi Aprovado");
        else
            Console.WriteLine("\n foi Reprovado");
    }
}*/