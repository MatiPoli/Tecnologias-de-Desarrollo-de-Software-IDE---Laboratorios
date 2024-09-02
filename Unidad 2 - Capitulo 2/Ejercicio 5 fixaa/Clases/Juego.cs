using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Juego
    {
        private int _Record = 0;
        public void ComenzarJuego()
        {
            int opc = -1;
            while (opc != 3)
            {
                Console.Clear();
                Console.WriteLine("MENU DEL JUEGO");
                Console.WriteLine("1 - Nuevo juego");
                Console.WriteLine("2 - Ver record");
                Console.WriteLine("3 - Terminar");
                Console.WriteLine("Ingrese opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        NuevoJuego();
                        Continuar();
                        break;
                    case 2:
                        Console.WriteLine("El record es: " + _Record);
                        Continuar();
                        break;
                    case 3:
                        Continuar();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta!");
                        Continuar();
                        break;
                }
            }
        }

        public void Continuar()
        {
            Console.WriteLine("Presione una tecla para continuar . . .");
            Console.ReadKey();
        }
        public void NuevoJuego()
        {
            JugadaConAyuda jug = new JugadaConAyuda(PreguntarMaximo());
            while (jug.Adivino == false)
            {
                jug.Comparar(PreguntarNumero());
                if (jug.Adivino == false)
                {
                    Console.WriteLine("Numero ingresado incorrecto, intente nuevamente.");
                }
            }
            Console.WriteLine("Numero adivinado!");
            CompararRecord(jug.CantIntentos);
        }
        public void CompararRecord(int cant)
        {
            if (cant < _Record || _Record == 0)
            {
                _Record = cant;
                Console.WriteLine("Nuevo record!");
            }
        }
        public int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese el maximo:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int PreguntarNumero()
        {
            Console.WriteLine("Ingrese el numero:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}