Console.WriteLine("## 42 - Exercícios Fundamentos ##");

Console.WriteLine("1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :" +
                  "\nAluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.");

string nome = "Paulo";
int idade = 17;
double nota = 7.5D;

Console.WriteLine("\nInterpolação de strings");
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}.");

Console.WriteLine("\nConcatenação");
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e note " + nota + "." );

Console.WriteLine("\nSequência de escapes");
Console.WriteLine($"{nome}\n{idade}\n{nota}");



Console.WriteLine("Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando" +
                  "\na concatenação e também a interpolação de strings");

Console.WriteLine("\nDigite a primeira letra: ");
//char letra1 = (char)Console.Read();
char letra1 = Console.ReadKey().KeyChar ;
Console.WriteLine("\nDigite a segunda letra: ");
//char letra2 = (char)Console.Read();
char letra2 = Console.ReadKey().KeyChar;
Console.WriteLine("\nDigite a terceira letra: ");
//char letra3 = (char)Console.Read();
char letra3 = Console.ReadKey().KeyChar;



Console.WriteLine("\n\nInterpolação de string:");
Console.WriteLine($"Terceira letra: {letra3}, segunda letra: {letra2}, primeira letra: {letra1}.t");

Console.WriteLine("\nConcatenação:");
Console.WriteLine("Terceira letra: " + letra3 + " segunda letra: " + letra2 + " primeira letra: " + letra1 + ".");

