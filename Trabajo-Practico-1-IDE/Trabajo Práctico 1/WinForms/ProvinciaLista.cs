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
    public partial class ProvinciaLista : Form
    {
        public ProvinciaLista()
        {
            InitializeComponent();
        }

        private void ProvinciaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ProvinciaDetalle provinciaDetalle = new ProvinciaDetalle();

            Provincia provincia = new Provincia();

            provinciaDetalle.Provincia = provincia;

            provinciaDetalle.ShowDialog();
             
            this.GetAllAndLoad();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            ProvinciaDetalle provinciaDetalle = new ProvinciaDetalle();
            ProvinciaService provService = new ProvinciaService();
            int Id;

            Id = this.SelectedItem().Id;

            Provincia provincia = provService.Get(Id);

            provinciaDetalle.EditMode = true;
            provinciaDetalle.Provincia = provincia;

            provinciaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            ProvinciaService provService = new ProvinciaService();
            int Id;

            Id = this.SelectedItem().Id;
            provService.Remove(Id);

            this.GetAllAndLoad();
        }

        private Provincia SelectedItem()
        {
            Provincia provincia;

            provincia = (Provincia)provinciasDataGridView.SelectedRows[0].DataBoundItem;

            return provincia;
        }

        private void GetAllAndLoad()
        {
            ProvinciaService provService = new ProvinciaService();

            this.provinciasDataGridView.DataSource = null;
            this.provinciasDataGridView.DataSource = provService.GetAll();

            if (this.provinciasDataGridView.Rows.Count > 0)
            {
                this.provinciasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }
    }
}
