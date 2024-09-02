using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Clases;
using System.Linq.Expressions;
// 1)
/*
List<string> Provincias = new List<string>();
Provincias.Add("Buenos Aires");
Provincias.Add("Ciudad Autonoma de Buenos Aires");
Provincias.Add("Catamarca");
Provincias.Add("Chaco");
Provincias.Add("Chubut");
Provincias.Add("Cordoba");
Provincias.Add("Corrientes");
Provincias.Add("Entre Rios");
Provincias.Add("Formosa");
Provincias.Add("Jujuy");
Provincias.Add("La Pampa");
Provincias.Add("La Rioja");
Provincias.Add("Neuquen");
Provincias.Add("Misiones");
Provincias.Add("Mendoza");
Provincias.Add("Rio Negro");
Provincias.Add("Salta");
Provincias.Add("San Juan");
Provincias.Add("San Luis");
Provincias.Add("Santa Cruz");
Provincias.Add("Santa Fe");
Provincias.Add("Santiago del Estero");
Provincias.Add("Tierra del Fuego, Antartida e Islas del Atlantico Sur");
Provincias.Add("Tucuman");

var listaPedida = from c in Provincias where c.StartsWith("S") || c.StartsWith("T") select c;
foreach (var p in listaPedida)
    Console.WriteLine(p);
*/

// 2)
/*
List<int> listaInt = new List<int> { 1,2,3,4,5,200,123,35,2,132,20,123,3};
var listaIntPedida = from i in listaInt where i > 20 select i;
foreach (var i in listaIntPedida)
    Console.WriteLine(i);
*/

// 3)
/*
List<Ciudad> Ciudades = new List<Ciudad>() { new Ciudad("Rosario",2000) , new Ciudad("Arteaga", 2187), new Ciudad("Bustinza", 2501), new Ciudad("Cañada Rica", 2105), new Ciudad("El Bonete", 3550), new Ciudad("Colmena", 3550),new Ciudad("Rosales", 6128), new Ciudad("Amenabar", 6103), new Ciudad("Rufino", 6100), new Ciudad("Solale", 6064)};
string expresion = Console.ReadLine();

var listaCiudadPedida = from c in Ciudades where c.Nombre.ToLower().Contains(expresion) select c;

foreach (var c in listaCiudadPedida)
{
    Console.WriteLine(c.Nombre + " " + c.CodPostal);
}
*/

// 4)

List<Empleado> Empleados = new List<Empleado>()
{
    new Empleado(5431, "Juan", 2500.50f),
    new Empleado(5211, "María", 2800.75f),
    new Empleado(1231, "Carlos", 2200.30f),
    new Empleado(4212, "Lucía", 3000.00f),
    new Empleado(5324, "Pedro", 2400.80f),
    new Empleado(6466, "Ana", 2600.25f),
    new Empleado(7122, "Luis", 2900.60f),
    new Empleado(8841, "Laura", 2700.9f),
    new Empleado(9653, "Santiago", 3100.7f),
    new Empleado(1012, "Elena", 2300.40f)
};
var listaEmpleadoPedida = from e in Empleados orderby e.Sueldo select e;
//var lista = Empleados.OrderBy(e => e.Sueldo);
foreach (var e in listaEmpleadoPedida)
{
    Console.WriteLine(e.ID + " " + e.Nombre + " " + e.Sueldo);
}

Console.WriteLine();

var listaEmpleadoPedida2 = Empleados.OrderByDescending(e => e.Sueldo);
foreach (var e in listaEmpleadoPedida2)
{
    Console.WriteLine(e.ID + " " + e.Nombre + " " + e.Sueldo);
}
