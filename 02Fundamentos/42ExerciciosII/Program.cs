Console.WriteLine("Escreva um programa para receber dois valores via teclado do tipo double e a seguir" +
                  "\nrealize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo" +
                  "\nexibindo o resultado:");

double x, y;
Console.WriteLine("\nDigite o primeiro número: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nDigite o segundo número: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A soma dos valores {x} e {y} é {x+y}.");
Console.WriteLine($"A subtração dos valores {x} e {y} é {x-y}.");
Console.WriteLine($"A multiplicação dos valores {x} e {y} é {x*y}.");
Console.WriteLine($"A divisão dos valores {x} e {y} é {x/y}.");
Console.WriteLine($"A exponenciação dos valores {x} e {y} é {Math.Pow(x,y)}.");
Console.WriteLine($"O módulo dos valores {x} e {y} é {x%y}.");
                  
                  
                  
                  