Console.WriteLine("\n########## Exemplo 1 ##########\n");


var lista = new List<string>() {"Sírio", "Canopus", "Alpha Centauri", "Arcturo"};

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine("\n########## Exemplo 2 ##########\n");

var lista2 = new List<string>() { "Vega", "Capela", "Rígel", "Prócion", "Archernar" };

foreach (var elemento in lista2)
{
    Console.WriteLine(elemento);
}


Console.WriteLine("\n########## Exemplo 3 ##########\n");

var lista3 = new List<string> { "Betelgeuse", "Hadar", "Altair", "Acrux" };

var res1 = lista3.Contains("Hadar"); //true
var res2 = lista3.Contains("Altair"); // true

var res3 = lista3.Contains("Proxima b"); //false
var res4 = lista3.Contains("Deneb"); //false

Console.WriteLine(lista3.Contains("Betelgeuse"));

Console.WriteLine("\n########## Exemplo 4 ##########\n");

var lista4 = new List<string> { "Aldebaran", "Antares", "Espiga", "Pólux", "Bellatrix", "Alnath" };

ExibirLista(lista4);

lista4.Sort();

ExibirLista(lista4);

lista4.Clear();
ExibirLista(lista4);
Console.WriteLine("Fim dos testes.");

Console.Read();

static void ExibirLista(List<string> lista4)
{
    Console.WriteLine();
    foreach (var item in lista4)
    {
        Console.WriteLine(item);
    }
}


Console.ReadKey();