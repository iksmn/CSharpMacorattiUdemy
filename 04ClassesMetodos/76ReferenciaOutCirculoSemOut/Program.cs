Console.WriteLine(" ## Argumentos por referência - out ## ");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine()); //Necessário converter para 'double' pois o 'WriteLine' recece a informação como 'string'

Circulo circulo = new();

double perimetro = circulo.CalculaPerimetro(raio);
double area = circulo.CalculaArea(raio);

Console.WriteLine("Perímetro da Circunferência: " + perimetro);
Console.WriteLine("Área da Circunferência: " +  area);

Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();

public class Circulo
{
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    public double CalculaPerimetro(double raio)
    {
        double perimetro = Math.PI * raio * 2;
        return perimetro;
    }
}