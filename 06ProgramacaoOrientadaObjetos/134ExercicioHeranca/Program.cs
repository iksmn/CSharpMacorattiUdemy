namespace _134ExercicioHeranca;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Programa de Contas Bancárias");
        
        
        Cliente cliente1 = new();
        cliente1.NomeCliente = "Adalberto";
        cliente1.Numero = 333;

        Console.WriteLine($"O cliente é {cliente1.NomeCliente}, o número da conta é {cliente1.Numero}");
    }
    

} 

public class Cliente
{
    public int Numero { get; set; }
    public string NomeCliente { get; set; }
}

public class ContaCorrente
{

    public double Saldo = 0;
    public double Rendimento = 0.5;
    public double Taxa = 0.9;
    public double Imposto = 0.1;
    public double Depositar(double  deposito)
    {
        return deposito +  Saldo;
    }

    public void Sacar()
    {
        
    }

    public void ExibirSaldo()
    {
        
    }
    
}

public class ContaPoupanca : ContaCorrente
{
    
}

public class ContaInvestimento : ContaCorrente
{
    
}