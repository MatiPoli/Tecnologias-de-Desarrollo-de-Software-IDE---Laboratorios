using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int m_lado;

        public int Lado
        {
            get => default;
            set
            {
                Lado = 20;
            }
        }

        public int CalcularPerimetro()
        {
            return Lado * 3;
        }

        public double CalcularSuperficie()
        {
            double x = Math.Sqrt(Math.Pow(Lado, 2) - Math.Pow(Lado / 2, 2));
            return (x * Lado) / 2;
        }
    }
}