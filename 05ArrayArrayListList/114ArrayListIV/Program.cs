using System.Collections;

var lista = new ArrayList() {"Maria", 5, true, 4.5, null, DateTime.Now};
var lista2 = new ArrayList() { "Cacau", "Matilda", "Isadora", "Morgana", "Joaquina" };
var lista3 = new ArrayList() { "Brasil", "Alemanha", "Italia", "Argentina", "Fraça" };


//verificar se um elemento existe na coleção

Console.WriteLine("\n########## Exemplo 'Lista' ##########\n");

var res1 = lista.Contains(5); //true
bool res2 = lista.Contains("Mari"); //false


Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null)); //true

Console.WriteLine("\n########## Exemplo 'Lista2' ##########\n");
Console.WriteLine("\nArrayList lista2 antes da organização\n");
foreach (var item in lista2)
{
    Console.WriteLine($"{item}");
}

lista2.Sort();
Console.WriteLine("\nArrayList lista2 organizado \n");
foreach (var item in lista2)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine("\n########## Exemplo 'Lista3' ##########\n");
Console.WriteLine("\nArrayList3 Original\n");
foreach (var item in lista3)
{
    Console.WriteLine($"{item}");
}

Console.WriteLine("\nNumero de elementos no arraylist " + lista3.Count);
lista3.Clear();
Console.WriteLine("\nNumero de elementos no arraylist depois do Clear " + lista3.Count);


Console.WriteLine("\n########## ArrayList IV #############\n");
Console.ReadKey();
