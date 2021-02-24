using System;
using System.Windows.Forms;
using System.Linq;

namespace AdministradorCursos
{
    public partial class Buscar : Form
    {
        public Alumno alumnoSeleccionado;
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            
        }

        private void refrescar()
        {
            using (CursosDB db = new CursosDB())
            {
                
              //  dtBusqueda.DataSource = db.sp_listarAlumnos(txtNombre.Text);
                var busqueda = (from al in db.Alumno where al.nombre.ToLower().Contains(txtNombre.Text.ToLower()) || al.apellido.ToLower().Contains(txtNombre.Text.ToLower()) select al).ToList();
                dtBusqueda.DataSource = busqueda;
                dtBusqueda.Columns.Remove("Factura");


            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            refrescar();
        }

        private void dtBusqueda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dtBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iAlumno = (int)(dtBusqueda.Rows[e.RowIndex].Cells[0].Value);
            using (CursosDB db = new CursosDB())
            {
                alumnoSeleccionado = db.Alumno.First(a => a.idAlumno == iAlumno);
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
