
Console.WriteLine("Ingrese el año:");
int año = Convert.ToInt32(Console.ReadLine());

if (año % 400 == 0)
    Console.WriteLine("\nEs bisiesto");
else if (año % 4  == 0 && año % 100 !=0)
    Console.WriteLine("\nEs bisiesto");
else
    Console.WriteLine("\nNo es bisiesto");