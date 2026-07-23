Console.WriteLine("Instruções If-Else");

Console.WriteLine("Informe o número de assistências de Haaland: \t");
int xhaaland = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o número de assistência de Dembélé: \t");
int ydembele = Convert.ToInt32(Console.ReadLine());

if (xhaaland < ydembele)
{
    Console.WriteLine("Dembélé tem mais assistências que Haaland");
}
else
{
    if (xhaaland > ydembele)
    {
        Console.WriteLine("Haaland tem mais assistências que Dembélé");
    }
    else
    {
        Console.WriteLine("Dembélé tem o mesmo número de assistências que Haaland");
    }
}