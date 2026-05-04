/*Console.WriteLine("## Construtores ##");//////////////////////////////////////////////////////////////////////////////

AlunoConstrutores aluno01 = new ();


//Operador ternário (condição ? expressão1_se_true : expressão2_se_false)

Console.WriteLine(aluno01.Nome == null ? "null" : aluno01.Nome);
Console.WriteLine(aluno01.Idade == 0 ? "zero" : aluno01.Idade);
Console.WriteLine(aluno01.Nacionalidade == null ? "null" : aluno01.Nacionalidade);
Console.WriteLine(aluno01.Aprovado == null ? "null" : aluno01.Aprovado);


Console.ReadLine();

public class AlunoConstrutores
{
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;
}*/

/*Console.WriteLine("## Construtores ##");//////////////////////////////////////////////////////////////////////////////

Estudante aluno01 = new ("Kepler", 30, "Alemão", "S"); 


//Operador ternário (condição ? expressão1_se_true : expressão2_se_false)

Console.WriteLine(aluno01.Nome == null ? "null" : aluno01.Nome);
Console.WriteLine(aluno01.Idade == 0 ? "zero" : aluno01.Idade);
Console.WriteLine(aluno01.Nacionalidade == null ? "null" : aluno01.Nacionalidade);
Console.WriteLine(aluno01.Aprovado == null ? "null" : aluno01.Aprovado);


Console.ReadLine();

public class Estudante
{
    public Estudante(string nome, int idade, string nacionalidade, string aprovado)
    {
        Nome = nome;
        Idade = idade; 
        Nacionalidade = nacionalidade;
        Aprovado = aprovado;
    }
    
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;
}*/

/*Console.WriteLine("## Construtores ##");//////////////////////////////////////////////////////////////////////////////

Estudante aluno01 = new (35, "Tcheco", "S"); 


//Operador ternário (condição ? expressão1_se_true : expressão2_se_false)

Console.WriteLine(aluno01.Nome == null ? "null" : aluno01.Nome);
Console.WriteLine(aluno01.Idade == 0 ? "zero" : aluno01.Idade);
Console.WriteLine(aluno01.Nacionalidade == null ? "null" : aluno01.Nacionalidade);
Console.WriteLine(aluno01.Aprovado == null ? "null" : aluno01.Aprovado);


Console.ReadLine();

public class Estudante
{

    public Estudante(string nome) => Nome = nome;//Forma válida de contrutor com apenas um atributo
    
    public Estudante(int idade, string nacionalidade, string aprovado)
    {
        Idade = idade; 
        Nacionalidade = nacionalidade;
        Aprovado = aprovado;
    }
    
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;
}*/


/*Console.WriteLine("## Construtores ##");//////////////////////////////////////////////////////////////////////////////

Estudante aluno01 = new ("Kepler",35, "Tcheco", "S"); 


//Operador ternário (condição ? expressão1_se_true : expressão2_se_false)

Console.WriteLine(aluno01.Nome == null ? "null" : aluno01.Nome);
Console.WriteLine(aluno01.Idade == 0 ? "zero" : aluno01.Idade);
Console.WriteLine(aluno01.Nacionalidade == null ? "null" : aluno01.Nacionalidade);
Console.WriteLine(aluno01.Aprovado == null ? "null" : aluno01.Aprovado);


Console.ReadLine();

public class Estudante
{

    public Estudante(string nome) => Nome = nome;//Forma válida de contrutor com apenas um atributo
    
    public Estudante(string nome,int idade, string nacionalidade, string aprovado) : this(nome)//chamando outro construtor dentro de um construtor
    {
        Idade = idade; 
        Nacionalidade = nacionalidade;
        Aprovado = aprovado;
    }
    
    public string? Nome;
    public int Idade;
    public string? Nacionalidade;
    public string? Aprovado;
}*/