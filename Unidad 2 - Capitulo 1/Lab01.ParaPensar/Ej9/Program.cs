
Console.WriteLine("Ingrese cantidad de filas:");
int cant = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int cont = 1;
for (int i = cant; i > 0; i--)
{
    Console.Write("\t");
    for (int j = 0; j < i - 1; j++)
        Console.Write(" ");
    for (int k = 0; k < (cont * 2 - 1); k++)
        Console.Write("*");
    Console.Write("\n");
    cont++;
}

/*
   *
  ***
 *****
*******
*/