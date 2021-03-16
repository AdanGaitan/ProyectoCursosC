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
    public partial class FmrListadoAlumno : Form
    {
        public FmrListadoAlumno()
        {
            InitializeComponent();
        }

        private void FmrListadoAlumno_Load(object sender, EventArgs e)
        {
            Reportes.ListadoAlumno crpAlumno = new Reportes.ListadoAlumno();
            crvListadoAlumno.ReportSource = null;
            crvListadoAlumno.ReportSource = crpAlumno;
        }
    }
}
