namespace AdministradorCursos
{
    partial class fmrListadoCursos
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
            this.crvListadoCursos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListadoCursos
            // 
            this.crvListadoCursos.ActiveViewIndex = -1;
            this.crvListadoCursos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListadoCursos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListadoCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvListadoCursos.Location = new System.Drawing.Point(0, 0);
            this.crvListadoCursos.Name = "crvListadoCursos";
            this.crvListadoCursos.Size = new System.Drawing.Size(800, 450);
            this.crvListadoCursos.TabIndex = 0;
            this.crvListadoCursos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // fmrListadoCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvListadoCursos);
            this.Name = "fmrListadoCursos";
            this.Text = "Listado de Cursos";
            this.Load += new System.EventHandler(this.fmrListadoCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvListadoCursos;
    }
}