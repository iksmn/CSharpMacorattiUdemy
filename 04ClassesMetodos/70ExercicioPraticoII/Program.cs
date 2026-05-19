Console.WriteLine("## Exercício Prático II ##");
Carro ev = new("Seal", "BYD");
Console.WriteLine($"Veículo: {ev.Modelo} da montadora: {ev.Montadora}");
Console.WriteLine($"Velocidade Máxima = {ev.VelocidadeMaxima(150)} km/h");


Console.WriteLine("Pressione uma tecla para sair.");
Console.ReadKey();

public class Carro // Classe Carro com modificador de acesso 'public'
{
    public string Modelo; //Atributos da classe com modificador de acesso 'public'
    public string Montadora; //Atributos da classe com modificador de acesso 'public'
    public int potencia; //Atributos da classe com modificador de acesso 'public'


    public Carro(string modelo, string montadora) //Construtor com modificador de acesso 'public'
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    //O método VelocidadeMaxima retorna uma variável 'double' após receber a variável int 'potencia'
    public double VelocidadeMaxima(int potencia) //Método (comportamento) da classe Carro com modificador de acesso 'public'
    {
        double velocidadeMaxima = 1.75;
        return (velocidadeMaxima * potencia); //O método retorna um valor double quando recebe a variável int 'potencia'
    }

}