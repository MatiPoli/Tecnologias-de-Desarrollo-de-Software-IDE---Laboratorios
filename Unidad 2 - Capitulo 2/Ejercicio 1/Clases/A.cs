namespace Clases
{
    public class A
    {
        protected string NombreInstancia;
        public A() { NombreInstancia = "Instancia sin nombre";  } 
        public A(string nom) { NombreInstancia = nom;  }

        public string MostrarNombre ()
        {
            return NombreInstancia;
        }
        public void M1 ()
        {
            Console.WriteLine("El método 1 fue convocado!");
        }
        public void M2()
        {
            Console.WriteLine("El método 2 fue convocado!");
        }
        public void M3()
        {
            Console.WriteLine("El método 3 fue convocado!");
        }
    }
}

