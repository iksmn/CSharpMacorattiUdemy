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
Console.WriteLine($"\nExpressão lambda => {estrela2}");

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}