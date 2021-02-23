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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtNombre.Focus();

            
            
            
            


        }
        private void Limpiar()
        {
            txtApellido.Text="";
            txtNombre.Text="";
            
            txtDireccion.Clear();
            txtTelefono.Clear();
            
            txtDni.Clear();
            txtEmail.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        public bool validar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe Completar el nombre...");
                txtNombre.Focus();
                return false;
            }
            if(txtApellido.Text == "")
            {
                MessageBox.Show("Debe completar el apellido..");
                txtApellido.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe completar la direccion...");
                txtDireccion.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe Completar el telefono");
                txtTelefono.Focus();
                return false;

            }
            else
            {
                try
                {
                    Int32.Parse(txtTelefono.Text);
                }
                catch
                {
                    MessageBox.Show("Coloque solo numeros. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefono.Focus();
                    return false;
                }
            }
            return true;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar<=47) ||(e.KeyChar >=58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", " alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                var prueba = new CursosDB();
                prueba.Alumno.Add(new Alumno() { apellido = txtApellido.Text, nombre = txtNombre.Text, telefono = Convert.ToInt32(txtTelefono.Text), direccion = txtDireccion.Text, dni = Convert.ToInt32(txtDni.Text), email = txtEmail.Text });
                prueba.SaveChanges();
                MessageBox.Show(" Se a cargado con exito el alumno ");
                Limpiar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
