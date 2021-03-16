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
    public partial class fmrListadoCursos : Form
    {
        public fmrListadoCursos()
        {
            InitializeComponent();
        }

        private void fmrListadoCursos_Load(object sender, EventArgs e)
        {
            Reportes.crvListadoCursos crvListadoCurso = new Reportes.crvListadoCursos();
            crvListadoCursos.ReportSource = null;
            crvListadoCursos.ReportSource = crvListadoCurso;
        }
    }
}
