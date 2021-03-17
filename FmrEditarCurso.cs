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

namespace AdministradorCursos
{
    public partial class FmrEditarCurso : Form
    {
        public Curso cursoSelecc;
        public FmrEditarCurso()
        {
            InitializeComponent();
            Anular(true);
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            FmrBuscarCurso buscarCurso = new FmrBuscarCurso();
            buscarCurso.ShowDialog();
            if (buscarCurso.DialogResult == DialogResult.Yes)
            {
                cursoSelecc = buscarCurso.cursoSeleccionado;
                lblCodCurso.Text = cursoSelecc.idCurso.ToString();
                txtDescripcion.Text = cursoSelecc.descripcion;
                txtEncargado.Text = cursoSelecc.encargado;
                txtDuracion.Text = cursoSelecc.duracion.ToString();
                txtCosto.Text = cursoSelecc.costo.ToString();
                Anular(false);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (CursosDB bd = new CursosDB())
            {
                cursoSelecc.descripcion = txtDescripcion.Text;
                cursoSelecc.encargado = txtEncargado.Text;
                cursoSelecc.duracion = Convert.ToInt32(txtDuracion.Text);
                cursoSelecc.costo = Convert.ToDecimal(txtCosto.Text);

                bd.Entry(cursoSelecc).State = EntityState.Modified;
                bd.SaveChanges();
            }
            MessageBox.Show("Se ha actualizado con exito el Curso","Actualizacion con Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        public void Anular(bool x)
        {
            txtCosto.Enabled = !x;
            txtDescripcion.Enabled = !x;
            txtDuracion.Enabled = !x;
            txtEncargado.Enabled = !x;
            btnAceptar.Enabled = !x;
            btnCancelar.Enabled = !x;

        }
        public void limpiar()
        {
            lblCodCurso.Text = "0";
            txtCosto.Text = "";
            txtDescripcion.Text = "";
            txtDuracion.Text = "";
            txtEncargado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Anular la Operacion","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Anular(true);
                limpiar();
            }
        }
    }
}
