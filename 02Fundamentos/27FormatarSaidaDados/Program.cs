Console.WriteLine("Formatação de saída de dados.\n");

string nome = "Matida";
int idade = 4;

Console.WriteLine("----------Concatenação----------");
Console.WriteLine("Concatenação usa o operador '+' para formar as sentenças.");
Console.WriteLine(nome + " tem " + idade + " anos.");
Console.WriteLine();

Console.WriteLine("----------Interpolação----------");
Console.WriteLine("Interpolação usa o sinal '$', que permite utilizar as variáveis diretamente na string.");
Console.WriteLine($"{nome} tem {idade} anos.");
Console.WriteLine();

Console.WriteLine("----------Place Holders----------");
Console.WriteLine("Place Holders utilizam {} para determinar a numeração e a posição das variáveis na string.");
Console.WriteLine("{0} tem {1} anos.", nome, idade);

Console.ReadKey();