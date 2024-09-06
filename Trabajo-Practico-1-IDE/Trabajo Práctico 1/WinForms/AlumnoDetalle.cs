using Trabajo_Práctico_1.Model;
using Trabajo_Práctico_1.Services;


namespace WindowsForms
{
    public partial class AlumnoDetalle : Form
    {
        private Alumno alumno;
        private IEnumerable<Provincia> provincias;

        public Alumno Alumno
        {
            get { return alumno; }
            set
            {
                alumno = value;
                this.SetAlumno();
            }
        }
        public bool EditMode { get; set; } = false;

        public AlumnoDetalle()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            UniversidadService uniService = new UniversidadService();

            if (this.ValidateAlumno())
            {
                this.Alumno.Nombre = nombreTextBox.Text;
                this.Alumno.Apellido = apellidoTextBox.Text;
                this.Alumno.Legajo = legajoTextBox.Text;
                this.Alumno.Direccion = direccionTextBox.Text;
                this.Alumno.ProvinciaID = this.provincias.ElementAt(provinciaBox.SelectedIndex).Id;

                if (this.EditMode)
                {
                    uniService.Update(this.Alumno);
                }
                else
                {
                    uniService.Add(this.Alumno);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAlumno()
        {
            if (this.EditMode)
            {
                ProvinciaService provService = new ProvinciaService();
                this.apellidoTextBox.Text = this.Alumno.Apellido;
                this.nombreTextBox.Text = this.Alumno.Nombre;
                this.legajoTextBox.Text = this.Alumno.Legajo;
                this.direccionTextBox.Text = this.Alumno.Direccion;          
                this.provinciaBox.Text = provService.Get(this.Alumno.ProvinciaID).Nombre;
            }
        }

        private bool ValidateAlumno()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            errorProvider.SetError(legajoTextBox, string.Empty);
            errorProvider.SetError(direccionTextBox, string.Empty);
            errorProvider.SetError(provinciaBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es requerido");
            }

            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "El Apellido es requerido");
            }

            if (this.legajoTextBox.Text.Length != 5)
            {
                isValid = false;
                errorProvider.SetError(legajoTextBox, "El Legajo tiene un largo incorrecto");
            }

            if (this.legajoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(legajoTextBox, "El Legajo es requerido");
            }

            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "La Direccion es requerida");
            }

            if (this.provinciaBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(provinciaBox, "La Provincia es requerida");
            }
            else if (this.provinciaBox.SelectedIndex == -1)
            {
                isValid = false;
                errorProvider.SetError(provinciaBox, "La Provincia no existe");
            }
            return isValid;
        }

        private void AlumnoDetalle_Load(object sender, EventArgs e)
        {
            ProvinciaService provService = new ProvinciaService();

            this.provincias = provService.GetAll();
            foreach (Provincia provincia in this.provincias)
            {
                this.provinciaBox.Items.Add(provincia.Nombre);
            }

        }
    }
}
