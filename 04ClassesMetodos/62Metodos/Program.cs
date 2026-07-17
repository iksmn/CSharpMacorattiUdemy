Console.Write("## Métodos ##\n");


MinhaClasse minhaClasse = new MinhaClasse();


minhaClasse.Saudacao();
minhaClasse.ExibirDataAtual();

Console.ReadKey();


class MinhaClasse
{
    
    //Métodos informam seu retorno (saída), no caso de 'void' não existe retorno.
    public void Saudacao()
    {
        Console.WriteLine("Bienvenue!");
        Console.WriteLine("14/07/2026");
        Copa(); //É possível chamar um método dentro de outro método.
    }
     
    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }

    public void Copa()
    {
        Console.WriteLine("Haaland joga muito, Mbappé também, mas R10 é o maior!");
    }
}