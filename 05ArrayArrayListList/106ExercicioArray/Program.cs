Console.WriteLine("## Exercício Array ##");



string [] nomes = new string [5]; //Cria o array nome e define-o com 5 espaços
double [] notas = new double[5];
double media = 0.00D; //Sempre necessário iniciarlizar as variáveis com algum valor
double soma = 0.00D;

Console.WriteLine("Digite o nome dos alunos: \n");
for (int i = 0; i < nomes.Length; i++)
    {
        nomes[i] = Console.ReadLine();
    }

foreach (var nome in nomes )
    {
        Console.WriteLine($"Nome do aluno: {nome}");
    }

Console.WriteLine("\nDigite a nota dos alunos: \n"); //A separação entre o decimal nesse caso é com ','.

for (int j = 0; j < notas.Length; j++)
 {
        notas[j] = Convert.ToDouble(Console.ReadLine());
        soma = (soma + notas[j]);
 }

 foreach (var nota in  notas )
 {
     Console.WriteLine($"Nota do aluno: {nota}");
 }

    media = soma / 5;
    Console.WriteLine($"A média das notas é: {media}");