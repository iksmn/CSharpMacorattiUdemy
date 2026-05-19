Console.WriteLine(" ##Argumentos nomeados ## ");


Console.WriteLine("Informe o destino: ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo: ");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto: ");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar();
email.Enviar("teste@email.com", "Urgente", "Reunião de Orçamento");
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

//não posso fazer
//email.Enviar(destino, , assunto);//causa um erro
email.Enviar(destino, assunto: assunto); //Quando não souber um dos valores, utilizar argumentos nomeados


//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto:"Reunião de Orçamento");

Console.WriteLine("Pressione uma tecla para sair.");
Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino Padrão", string titulo = "Título Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}  