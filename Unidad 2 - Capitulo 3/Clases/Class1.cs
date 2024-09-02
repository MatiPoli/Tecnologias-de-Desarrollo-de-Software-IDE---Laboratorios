namespace Clases
{
    public class Ciudad
    {
        private string _nombre;
        private int _codPostal;

        public Ciudad(string a, int b)
        {
            _nombre = a;
            _codPostal = b;
        }

        public string Nombre
        {  
            get 
            { 
                return _nombre; 
            } 
            set 
            {
                _nombre = value;
            } 
        
        }
        public int CodPostal
        {
            get
            {
                return _codPostal;
            }
            set
            {
                _codPostal = value;
            }

        }

    }

    public class Empleado
    {
        private int _id;
        private string _nombre;
        private float _sueldo;

        public int ID { get { return _id; } set { } }
        public string Nombre { get { return _nombre; } set { } }
        public float Sueldo { get { return _sueldo; } set { } }

        public Empleado(int id, string nombre, float sueldo)
        {
            _id = id;
            _nombre = nombre;
            _sueldo = sueldo;
        }
    }
}
