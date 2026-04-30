Console.WriteLine("## Classes e Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();
MinhaClasse meuObjeto = new MinhaClasse();
//valores dos argumentos
minhaClasse.Saudacao("Engels", DateTime.Now.ToLongDateString());
meuObjeto.Saudacao("Ho Chi Min", DateTime.Now.ToLongTimeString());


Console.ReadKey();


public class MinhaClasse
{
    //parâmetros do método
    public void Saudacao(string nome, string data) 
    {
        Console.WriteLine(nome);
        Console.WriteLine(data); 
    }
}