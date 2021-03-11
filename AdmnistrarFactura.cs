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
    public partial class AdmnistrarFactura : Form
    {
        Alumno alunoSelecionado;
        Curso precio;
        private DataTable dt;
        
        public AdmnistrarFactura()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Estudiante");
            dt.Columns.Add("Curso");
            dt.Columns.Add("Encargado");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Total");
            dt.Columns.Add("Forma de Pago");

            dtDetalleFactura.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar bc = new Buscar();
            bc.ShowDialog();
            if(bc.DialogResult == DialogResult.Yes)
            {
                alunoSelecionado = bc.alumnoSeleccionado;
                txtEstudiante.Text = $"{alunoSelecionado.nombre} {alunoSelecionado.apellido}";
            }
           
        }

        private void AdmnistrarFactura_Load(object sender, EventArgs e)
        {
            List<admnistrarTipoPago> lista = new List<admnistrarTipoPago>();
            List<administrarCurso> listaCurso = new List<administrarCurso>();


            using (CursosDB db = new CursosDB())
            {
                lista = (from d in db.TipoPago
                         select new admnistrarTipoPago
                         {
                             id = d.idTipoPago,
                             descripcion = d.descripcion
                         }).ToList();

                listaCurso = (from b in db.Curso
                              select new administrarCurso
                              {
                                  idCurso = b.idCurso,
                                  descripcion = b.descripcion
                              }).ToList();

            }

            cboFormaPago.DataSource = lista;
            cboFormaPago.ValueMember = "id";
            cboFormaPago.DisplayMember = "descripcion";

            cboCurso.DataSource = listaCurso;
            cboCurso.ValueMember = "idCurso";
            cboCurso.DisplayMember = "descripcion";


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DataRow row = dt.NewRow();
            int idPrecio =(int)cboCurso.SelectedValue;
            int totalconDescuento = Convert.ToInt32(txtDescuento.Text);
            decimal total;
            string encargado;

            if (txtEstudiante.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un Alumno....");
            }
            else
            {
                row["Estudiante"] = txtEstudiante.Text;

                row["Curso"] = cboCurso.Text;
                row["Forma de Pago"] = cboFormaPago.Text;
                row["Descuento"] = txtDescuento.Text;
                dt.Rows.Add(row);

                using (CursosDB bd = new CursosDB())
                {


                    Curso cu = bd.Curso.Where(d => d.idCurso == idPrecio).First();

                    total = cu.costo;
                    encargado = cu.encargado;



                }
                row["Encargado"] = encargado;

                if (totalconDescuento != 0)
                {
                    row["Total"] = (total - (total * totalconDescuento) / 100);
                }
                else
                {
                    row["Total"] = total;
                }
            }


            
           
           
            
          


        }
    }
}
