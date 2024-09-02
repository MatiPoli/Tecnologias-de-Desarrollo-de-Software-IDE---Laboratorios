
string[] lista;
lista = new string[5];
int cantInteraciones = 5;

for (int i = 0; i < cantInteraciones; i++)
    {
        Console.WriteLine("Ingrese la posicion (" + i + "): ");
        lista[i] = Console.ReadLine();
    }

Console.WriteLine("\n\nLa lista es: \n");
for (int i = cantInteraciones - 1; i >= 0; i--)
    Console.WriteLine(lista[i]);

