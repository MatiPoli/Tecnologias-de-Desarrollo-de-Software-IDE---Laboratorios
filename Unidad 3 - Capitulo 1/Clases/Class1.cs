namespace Clases
{
    public class Empleado
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _usuario;
        private string _email;
        private bool _habilitado;


        public int ID { get { return _id; } set { } }
        public string Nombre { get { return _nombre; } set { } }
        public string Apellido { get { return _apellido; } set { } }
        public string Usuario { get { return _usuario; } set { } }
        public string Email { get { return _email; } set { } }
        public bool habilitado { get { return _habilitado; } set { } }
        public Empleado(int id, string nombre, string apellido, string usuario, string email, bool habilitado)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _usuario = usuario;
            _email = email;
            _habilitado = habilitado;
        }
    }
}
