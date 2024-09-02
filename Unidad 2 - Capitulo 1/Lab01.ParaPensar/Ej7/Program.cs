
using static System.Net.Mime.MediaTypeNames;
using System;

Console.WriteLine("Ingrese la cantidad: ");
int cant = Convert.ToInt32(Console.ReadLine());
int cont = 0;

Console.WriteLine("\nLos " + cant + " primeros numeros primos gemelos son:");
for (int i = 0; i < cant; i++)
{
    cont = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            cont++;
        }
    }
    if (cont == 2)
    {
        cont = 0;
        for (int j = 1; j <= i+2; j++)
        {
            if ((i+2) % j == 0)
            {
                cont++;
            }
        }
        if (cont == 2)
        {
            Console.WriteLine( i + " y " + (i + 2));
        }
    }
}

