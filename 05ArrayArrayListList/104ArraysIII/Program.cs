// See https://aka.ms/new-console-template for more information

Console.WriteLine("## Array e ForEach ##");

//Declaração de Array
int[] numeros;
        
//Alocação de memória
numeros = new int[10] {1,2,3,4,5,6,7,8,9,70};

string[] nomes = new string[5] { "Aida", "Vitoria", "Ayla", "Eduarda", "Astarte" };



int i = 0;
foreach (int item in numeros)
{
    Console.WriteLine($"Espaço alocado: {i}, valor alocado {item}");
    i++;
}


foreach (var nome in nomes)
{
    Console.WriteLine($"Nomes no array: {nome}");
}

Console.ReadKey();