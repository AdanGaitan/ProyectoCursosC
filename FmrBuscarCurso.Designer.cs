namespace AdministradorCursos
{
    partial class FmrBuscarCurso
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
            this.dtBusquedaCurso = new System.Windows.Forms.DataGridView();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtBusquedaCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBusquedaCurso
            // 
            this.dtBusquedaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBusquedaCurso.Location = new System.Drawing.Point(12, 69);
            this.dtBusquedaCurso.Name = "dtBusquedaCurso";
            this.dtBusquedaCurso.Size = new System.Drawing.Size(776, 369);
            this.dtBusquedaCurso.TabIndex = 0;
            this.dtBusquedaCurso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtBusquedaCurso_CellContentDoubleClick);
            this.dtBusquedaCurso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtBusquedaCurso_CellDoubleClick);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(21, 27);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(173, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Escriba el nombre del Curso :";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(200, 24);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(239, 20);
            this.txtNombreCurso.TabIndex = 2;
            this.txtNombreCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCurso_KeyPress);
            // 
            // FmrBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.dtBusquedaCurso);
            this.Name = "FmrBuscarCurso";
            this.Text = "Seleccione Curso";
            this.Load += new System.EventHandler(this.FmrBuscarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBusquedaCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtBusquedaCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
    }
}