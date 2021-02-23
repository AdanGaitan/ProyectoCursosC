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
    public partial class administradorTipoPago : Form
    {
        public administradorTipoPago()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var con = new CursosDB();
            con.TipoPago.Add(new TipoPago { descripcion = txtDescripcion.Text });
            con.SaveChanges();
            Limpiar();

        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
        }
    }
}
