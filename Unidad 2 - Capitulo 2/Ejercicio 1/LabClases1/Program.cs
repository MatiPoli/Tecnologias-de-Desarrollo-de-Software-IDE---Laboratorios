using Clases;

A instanciaA = new();
B instanciaB = new();

Console.WriteLine("Nombre default A: " + instanciaA.MostrarNombre());
Console.WriteLine("Nombre default B: " + instanciaB.MostrarNombre());

Console.WriteLine("Metodos de A:");
instanciaA.M1();
instanciaA.M2();
instanciaA.M3();

Console.WriteLine("Metodos de B:");
instanciaB.M1();
instanciaB.M2();
instanciaB.M3();
instanciaB.M4();
