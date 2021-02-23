using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorCursos
{
    public partial class AdministradorCurso : Form
    {
        public AdministradorCurso()
        {
            InitializeComponent();
        }

        private void AdministradorCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var conexion = new CursosDB();
            conexion.Curso.Add(new Curso {descripcion = txtDescripcion.Text,encargado = txtEncargado.Text,duracion=Convert.ToInt32(txtDuracion.Text),costo=Convert.ToDecimal(txtCosto.Text)});
            conexion.SaveChanges();
            MessageBox.Show("El curso se a cargado con exito");
            limpiar();
        }
        private void limpiar()
        {
            txtCosto.Clear();
            txtDescripcion.Clear();
            txtDuracion.Clear();
            txtEncargado.Clear();
        }
    }
}
