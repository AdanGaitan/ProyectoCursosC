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
    public partial class FmrBuscarTipoPago : Form
    {
        public TipoPago tipoPagoSeleccionado;
        public FmrBuscarTipoPago()
        {
            InitializeComponent();
        }

        private void llenarTabla()
        {
            using (CursosDB bd = new CursosDB())
            {
                var busqueda = (from al in bd.TipoPago
                                where
               al.descripcion.ToLower().Contains(txtBuscarPago.Text.ToLower())
                                select al).ToList();
                dtBusquedaPago.DataSource = busqueda;
                dtBusquedaPago.Columns.Remove("Factura");

            }
        }

        private void FmrBuscarTipoPago_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarPago_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla();
        }

        private void dtBusquedaPago_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTipoPago = (int)(dtBusquedaPago.Rows[e.RowIndex].Cells[0].Value);
            using (CursosDB bd = new CursosDB())
            {
                tipoPagoSeleccionado = bd.TipoPago.First(a => a.idTipoPago == idTipoPago);
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
