Console.WriteLine("## Exercício Prático IV ##");
int potencia = 150;
double velocidadeOriginal = 140;

Console.WriteLine("Potência original: " + potencia + " CVs");
Console.WriteLine("Velocidade máxima original: " + velocidadeOriginal + " km/h");

Carro carro01 = new("Impreza", "Subaru");
double incrementoPotecia = carro01.AumentarPotenciaVelocidade(potencia, out  double velocidade);


Console.WriteLine("Montadora do veículo: " + carro01.Montadora);
Console.WriteLine("Modelo do veículo: " + carro01.Modelo);


Console.WriteLine("Nova potência: " + incrementoPotecia + " CVs");
Console.WriteLine("Velocidade máxima atualizada: " + velocidade +  " km/h");

Console.WriteLine("Pressione uma tecla para sair.");
Console.ReadKey();

public class Carro // Classe Carro com modificador de acesso 'public'
{
    public string Modelo; //Atributos da classe com modificador de acesso 'public'
    public string Montadora; //Atributos da classe com modificador de acesso 'public'
    //public int potencia; //Atributos da classe com modificador de acesso 'public'


    public Carro(string modelo, string montadora) //Construtor com modificador de acesso 'public'
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public double AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        int incrementoPotencia = potencia + 7;
        velocidade = potencia * 1.75;
        return incrementoPotencia;
    }

}