namespace AdministradorCursos
{
    partial class FmrListadoProfesores
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
            this.crvListadoProfesor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListadoProfesor
            // 
            this.crvListadoProfesor.ActiveViewIndex = -1;
            this.crvListadoProfesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListadoProfesor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListadoProfesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvListadoProfesor.Location = new System.Drawing.Point(0, 0);
            this.crvListadoProfesor.Name = "crvListadoProfesor";
            this.crvListadoProfesor.Size = new System.Drawing.Size(800, 450);
            this.crvListadoProfesor.TabIndex = 0;
            this.crvListadoProfesor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FmrListadoProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvListadoProfesor);
            this.Name = "FmrListadoProfesores";
            this.Text = "Listado de Profesores";
            this.Load += new System.EventHandler(this.FmrListadoProfesores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvListadoProfesor;
    }
}