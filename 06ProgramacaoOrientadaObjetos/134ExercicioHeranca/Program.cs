namespace _134ExercicioHeranca;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
} 

public class Cliente
{
    public int Numero { get; set; }
    public string NomeCliente { get; set; }
}

public class ContaCorrente
{
    public void Depositar()
    {
        
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