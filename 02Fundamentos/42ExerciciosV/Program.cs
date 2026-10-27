Console.WriteLine("### Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no" +
                  "\nconsole se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)");

int x, y;             
Console.WriteLine("Digite um número inteiro: ");
x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite outro número inteiro: ");
y = Convert.ToInt16(Console.ReadLine());

var xpar = (x%2) == 0 ? "X é Par" : "X é Impar";
var ypar = (y%2) == 0 ? "Y é Par" : "Y é Impar";


Console.WriteLine($"{xpar}");
Console.WriteLine($"{ypar}");