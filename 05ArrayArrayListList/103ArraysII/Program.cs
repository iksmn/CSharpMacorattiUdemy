// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


//Declaração de Array
int[] numeros;
        
//Alocação de memória
numeros = new int[10] {1,2,3,4,5,6,7,8,9,70};

string[] nomes = new string[5] { "Aida", "Vitoria", "Ayla", "Eduarda", "Astarte" };


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
}

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Nomes no índice {i} : {nomes[i]}");
} 