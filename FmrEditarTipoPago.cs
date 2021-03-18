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
    public partial class FmrEditarTipoPago : Form
    {
        TipoPago tpSelecci;
        public FmrEditarTipoPago()
        {
            InitializeComponent();
            habilitar(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrBuscarTipoPago btp = new FmrBuscarTipoPago();
            btp.ShowDialog();
            if(btp.DialogResult == DialogResult.Yes)
            {
                tpSelecci = btp.tipoPagoSeleccionado;
                txtDescripcion.Text = tpSelecci.descripcion;
               
            }

            if (btnAceptar.Text == "Aceptar")
            {
                habilitar(false);
            }
            else if (btnAceptar.Text == "Eliminar")
            {
                txtDescripcion.Enabled = false;
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void FmrEditarTipoPago_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Aceptar")
            {
                if (MessageBox.Show("Esta seguro que quiere editar el tipo de pago??","Editar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) 
                {
                    using (CursosDB bd = new CursosDB())
                    {
                        tpSelecci.descripcion = txtDescripcion.Text;
                        bd.Entry(tpSelecci).State = EntityState.Modified;
                        bd.SaveChanges();
                    }

                    MessageBox.Show(" Se Completo con exito ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnAceptar.Text == "Eliminar")
            {
                if (MessageBox.Show("Esta seguro que desea eliminar la forma de pago ??","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes) 
                {
                    using (CursosDB bd = new CursosDB())
                    {
                        tpSelecci.descripcion =$"{txtDescripcion.Text} {"Anulado"}";
                        bd.Entry(tpSelecci).State = EntityState.Modified;
                        bd.SaveChanges();
                    }

                    MessageBox.Show(" Se ha eliminado con exito ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Text = "";
                }
            }
        }

        private void habilitar(bool x)
        {
            txtDescripcion.Enabled = !x;
            btnAceptar.Enabled = !x;
            btnCancelar.Enabled = !x;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Anular la Operacion","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                txtDescripcion.Text = "";
                habilitar(true);
            }
        }
    }
}
