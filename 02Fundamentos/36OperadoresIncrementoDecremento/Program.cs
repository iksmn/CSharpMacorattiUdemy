Console.WriteLine("## Operadores Incremento e Decremento ##\n");

int x = 0;
Console.WriteLine($"x = {x}");

//pós-incremento -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");

int y = 0;
Console.WriteLine($"y = {y}");

//pré-incremento -> primeiro incrementa depois resolve
int resultado2 = ++y + 10;
Console.WriteLine($"pós-incremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y}\n");


//pós-decremento -> primeiro resolve depois decrementa
int z = 0;
Console.WriteLine($"z = {z}");
int resultado3 = z-- + 10;
Console.WriteLine($"pós-decremento ==> {resultado3}");
Console.WriteLine($"valor de z ==> {z}\n");

int w = 0;
Console.WriteLine($"w = {w}");

//pré-incremento -> primeiro decrementa depois resolve
int resultado4 = --w + 10;
Console.WriteLine($"pós-incremento ==> {resultado4}");
Console.WriteLine($"valor de w ==> {w}\n");

Console.ReadKey();