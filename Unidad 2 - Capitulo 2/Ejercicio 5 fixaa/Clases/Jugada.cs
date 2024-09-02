namespace Clases
{
    public class Jugada
    {
        protected int _Numero;
        protected int _CantIntentos;
        protected bool _Adivino;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _Numero = rnd.Next(maxNumero);
        }

        public int Numero
        {
            get
            {
                return _Numero;
            }
            set
            {
            }
        }
        public int CantIntentos
        {
            get
            {
                return _CantIntentos;
            }
            set
            {
                _CantIntentos = 0;
            }
        }

        public bool Adivino
        {
            get
            { return _Adivino; }
            set
            {
                _Adivino = false;
            }
        }

        public void Comparar(int num)
        {
            if (num == _Numero) { _Adivino = true; } else { _CantIntentos++; }
        }
    }
}