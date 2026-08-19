Console.WriteLine("## Enum ##");

Console.WriteLine(DeusesOlimpo.Afrodite);
Console.WriteLine(DeusesOlimpo.Efesto);

int deus1 = (int)DeusesOlimpo.Afrodite;
int deus3 = (int)DeusesOlimpo.Efesto;
int deus5 = (int)DeusesOlimpo.Persefone;

Console.WriteLine($"\n{DeusesOlimpo.Afrodite} vale: {deus1}");
Console.WriteLine($"\n{DeusesOlimpo.Efesto} vale: {deus3}");
Console.WriteLine($"\n{DeusesOlimpo.Persefone} vale: {deus5}");

Console.WriteLine($"{Planetas.Venus} - {(int)Planetas.Venus}");
Console.WriteLine($"{Planetas.Saturno} - {(int)Planetas.Saturno}");
Console.WriteLine($"{Planetas.Netuno} - {(int)Planetas.Netuno}");


Console.WriteLine("\nSelecione o planeta digitando o valor correspondente.");
int valor = Convert.ToInt32(Console.ReadLine());
var nomePlaneta = (Planetas)valor;
Console.WriteLine($"\nPlaneta selecionado: {nomePlaneta.ToString()}");


Console.ReadKey();

enum Planetas
{
    Mercurio,
    Venus,
    Terra,
    Marte,
    Jupiter,
    Saturno,
    Urano,
    Netuno
}

enum DeusesOlimpo
{
    Ares,
    Afrodite,
    Baco,
    Efesto,
    Hades = 27,
    Persefone,
    Zeus
}