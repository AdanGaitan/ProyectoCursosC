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
               
                editarAlum = buscarAlumno.alumnoSeleccionado;
                lblCodAlumno.Text = editarAlum.idAlumno.ToString();  
                txtNombre.Text = editarAlum.nombre;
                txtApellido.Text = editarAlum.apellido;
                txtDni.Text = editarAlum.dni.ToString();
                txtTelefono.Text = editarAlum.telefono.ToString();
                txtDireccion.Text = editarAlum.direccion;
                txtEmail.Text = editarAlum.email;
                

            }
            if (btnAceptar.Text == "Aceptar")
            {
                validar(false);
            }
            else if (btnAceptar.Text == "Eliminar")
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDni.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
                txtEmail.Enabled = false;
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text =="Aceptar") 
            {
                if (MessageBox.Show("Esta Seguro de Modificar el Alumno ??","Modifica",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) 
                {
                    using (CursosDB c = new CursosDB())
                    {

                        editarAlum.nombre = txtNombre.Text;
                        editarAlum.apellido = txtApellido.Text;
                        editarAlum.dni = Convert.ToInt32(txtDni.Text);
                        editarAlum.telefono = Convert.ToInt32(txtTelefono.Text);
                        editarAlum.direccion = txtDireccion.Text;
                        editarAlum.email = txtEmail.Text;

                        c.Entry(editarAlum).State = EntityState.Modified;
                        c.SaveChanges();
                    }
                    MessageBox.Show(" Se ha Actualizo el Alumno Con exito ", "Actualizacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnAceptar.Text =="Eliminar")
            {
                if (MessageBox.Show("Esta seguro que quiere eliminar el Alumno ???","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    using (CursosDB c = new CursosDB())
                    {

                        editarAlum.nombre = $"{txtNombre.Text} {"Anulado"}";
                        editarAlum.apellido = txtApellido.Text;
                        editarAlum.dni = Convert.ToInt32(txtDni.Text);
                        editarAlum.telefono = Convert.ToInt32(txtTelefono.Text);
                        editarAlum.direccion = txtDireccion.Text;
                        editarAlum.email = txtEmail.Text;

                        c.Entry(editarAlum).State = EntityState.Modified;
                        c.SaveChanges();
                    }
                    MessageBox.Show(" Se ha Eliminado el Alumno Con exito ", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }

        }

        private void validar(bool x)
        {
            
            txtNombre.Enabled = !x;
            txtApellido.Enabled = !x;
            txtDni.Enabled = !x;
            txtTelefono.Enabled = !x;
            txtDireccion.Enabled = !x;
            txtEmail.Enabled = !x;
            btnAceptar.Enabled = !x;
            btnCancelar.Enabled = !x;
           
            
        }
        private void limpiar()
        {
            lblCodAlumno.Text ="";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
           if (MessageBox.Show("Esta Seguro que Desea Cancelar la Operacion"," Cancelar ",MessageBoxButtons.YesNo,MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                limpiar();
                validar(true);
            }
        }

        private void FmrEditarAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
