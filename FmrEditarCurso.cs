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
                
            
            
            }
            if (btnAceptar.Text == "Aceptar")
            {
                Anular(false);
            }
            else if (btnAceptar.Text == "Eliminar")
            {

                txtCosto.Enabled = false;
                txtDescripcion.Enabled = false;
                txtDuracion.Enabled = false;
                txtEncargado.Enabled = false;
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (btnAceptar.Text == "Aceptar")
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
                MessageBox.Show("Se ha actualizado con exito el Curso", "Actualizacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnAceptar.Text == "Eliminar") {


                if (MessageBox.Show("Desea eliminar el Curso ?", "Atencion !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (CursosDB bd = new CursosDB())
                    {

                        cursoSelecc.descripcion = "Anulado";
                        cursoSelecc.encargado = txtEncargado.Text;
                        cursoSelecc.duracion = Convert.ToInt32(txtDuracion.Text);
                        cursoSelecc.costo = Convert.ToDecimal(txtCosto.Text);

                        bd.Entry(cursoSelecc).State = EntityState.Modified;
                        bd.SaveChanges();
                    }
                    MessageBox.Show("Se ha Eliminado con exito el Curso", "Eliminacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            
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
