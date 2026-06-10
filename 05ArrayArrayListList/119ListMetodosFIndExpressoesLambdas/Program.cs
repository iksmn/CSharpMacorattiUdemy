Console.WriteLine("### List ´Métodos Find ###");

List<string> estrelas = new()
{
    "Sírio", "Canopus", "Alpha Centauri", "Arcturo", "Vega", "Capela", "Rígel", "Prócion", "Archernar"
};

//usando Predicado como uma função
var estrela1 = estrelas.Find(Procura);
Console.WriteLine($"\nPredicado => {estrela1}");

//usando a expressão lambda
var estrela2 = estrelas.Find(i =>i.Contains('n'));
Console.WriteLine($"\nExpressão lambda Find => {estrela2}");


var estrela3 = estrelas.FindLast(i =>i.Contains('n'));
Console.WriteLine($"\nExpressão lambda FindLast => {estrela3}");

var estrela4 = estrelas.FindIndex(i =>i.Contains('n'));
Console.WriteLine($"\nExpressão lambda FindIndex : índice {estrela4}, item = {estrelas[estrela4]}");

var estrela5 = estrelas.FindLastIndex(i =>i.Contains('n'));
Console.WriteLine($"\nExpressão lambda FindLastIndex : índice {estrela5}, item = {estrelas[estrela5]}");

var estrelas6 = estrelas.FindAll(i =>i.Contains('n'));


foreach (var item in estrelas6)
{
    Console.Write($"\nEstrela {item} no índice {estrelas.IndexOf(item)}");
}


Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}