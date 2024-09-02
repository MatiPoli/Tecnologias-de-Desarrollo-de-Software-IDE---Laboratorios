using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => default;
            set
            {
                Radio = 20;
            }
        }
        public const double PI = 3.1415926535897931;

        public double CalcularPerimetro()
        {
            return 2 * PI * Radio;
        }

        public double CalcularSuperficie()
        {
            return PI * Math.Pow(Radio, 2);
        }
    }
}
