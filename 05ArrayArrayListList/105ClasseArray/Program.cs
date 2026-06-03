// See https://aka.ms/new-console-template for more information

Console.WriteLine("## Classe Array ##");

string[] nomes = new string[5] { "Aida", "Vitoria", "Ayla", "Eduarda", "Astarte" };

Console.WriteLine("\n\nExibindo array original.");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array.");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o Array");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array.");
Console.WriteLine("Informe o nome:");
string nomeArray;
nomeArray = Console.ReadLine();


var indice = Array.BinarySearch(nomes, nomeArray);


if (indice >= 0)
{
    Console.WriteLine($"\n{nomeArray} foi encontrado com o índice {indice}");
}
else
{
    Console.WriteLine($"\n{nomeArray} não foi encontrado");
}



Console.WriteLine("Pressione qualquer tecla para finalizar.");
Console.Read();

void ExibeArray(string[] strings)
{
    foreach (string nome in strings)
    {
        Console.WriteLine($"{nome} ");
    }
}

