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
    public partial class FmrBuscarCurso : Form
    {
        public Curso cursoSeleccionado;
        public FmrBuscarCurso()
        {
            InitializeComponent();
        }

        private void FmrBuscarCurso_Load(object sender, EventArgs e)
        {

        }
        private void llenarTabla()
        {
            using (CursosDB bd = new CursosDB())
            {
                var busqueda = (from al in bd.Curso
                                where al.descripcion.ToLower().Contains(txtNombreCurso.Text.ToLower())
                                select al).ToList();
                dtBusquedaCurso.DataSource = busqueda;
                dtBusquedaCurso.Columns.Remove("DetalleFactura");
            }
        }

        private void txtNombreCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            llenarTabla();
        }

        private void dtBusquedaCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCurso = (int)(dtBusquedaCurso.Rows[e.RowIndex].Cells[0].Value);
            using (CursosDB db = new CursosDB())
            {
                cursoSeleccionado = db.Curso.First(c => c.idCurso == idCurso);
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
