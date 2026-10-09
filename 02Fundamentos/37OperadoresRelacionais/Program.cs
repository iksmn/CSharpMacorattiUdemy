Console.WriteLine("## Operadores Relacionais ##");


int x = 10;
int y = 20;

Console.WriteLine($"Valor de x = {x}");
Console.WriteLine($"Valor de y = {y}");

Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);


string a = "Curso";
string b = "curso";

Console.WriteLine($"\nValor de a = {a}");
Console.WriteLine($"Valor de b = {b}");
Console.WriteLine(b == a);
Console.WriteLine(a.Equals(b));



Console.ReadKey();