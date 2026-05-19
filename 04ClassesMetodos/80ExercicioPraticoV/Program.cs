Console.WriteLine("## Exerício Prático V ##");



Carro carro01 = new();
Console.WriteLine("Digite o modelo do veículo: ");
carro01.Modelo = Console.ReadLine();
Console.WriteLine("Digite o nome da montadora: ");
carro01.Montadora = Console.ReadLine();
Console.WriteLine("Digite o nome do veículo: ");
carro01.Nome = Console.ReadLine();
Console.WriteLine("Digite a potência do veículo: ");
carro01.Potencia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ano do veículo: ");
carro01.Ano = Convert.ToInt32(Console.ReadLine());


carro01.ExibirInfo(carro01.Modelo, carro01.Montadora, carro01.Nome, carro01.Potencia, carro01.Ano);
carro01.ExibirInfo(carro01.Modelo, carro01.Montadora, carro01.Nome, carro01.Potencia); // Sem chamar o ano o valor exibido é o padrão
carro01.ExibirInfo(carro01.Modelo, carro01.Montadora, carro01.Nome, carro01.Potencia, ano : 9999); //Informando um ano aleatório caso necessário


Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();

public class Carro()
{
    public string Modelo;
    public string Montadora;
    public string Nome;
    public int Potencia;
    public int Ano;

    public void ExibirInfo(string modelo, string montadora, string nome, int potencia, int ano = 0000)
    {   
        Console.WriteLine($"Modelo do veículo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Potencia: {potencia} CVs");
        Console.WriteLine($"Ano: {ano}");
    }
}
