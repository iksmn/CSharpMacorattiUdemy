namespace _133ModificadorsSealed2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Modificador de Metodos Sealed 2");

        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    class ClasseBase
    {
        protected virtual void Metodo1()
        {
            Console.WriteLine("ClasseBase.Metodo1()");
        }

        protected virtual void Metodo2()
        {
            Console.WriteLine("ClasseBase.Metodo2()");
        }
    }

    class Classe1 : ClasseBase
    {
        sealed protected override void Metodo1()//O atributo sealed impede que o método seja sobreescrito nas classes herdeiras
        {
            Console.WriteLine("Classe1.Metodo1()");
        }

        protected override void Metodo2()
        {
            Console.WriteLine("Classe1.Metodo2()");
        }
    }

    class Classe2 : Classe1
    {
        protected override void Metodo1()//Métodos herdado que não pode ser sobreescrito
        {
            Console.WriteLine("Classe2.Metodo1()");
        }

        protected override void Metodo2()
        {
            Console.WriteLine("Classe2.Metodo2()");

        }

    }

}    