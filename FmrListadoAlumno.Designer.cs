﻿namespace AdministradorCursos
{
    partial class FmrListadoAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvListadoAlumno = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListadoAlumno
            // 
            this.crvListadoAlumno.ActiveViewIndex = -1;
            this.crvListadoAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListadoAlumno.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListadoAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvListadoAlumno.Location = new System.Drawing.Point(0, 0);
            this.crvListadoAlumno.Name = "crvListadoAlumno";
            this.crvListadoAlumno.Size = new System.Drawing.Size(800, 450);
            this.crvListadoAlumno.TabIndex = 0;
            this.crvListadoAlumno.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FmrListadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvListadoAlumno);
            this.Name = "FmrListadoAlumno";
            this.Text = "Listado de Alumno";
            this.Load += new System.EventHandler(this.FmrListadoAlumno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvListadoAlumno;
    }
}