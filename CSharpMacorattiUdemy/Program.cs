Console.WriteLine("## Exercício ##");

Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro carro2 = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();

public class Carro
{
    public Carro(string modelo, string montadora, string nome, int ano, int potencia)
    {
        this.modelo = modelo; // Aqui atribuí-se o parâmetro 'modelo' à variável 'Modelo'
        this.montadora = montadora;
        this.nome = nome;
        this.ano = ano;
        this.potencia = potencia;
    }

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando...");
    }

    public string modelo;
    public string montadora;
    public string nome;
    public int ano;
    public int potencia;
}