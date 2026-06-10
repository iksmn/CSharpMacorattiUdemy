// criar os arrays
using System;



string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("### Alunos ###");

for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Informe o nome do Aluno: ");
        string? nome = Console.ReadLine();
        nomes[i] = nome;
    }

for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Informe a nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());
        notas[i] = nota;
    }


Console.WriteLine("Alunos: ");
foreach (string nome in nomes)
    {
        Console.Write($"{nome} ");
    }


Console.WriteLine("\nNotas: ");
var somaNotas = 0.0;
var totalNotas = notas.Count();//O método 'Count' conta o número de elementos no array.
foreach (double nota in notas)
    {
        somaNotas += nota;
        Console.Write($"{nota} ");
    }    
    
Console.WriteLine($"\nMédia Aritmética: \n {somaNotas/totalNotas}");

Console.ReadKey();    