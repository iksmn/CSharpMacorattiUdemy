Console.WriteLine("## Conversão de tipos ##");

int varInt = 100;
double varDouble = varInt;

//byte = 1 byte
//short = 2 bytes
//int = 4 bytes
//long = 8 bytes
//float = 4 bytes
//double = 8 bytes
//decimal = 16 bytes


Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroInt);
Console.WriteLine(numeroInt);
Console.WriteLine(numeroInt);
Console.WriteLine(numeroInt);


double varDouble2 = 12.456;
int varInt2 = (int)varDouble2;

Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2;

Console.WriteLine(resultado);

Console.ReadKey();