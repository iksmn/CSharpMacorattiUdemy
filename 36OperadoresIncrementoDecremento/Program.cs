Console.WriteLine("## Operadores Incremento e Decremento ##\n");

int x = 0;
Console.WriteLine($"x = {x}");

//pós-incremento -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");


Console.ReadKey();