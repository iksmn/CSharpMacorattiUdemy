Console.WriteLine("\n## Entrada de Dados##");


Console.WriteLine("\nInforme o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Informe a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nCom concatenação:");
Console.WriteLine("Seu nome é " + nome + ".");
Console.WriteLine("Você tem " + idade + " anos.");

Console.WriteLine("\nCom interpolação:");
Console.WriteLine($"Seu nome é {nome}");
Console.WriteLine($"Você tem {idade} anos");

Console.WriteLine("\n Utilizando 'Console.Read()':");
int qtdeTitulos = Console.Read();
Console.WriteLine($"O valor armazendado em 'qtdeTitulos' é: {qtdeTitulos}.");

Console.WriteLine("Pressione qualquer tecla para encerrar...");
Console.ReadKey();


