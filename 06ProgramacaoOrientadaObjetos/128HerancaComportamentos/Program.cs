namespace _128HerancaComportamentos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ClasseDerivada cd = new();
        cd.VerificaAcesso();
        
        
        Console.ReadKey();
    }


    public class ClasseDerivada : ClasseBase
    {
        
        public void VerificaAcesso()
        {
            Public_Membro();
            Protected_Membro();
            Protected_Internal_Membro();
            Internal_Membro();
            //Private_Membro();
            
            Console.WriteLine("\nAcesso ao campo private: private_var usando uma propriedade GET");
            int soma = public_var + protected_var + internal_var + Private_var;
            Console.WriteLine("Total soma :  " + soma);
            
            //Não é possível acessar diretamente o método Private_Membro()
            //Mas é possível acessar o método Private_var, pois mesmo que ele retorne um private, seu acesso é público
        }
    }


    public class ClasseBase
    {
        
        //campos
        public int public_var = 1;
        protected int protected_var = 2;
        internal int internal_var = 3;
        private int private_var = 4;
        
        //propriedade
        public int Private_var
        {
            get { return private_var; }
            set { private_var = value; }
        }
        
        
        public void Public_Membro()
        {
            Console.WriteLine("ClasseBase - Método Public_Membro");
        }

        protected void Protected_Membro()
        {
            Console.WriteLine("ClasseBase - Método Protected");
        }

        internal void Internal_Membro()
        {
            Console.WriteLine("ClasseBase - Internal");
        }

        protected internal void Protected_Internal_Membro()
        {
            Console.WriteLine("ClasseBase - Método protected internal");
        }

        private void Private_Membro()
        {
            Console.WriteLine("ClasseBase - Método Private");
        }
        
    }
    
}