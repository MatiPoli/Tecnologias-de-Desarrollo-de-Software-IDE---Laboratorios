using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private int m_lado;

        public int Lado1
        {
            get => default;
            set
            {
                Lado1 = 10;
            }
        }

        public int Lado2
        {
            get => default;
            set
            {
                Lado2 = 20;
            }
        }

        public int CalcularPerimetro()
        {
            return Lado2 * 2 + Lado1 * 2;
        }

        public int CalcularSuperficie()
        {
            return Lado2 * Lado1;
        }
    }

}