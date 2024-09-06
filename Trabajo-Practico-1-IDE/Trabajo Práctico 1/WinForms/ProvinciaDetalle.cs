using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Práctico_1.Model;
using Trabajo_Práctico_1.Services;

namespace WinForms
{
    public partial class ProvinciaDetalle : Form
    {
        public ProvinciaDetalle()
        {
            InitializeComponent();
        }
        private Provincia provincia;

        public Provincia Provincia
        {
            get { return provincia; }
            set
            {
                provincia = value;
                this.SetProvincia();
            }
        }
        public bool EditMode { get; set; } = false;

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            ProvinciaService provService = new ProvinciaService();

            if (this.ValidateProvincia())
            {
                this.Provincia.Nombre = nombreTextBox.Text;


                if (this.EditMode)
                {
                    provService.Update(this.Provincia);
                }
                else
                {
                    provService.Add(this.Provincia);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetProvincia()
        {
            this.nombreTextBox.Text = this.Provincia.Nombre;
        }

        private bool ValidateProvincia()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es requerido");
            }
        
            return isValid;
        }

        private void ProvinciaDetalle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
