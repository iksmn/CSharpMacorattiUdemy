Console.WriteLine("### Login com operador ternário ###");

Console.WriteLine("Digite o login: ");
string login = Console.ReadLine();
Console.WriteLine("\nDigite a senha: ");
int senha = Convert.ToInt16(Console.ReadLine());

bool sucesso = (senha == 123 && (login == "admin" || login == "maria"));

var resultado = sucesso == true ? "Login feito com sucesso!" : "Login inválido.";

Console.WriteLine($"{resultado}");

Console.ReadKey();  