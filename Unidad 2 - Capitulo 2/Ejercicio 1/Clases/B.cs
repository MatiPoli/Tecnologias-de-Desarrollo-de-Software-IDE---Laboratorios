using Clases;

public class B : A
{
    public B() : base("Instancia de B") { }
    public void M4()
    {
        Console.WriteLine("Método del hijo Invocado");
    }
}