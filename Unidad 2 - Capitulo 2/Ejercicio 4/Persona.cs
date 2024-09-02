using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Persona
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;
        private string _DNI;

        public Persona()
        {
            Console.WriteLine("Ingrese el nombre: ");
            _Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            _Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            _Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el DNI: ");
            _DNI = Console.ReadLine();
        }

        ~Persona()
        {
            Console.WriteLine("Se ha eliminado la persona.");
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {

            }
        }
        public string Apellido
        {
            get
            {
                return _Apellido;
            }
            set
            {

            }
        }
        public int Edad
        {
            get
            {
                return _Edad;
            }
            set
            {

            }
        }
        public string DNI
        {
            get
            {
                return _DNI;
            }
            set
            {

            }
        }

        public string GetFullName()
        {
            return _Nombre + _Apellido;
        }

        public void GetAge()
        {
            throw new System.NotImplementedException();
        }
    }
}