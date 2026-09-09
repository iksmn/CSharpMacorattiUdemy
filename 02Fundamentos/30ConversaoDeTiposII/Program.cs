Console.WriteLine("## Conversão de tipos ##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;


string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine($"{s3}\n\n");



int varInt = 10;
double varDouble = 5.35;
bool varBool = true;


Console.WriteLine(Convert.ToString(varInt));
Console.WriteLine(Convert.ToDouble(varInt));
Console.WriteLine(Convert.ToString(varBool));
Console.WriteLine(Convert.ToInt32(varDouble));

Console.ReadKey();