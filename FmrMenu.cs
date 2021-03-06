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
            FmrEditarCurso cs = new FmrEditarCurso();
            cs.ShowDialog();
        }

        private void editarTipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditarTipoPago edp = new FmrEditarTipoPago();
            edp.ShowDialog();
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

        private void listadoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrListadoAlumno la = new FmrListadoAlumno();
            la.ShowDialog();
        }

        private void listadoDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrListadoProfesores lp = new FmrListadoProfesores();
            lp.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrListadoCursos lc = new fmrListadoCursos();
            lc.ShowDialog();
        }

        private void FmrMenu_Load(object sender, EventArgs e)
        {

        }

        private void editarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditarAlumno eA = new FmrEditarAlumno();
            eA.ShowDialog();
        }

        private void eliminarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditarCurso edic = new FmrEditarCurso();
            edic.btnAceptar.Text = "Eliminar" ;
            edic.ShowDialog();
           
        }

        private void borrarTipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditarTipoPago edtp = new FmrEditarTipoPago();
            edtp.btnAceptar.Text = "Eliminar";
            edtp.ShowDialog();
            
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditarAlumno eliAlu = new FmrEditarAlumno();
            eliAlu.btnAceptar.Text = "Eliminar";
            eliAlu.ShowDialog();
        }
    }
}
