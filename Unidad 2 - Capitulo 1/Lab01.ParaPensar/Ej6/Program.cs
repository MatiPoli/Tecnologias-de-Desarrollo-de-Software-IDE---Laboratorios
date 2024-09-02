
Console.WriteLine("Ingrese un número (Entre 0 y 399):");
int numero = Convert.ToInt32(Console.ReadLine());
string numRomano = "";
string[] letrasRom = { "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
int[] numeros = { 100, 90, 50, 40, 10, 9, 5, 4, 1 };

int cont = 0;
while (numero != 0)
{
    if(numero >= numeros[cont])
    {
        numero -= numeros[cont];
        numRomano += letrasRom[cont];
    }
    else
    {
        cont++;
    }
}

Console.WriteLine("El numero en romano es: " + numRomano);
