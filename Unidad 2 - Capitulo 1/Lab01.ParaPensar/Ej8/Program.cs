
using System.Linq.Expressions;

int intentos = 0;
string clave = "papamama", input;
bool cond = true;

while (cond)
{
    if (intentos < 4)
    {
        intentos++;
        Console.WriteLine("Ingrese la clave:");
        input = Console.ReadLine();
        if (input == clave)
        {
            cond = false;
            Console.WriteLine("Clave Correcta");
        }
        else
        { Console.WriteLine("Clave incorrecta.\n"); }
    }
    else { cond = false; }
}