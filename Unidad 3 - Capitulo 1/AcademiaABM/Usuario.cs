namespace AcademiaABM
{
    using Clases;
    public partial class Usuario : Form
    {

        public Usuario()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            List<Empleado> Empleados = new List<Empleado>()
            {
                new Empleado(5431, "Juan", "Marquez", "jm1234", "asdasd@gmail.com", true),
                new Empleado(5211, "María", "Rodriguez", "mr1237", "supa@gmail.com", true),
                new Empleado(1231, "Carlos", "Urrutia", "cu5624", "tacataca@gmail.com", false),
                new Empleado(4212, "Lucía", "Godoy", "lg1246", "jhgfghfdg@gmail.com", true),
                new Empleado(5324, "Pedro", "Pacho", "pp6653", "jajajaja@gmail.com", false),
                new Empleado(6466, "Ana", "Rikitit", "ar9012", "expample@gmail.com", false),
                new Empleado(7122, "Luis", "Linaro", "ll8235", "sadhasd@gmail.com", true),
                new Empleado(8841, "Laura", "Jujujaja", "lj8235", "sampletext@gmail.com", true),
                new Empleado(9653, "Santiago", "Sapucai", "ss0845", "hfsda@gmail.com", false),
                new Empleado(1012, "Elena", "Marquez", "em7134", "chicho@gmail.com", true)              
            };
            DataGridViewRow row;
            int i = 0;
            foreach (var e in Empleados)
            {
                row = (DataGridViewRow)dgvUsuarios.Rows[i].Clone();
                row.Cells[0].Value = e.ID;
                row.Cells[1].Value = e.Nombre;
                row.Cells[2].Value = e.Apellido;
                row.Cells[3].Value = e.Usuario;
                row.Cells[4].Value = e.Email;
                row.Cells[5].Value = e.habilitado;
                dgvUsuarios.Rows.Add(row);
            }
            
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
