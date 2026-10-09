Console.WriteLine("## Operador Uniário e Ternário ##\n");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("\nInforme o número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultadoTemp = temp > 27 ? "Quente" : "Normal";
Console.WriteLine($"O tempo esta {resultadoTemp}");

Console.ReadKey();