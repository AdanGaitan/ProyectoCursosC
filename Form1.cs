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

           
            

            
            


        }
        private void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDni.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prueba = new CursosDB();
            prueba.Alumno.Add(new Alumno() { apellido = txtApellido.Text, nombre = txtNombre.Text, telefono =Convert.ToInt32(txtTelefono.Text), direccion = txtDireccion.Text, dni=Convert.ToInt32(txtDni.Text),email=txtEmail.Text }); ;
            prueba.SaveChanges();
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
