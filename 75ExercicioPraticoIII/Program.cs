Console.WriteLine("## Exercício Prático III ##");
Carro ev = new("Seal", "BYD");
int potencia = 150;
Console.WriteLine($"Veículo: {ev.Modelo} da montadora: {ev.Montadora}");
Console.WriteLine($"Velocidade Máxima = {ev.VelocidadeMaxima(potencia)} km/h");
Console.WriteLine($"Aumento de Potência = {ev.AumentarPotencia(potencia)} CVs");
Console.WriteLine($"Segundo aumento de Potência = {ev.AumentarPotencia(ref potencia)} VCs");



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
    //O método VelocidadeMaxima retorna uma variável 'double' após receber a variável int 'potencia'
    public double VelocidadeMaxima(int potencia) //Método (comportamento) da classe Carro com modificador de acesso 'public'
    {
        double velocidadeMaxima = 1.75;
        return (velocidadeMaxima * potencia); //O método retorna um valor double quando recebe a variável int 'potencia'
    }

    public int AumentarPotencia(int potencia)
    {
        int aumentarPotencia = 3;
        return (aumentarPotencia + potencia);
    }

    public int AumentarPotencia(ref int potencia)
    {
        int aumentarPotencia = 5;
        return (aumentarPotencia + potencia);
    }

}