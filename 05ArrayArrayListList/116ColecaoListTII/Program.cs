Console.WriteLine("### Coleção List<T> ###");
Console.WriteLine("########## Exemplo 1 ##########");

var lista = new List<string>() {"Chris", "Ozzy", "Cacau", "Matilda", "Isadora"};

lista.Add("Morgana");

lista.Insert(2, "Joaquina");

Console.WriteLine(lista.Count + " itens ");


Console.WriteLine("########## Exemplo 2 ##########");

var lista2 = new List<string>() { "Sagittarii", "Canis Majoris", "Scorpii" };
string[] array2 = {"Persei", "Cygni", "Normae"};
lista2.AddRange(array2);
lista2.InsertRange(1, array2);
Console.WriteLine(lista2.Count + " itens ");

Console.WriteLine("########## Exemplo 3 ##########");

var lista3 = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

lista3.Remove(7);

lista3.RemoveAt(4);

lista3.RemoveRange(0, 2);

Console.WriteLine(lista3.Count + " itens ");

Console.WriteLine("########## Exemplo 4 ##########");


var lista4 = new List<string>() { "Cephei", "Westerlind", "Cassiopeiae", "Velorum" };

//acessar um elemento da lista usando índice
var primeiro = lista4[0];
var quarto = lista4[3];

Console.WriteLine(primeiro + " " + quarto);

lista4[0] = "Carinae";
lista4[3] = "Centauri";

Console.WriteLine(lista4[0] + " " + lista4[3]);

Console.ReadKey();