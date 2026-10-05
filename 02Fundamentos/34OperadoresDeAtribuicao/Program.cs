Console.WriteLine("### Operadores de Atribuição ###");

//usando operadores de atribuição com tipos numéricos
var x = 10;
x = 20;

Console.WriteLine($"Valor inicial de x ={x}");
Console.WriteLine($"x+=5 ==> {x += 5}");
Console.WriteLine($"x-=5 ==> {x -= 3}");
Console.WriteLine($"x+=5 ==> {x *= 4}");
Console.WriteLine($"x/=5 ==> {x /= 5}");
Console.WriteLine($"x%=5 ==> {x %= 5}");


//usando operadores de atribuição com string
string y = "123";
Console.WriteLine($"\nValor inicial de y = {y}");

y += "456";

Console.WriteLine($"y+=\"456\" ==> {y}");
Console.ReadKey();
