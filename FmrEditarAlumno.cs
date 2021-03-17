using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace AdministradorCursos
{
    public partial class FmrEditarAlumno : Form
    {

        Alumno editarAlum;
        public FmrEditarAlumno()
        {
            InitializeComponent();
            validar(true);
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            Buscar buscarAlumno = new Buscar();
            buscarAlumno.ShowDialog();

            if(buscarAlumno.DialogResult == DialogResult.Yes)
            {
                validar(false);
                editarAlum = buscarAlumno.alumnoSeleccionado;
                lblCodAlumno.Text = editarAlum.idAlumno.ToString();  
                txtNombre.Text = editarAlum.nombre;
                txtApellido.Text = editarAlum.apellido;
                txtDni.Text = editarAlum.dni.ToString();
                txtTelefono.Text = editarAlum.telefono.ToString();
                txtDireccion.Text = editarAlum.direccion;
                txtEmail.Text = editarAlum.email;
                

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            using (CursosDB c = new CursosDB())
            {

                editarAlum.nombre = txtNombre.Text;
                editarAlum.apellido = txtApellido.Text ;
                editarAlum.dni=Convert.ToInt32(txtDni.Text);
                editarAlum.telefono =Convert.ToInt32(txtTelefono.Text);
                editarAlum.direccion = txtDireccion.Text;
                editarAlum.email = txtEmail.Text;

                c.Entry(editarAlum).State = EntityState.Modified;
                c.SaveChanges();
            }
            MessageBox.Show("Exito");


        }

        private void validar(bool x)
        {
            
                txtNombre.Enabled = !x;
                txtApellido.Enabled = !x;
                txtDni.Enabled = !x;
                txtTelefono.Enabled = !x;
                txtDireccion.Enabled = !x;
                txtEmail.Enabled = !x;
           
            
        }
    }
}
