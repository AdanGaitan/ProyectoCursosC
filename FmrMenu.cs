﻿using System;
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
    public partial class FmrMenu : Form
    {
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void nuevoEditarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            administradorTipoPago atp = new administradorTipoPago();
            atp.Show();
        }

        private void nuevoEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorCurso cs = new AdministradorCurso();
            cs.Show();
        }

        private void editarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorCurso cs = new AdministradorCurso();
            cs.Show();
        }

        private void editarTipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administradorTipoPago atp = new administradorTipoPago();
            atp.Show();
        }

        private void agregarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 admAlu = new Form1();
            admAlu.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmnistrarFactura amf = new AdmnistrarFactura();
            amf.Show();
        }
    }
}
