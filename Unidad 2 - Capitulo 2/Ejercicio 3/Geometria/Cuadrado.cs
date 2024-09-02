using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        private int Lado;

        public int Ladoc
        {
            get => default;
            set
            {
                Ladoc = 20;
            }
        }
        public int CalcularPerimetro()
        {
            return Ladoc * 4;
        }

        public double CalcularSuperficie()
        {
            return Math.Pow(2, Ladoc);
        }
    }
}