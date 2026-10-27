Console.WriteLine("12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no" +
                  "\nconsole o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)");

Console.WriteLine("Digite o valor inteiro de x: ");
int x = Convert.ToInt32(Console.ReadLine());
const double pi = 3.1415;

Console.WriteLine($"O resultado de -6 + x * 5 = {-6 + x * 5}");
Console.WriteLine($"O resultado de (13 - 2) * x = {(13 - 2 ) * x}");
Console.WriteLine($"O resultado de ( x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
Console.WriteLine($"O resultado de (12 + x) / (x - 4) = {(12 + x) / (x - 4)}");
Console.WriteLine($"O resultado de 3x^2 + x + 10 = {(3*(Math.Pow(x, 2)) )+ x +10}");
Console.WriteLine($"O resultado de pi * x^2 = {pi * Math.Pow(x, 2)}");





Console.ReadKey();