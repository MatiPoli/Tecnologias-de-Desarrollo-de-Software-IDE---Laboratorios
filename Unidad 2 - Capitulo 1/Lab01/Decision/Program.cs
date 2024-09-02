
string inputTexto;
Console.WriteLine("Ingrese un texto: ");
inputTexto = Console.ReadLine();

/*
if (inputTexto != null)
    Console.WriteLine(inputTexto);
else Console.WriteLine("No se asignó el texto");
 */

Console.WriteLine("\nMENU\n1) Mostrar en mayúsculas.\n2) Mostrar en minúsculas.\n3) Mostrar cantidad de caracteres \nIngrese opcion: ");
ConsoleKeyInfo opcion = Console.ReadKey();

if (opcion.Key == ConsoleKey.D1)
    Console.WriteLine("\n\nTexto resultado: " + inputTexto.ToUpper());
else if (opcion.Key == ConsoleKey.D2)
    Console.WriteLine("\n\nTexto resultado: " + inputTexto.ToLower());
else if (opcion.Key == ConsoleKey.D3)
    Console.WriteLine("\n\nLargo del texto: " + inputTexto.Length);
else Console.WriteLine("\n\nOpcion incorrecta!");

/*
switch (opcion.Key)
{
    case ConsoleKey.D1:
        Console.WriteLine("\n\nTexto resultado: " + inputTexto.ToUpper());
        break;

    case ConsoleKey.D2:
        Console.WriteLine("\n\nTexto resultado: " + inputTexto.ToLower());
        break;

    case ConsoleKey.D3:
        Console.WriteLine("\n\nLargo del texto: " + inputTexto.Length);
        break;
    default:
        Console.WriteLine("\n\nOpcion incorrecta!");
        break;
}
*/