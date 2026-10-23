Console.WriteLine("### Login com operador ternário ###");

Console.WriteLine("Digite o login: ");
string login = Console.ReadLine();
Console.WriteLine("\nDigite a senha: ");
int senha = Convert.ToInt16(Console.ReadLine());

int senhaCorreta = 123;

sucesso = senha == senhaCorreta ?  