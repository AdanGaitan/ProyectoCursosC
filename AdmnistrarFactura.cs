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
      
        private DataTable dt;
        
        public AdmnistrarFactura()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("idAlumno");
            
            dt.Columns.Add("Estudiante");
            dt.Columns.Add("Curso");
            dt.Columns.Add("idCursoA");
            dt.Columns.Add("Encargado");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Total");
            dt.Columns.Add("Forma de Pago");
            dt.Columns.Add("idFormaPago");

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
                lblCodigoEstudiante.Text = alunoSelecionado.idAlumno.ToString();
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

            

            DataGridViewColumn idAlum = dtDetalleFactura.Columns["idAlumno"];
            idAlum.Visible = false;
            DataGridViewColumn idCur = dtDetalleFactura.Columns["idCursoA"];
            idCur.Visible = false;
            DataGridViewColumn idForPago = dtDetalleFactura.Columns["idFormaPago"];
            idForPago.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DataRow row = dt.NewRow();
            int idPrecio =(int)cboCurso.SelectedValue;
            int totalconDescuento = Convert.ToInt32(txtDescuento.Text);
         
            decimal total;
            decimal totalGuardar;
            string encargado;

            if (txtEstudiante.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un Alumno....");
            }
            else
            {
                row["idAlumno"] = lblCodigoEstudiante.Text;
                row["Estudiante"] = txtEstudiante.Text;
                row["idCursoA"] = cboCurso.SelectedValue;
                row["Curso"] = cboCurso.Text;
                row["idFormaPago"] = cboFormaPago.SelectedValue;
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
                    totalGuardar = (total - (total * totalconDescuento) / 100);
                }
                else
                {
                    row["Total"] = total;
                    totalGuardar = total;
                }

                decimal SumaTotal = 0;
                foreach (DataRow item in dt.Rows)
                {
                    string totalS = (string)item["Total"];
                
                    SumaTotal = SumaTotal +Convert.ToDecimal (totalS);
                }

               
                txtSumaTotal.Text = SumaTotal.ToString();
            }
          

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

           

            if(MessageBox.Show("Desea Imprimir el comprbante","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LLenarFactura();

                llenarDetalles();
            }



        }

        private void LLenarFactura()
        {

            using (CursosDB bd = new CursosDB())
            {
                Factura fa = new Factura();
                fa.idAlumno = Convert.ToInt32(lblCodigoEstudiante.Text);
                fa.idTipoPago = (int)cboFormaPago.SelectedValue;
                fa.SumaTotal = Convert.ToDecimal(txtSumaTotal.Text);
                bd.Factura.Add(fa);
                bd.SaveChanges();
            }


           



        }

        private void llenarDetalles()
        {
            foreach (DataRow df in dt.Rows)
            {
                string descuento =(string)df["Descuento"];
                string idCurso = (string)df["idCursoA"];
                string total = (string)df["Total"];
                 
                using (CursosDB bd = new CursosDB())
                {
                    int idCodiFa = bd.Factura.Max(a => a.idFactura);
                    int codFactura = idCodiFa;

                    DetalleFactura detallefac = new DetalleFactura();
                    detallefac.descuento =Convert.ToInt32(descuento);
                    detallefac.idCurso = Convert.ToInt32(idCurso);
                    detallefac.total = Convert.ToDecimal(total);
                    detallefac.codFactura = codFactura;
                 
                    bd.DetalleFactura.Add(detallefac);
                    bd.SaveChanges();
                }
                
            }
        }


        //private void TomarDatos()
        //{

        //    //foreach (DataGridViewRow item in dtDetalleFactura.Rows)
        //    //{
        //    //    string estudiante = (string)item.Cells[0].Value;
        //    //    string curso = (string)item.Cells[1].Value;
        //    //    string encargado = (string)item.Cells[2].Value;
        //    //    string descuento = (string)item.Cells[3].Value;
        //    //    string total = (string)item.Cells[4].Value;
        //    //    string formapago = (string)item.Cells[5].Value;


        //    //    string ggpiola = "";

        //    //}

        //    //foreach (DataRow item in dt.Rows)
        //    //{
        //    //    string estudiante = item["Estudiante"].ToString();
        //    //    string curso = item["Curso"].ToString();
        //    //    string encargado = item["Encargado"].ToString();
        //    //    string descuento = item["Descuento"].ToString();
        //    //    string total = item["Total"].ToString();


        //    //    //string formapago = (string)item.Cells[5].Value;


               
        //    //}


        //}

    }
}
