using System.Collections;

var lista = new ArrayList() {"Joaquina", 7, true};

int[] array1 = {1,2,3};

lista.AddRange(array1);

lista.InsertRange(2, array1);

Console.WriteLine("### ArrayList II - Parte 2###");
Console.ReadKey();