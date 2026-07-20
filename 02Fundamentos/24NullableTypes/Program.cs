Console.WriteLine("## Nullable Types ##\n");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;


Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);


int? a = null;
int z = a ?? 1; //Operador de coalescência nula '??', serve para verificar se a variável é o não nula 
                //Caso seja, atribui o valor estipulado pelo usuário

Console.WriteLine(z);


int? m = 100;

if (m.HasValue)
{
    Console.WriteLine($"m = {m.Value}");
}
else
{
    Console.WriteLine($"m = {null}");
}

Console.ReadKey(); 
