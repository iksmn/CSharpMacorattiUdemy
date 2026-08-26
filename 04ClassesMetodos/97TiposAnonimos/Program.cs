Console.WriteLine("## Tipos anônimos ##");

var autor = new
{
    Id = 1,
    Nome = "Tolkien",
    Email = "tolkien@lotr.co.uk",
    Endereco = new { Id = 1, Cidade = "Londres", País = "UK"}
};

Console.WriteLine(autor.GetType().ToString());

Console.WriteLine(autor.Nome + " " + autor.Email);
Console.WriteLine(autor.Endereco.Cidade);

var livros = new[]
{
    new { Id = 1, Titulo = "O morro dos ventos uivantes", Escritor = "Emily Bronte" },
    new { Id = 1, Titulo = "Contato", Escritor = "Carl Sagan" },
    new { Id = 1, Titulo = "Crônicas de Gelo e Fogo", Escritor = "George Martin" }
};


Console.WriteLine(livros[0].Escritor);
Console.WriteLine(livros[0].Titulo);

Console.ReadKey();