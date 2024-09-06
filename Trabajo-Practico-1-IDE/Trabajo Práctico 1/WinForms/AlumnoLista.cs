using Trabajo_Práctico_1.Model;
using Trabajo_Práctico_1.Services;
using WindowsForms;

namespace WinForms
{
    public partial class AlumnoLista : Form
    {
        public AlumnoLista()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AlumnoDetalle alumnoDetalle = new AlumnoDetalle();

            Alumno alumno = new Alumno();

            alumnoDetalle.Alumno = alumno;

            alumnoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            AlumnoDetalle alumnoDetalle = new AlumnoDetalle();
            UniversidadService uniService = new UniversidadService();
            int Id;

            Id = this.SelectedItem().Id;

            Alumno alumno = uniService.Get(Id);

            alumnoDetalle.EditMode = true;
            alumnoDetalle.Alumno = alumno;

            alumnoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            UniversidadService uniService = new UniversidadService();
            int Id;

            Id = this.SelectedItem().Id;
            uniService.Remove(Id);

            this.GetAllAndLoad();
        }
        private Alumno SelectedItem()
        {
            Alumno alumno;

            alumno = (Alumno)alumnosDataGridView.SelectedRows[0].DataBoundItem;

            return alumno;
        }

        private void AlumnoLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void GetAllAndLoad()
        {
            UniversidadService uniService = new UniversidadService();

            this.alumnosDataGridView.DataSource = null;
            this.alumnosDataGridView.DataSource = uniService.GetAll();

            if (this.alumnosDataGridView.Rows.Count > 0)
            {
                this.alumnosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private void alumnosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void provinciasButton_Click(object sender, EventArgs e)
        {
            ProvinciaLista provinciaLista = new ProvinciaLista();
            provinciaLista.Show();
        }
    }
}
