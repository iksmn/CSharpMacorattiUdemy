Console.WriteLine("Escreva um programa que solicite a temperatura em graus Celsius e converta para\nKelvin e Farhenheit");


double c, f, k;

Console.WriteLine("Digite o valor da temperatura em Celsius: ");
c = Convert.ToDouble(Console.ReadLine());

k = c + 273;
f = (c * 9)/5 + 32;

Console.WriteLine($"O valor da temperatura {c} Celsius é {f} em Farhenheit e {k} Kelvin.");

Console.ReadKey();