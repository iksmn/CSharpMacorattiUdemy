Console.WriteLine("### Resolva a equação de Báskara");

double a, b, c, delta, x, x1, x2;

Console.WriteLine("Declare a variável a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Declare a variável b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Declare a variável c: ");
c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(a, 2) - (4 * a * c);
Console.WriteLine($"Delta é igual: {delta}.");

x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

Console.WriteLine($"O resultado da equação de Báskara envolvendo {a}, {b}, {c} é {x1} e {x2}");

Console.ReadKey();