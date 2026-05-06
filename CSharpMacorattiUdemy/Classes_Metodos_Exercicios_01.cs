/*1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
potencia com os tipos de dados string, string, string, int e int.
Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110

b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
    para cada objeto

d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.
    
e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)

f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
método Acelerar passando o valor do argumento para o parâmetro no método Acelerar
Obs- Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os
membros da classe*/


////////// PONTOS A, B e C //////////


/*Console.WriteLine("## Exercício ##");

Carro chevrolet = new Carro(); //Objeto chevrolet da classe Carro
chevrolet.modelo = "Sedan";
chevrolet.montadora = "Chevrolet";
chevrolet.nome = "Onix";
chevrolet.ano = 2016;
chevrolet.potencia = 110;

Carro ford = new();
ford.modelo = "SUV";
ford.montadora = "Ford";
ford.nome = "EcoSport";
ford.ano = 2018;
ford.potencia = 120;

//Necessário o elemento '$' para poder usar as variáveis no print
Console.WriteLine($"{chevrolet.modelo}, {chevrolet.montadora}, {chevrolet.nome}, Ano {chevrolet.ano}, {chevrolet.potencia} CV");
chevrolet.Acelerar();

Console.WriteLine($"{ford.modelo}, {ford.montadora}, {ford.nome}, Ano {ford.ano}, {ford.potencia} CV");
ford.Acelerar();

Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();

public class Carro //Classe Carro
{
    public string modelo;
    public string montadora;
    public string nome;
    public int ano;
    public int potencia;

    public void Acelerar()
    {
        Console.WriteLine("Acelerando..."); //Método que representa um comportamento
    }
}*/

/*Console.WriteLine("## Exercício ##");////////////////////////////////////////////////////////////////////////////////

Carro chevrolet = new Carro(); //Objeto chevrolet da classe Carro
chevrolet.modelo = "Sedan";
chevrolet.montadora = "Chevrolet";
chevrolet.nome = "Onix";
chevrolet.ano = 2016;
chevrolet.potencia = 110;

Carro ford = new();
ford.modelo = "SUV";
ford.montadora = "Ford";
ford.nome = "EcoSport";
ford.ano = 2018;
ford.potencia = 120;

//Necessário o elemento '$' para poder usar as variáveis no print
Console.WriteLine($"{chevrolet.modelo}, {chevrolet.montadora}, {chevrolet.nome}, Ano {chevrolet.ano}, {chevrolet.potencia} CV");
chevrolet.Acelerar();

Console.WriteLine($"{ford.modelo}, {ford.montadora}, {ford.nome}, Ano {ford.ano}, {ford.potencia} CV");
ford.Acelerar();

Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();

public class Carro //Classe Carro
{
    public string modelo;
    public string montadora;
    public string nome;
    public int ano;
    public int potencia;

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando meu {nome}"); //Método que representa um comportamento
    }
}*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*Console.WriteLine("## Exercício ##");

Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro carro2 = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();

public class Carro
{
    public Carro(string modelo, string montadora, string nome, int ano, int potencia)
    {
        this.modelo = modelo; // Aqui atribuí-se o parâmetro 'modelo' à variável 'Modelo'
        this.montadora = montadora;
        this.nome = nome;
        this.ano = ano;
        this.potencia = potencia;
    }

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando...");
    }

    public string modelo;
    public string montadora;
    public string nome;
    public int ano;
    public int potencia;
}*/