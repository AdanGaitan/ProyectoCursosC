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
        public AdmnistrarFactura()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar bc = new Buscar();
            bc.ShowDialog();
            if(bc.DialogResult == DialogResult.Yes)
            {
                alunoSelecionado = bc.alumnoSeleccionado;
            }
            txtEstudiante.Text =$"{alunoSelecionado.nombre} {alunoSelecionado.apellido}";
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
    }
}
