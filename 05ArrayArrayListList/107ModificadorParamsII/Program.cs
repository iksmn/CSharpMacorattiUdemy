Console.WriteLine("\nSoma de números inteiros utilizando array no método II\n");

int[] valores = { 1, 2, 3, 4, 5 };


var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(10, 20, 30, 40, 50);//Resultado da aplicação do modificador params
Console.WriteLine(resultado2);



Console.ReadKey();

public class Calcular
{
    public static int Soma(params int[] numeros)//O modificador 'params' permite usar os valores diretamente no método
                                                //Sem precisar criar um novo array para os valores.
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }

        return total;
    }
}