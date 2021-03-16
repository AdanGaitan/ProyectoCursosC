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
    public partial class FmrListadoProfesores : Form
    {
        public FmrListadoProfesores()
        {
            InitializeComponent();
        }

        private void FmrListadoProfesores_Load(object sender, EventArgs e)
        {
            Reportes.LIstadoProfesores crvProfesores = new Reportes.LIstadoProfesores();
            crvListadoProfesor.ReportSource = null;
            crvListadoProfesor.ReportSource = crvProfesores;
        }
    }
}
