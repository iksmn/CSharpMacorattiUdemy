Console.WriteLine("Rodada Final");

Console.WriteLine("Informe a posição do clube na tabela: \t");
var posicao = Convert.ToInt16(Console.ReadLine());

if (posicao > 17)
{
    Console.WriteLine("Clube rebaixado para a série B.");
}
else if (17 >= posicao && posicao > 12)
{
    Console.WriteLine("Clube permanece na Série A mas não disputa competições internacionais.");
}
else if (12 >= posicao && posicao > 6)
{
    Console.WriteLine("Clube disputará a Sulamericana.");
}
else if (6 >= posicao && posicao >= 1)
{
    Console.WriteLine("Clube disputará a Libertadores da América.");
}

Console.WriteLine("Fim da análise.");
Console.ReadKey();