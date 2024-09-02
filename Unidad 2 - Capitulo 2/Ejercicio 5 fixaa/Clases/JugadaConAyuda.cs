using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

        new public void Comparar(int num)
        {
            if (num == _Numero) { _Adivino = true; } else 
            {
                if ((num - _Numero) >= 100)
                {
                    Console.WriteLine("El numero es mayor y esta muy lejos");
                }
                else if (Math.Abs(num - _Numero) <= 5)
                {
                    Console.WriteLine("El numero esta cerca");
                }
                _CantIntentos++; 
            }
        }
    }
}