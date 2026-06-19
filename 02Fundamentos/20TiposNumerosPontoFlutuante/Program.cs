Console.WriteLine("Atribuindo valores a double, float e decimal");

double n1 = 1.234d;  //utiliza-se o 'd' para indicar ao compilador que se trata de um double
float n2 = 1.234f;   //utiliza-se o 'f' para indicar ao compilador que se trata de um float
decimal n3 = 1.234m; //utiliza-se o 'm' para indicar ao compilador que se trata de um decimal

Console.WriteLine("Atribuindo valores a float, n1, n2, n3");

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.ReadKey();

float x = 1f/3f;
double y = 1d/3d;
decimal z = 1m/3m;

Console.WriteLine($"Precisão do float: {x}");
Console.WriteLine($"Precisão do double: {y}");
Console.WriteLine($"Precisão do decimal: {z}");

Console.ReadKey();