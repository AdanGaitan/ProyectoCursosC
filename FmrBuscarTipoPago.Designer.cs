namespace AdministradorCursos
{
    partial class FmrBuscarTipoPago
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
            this.dtBusquedaPago = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtBusquedaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBusquedaPago
            // 
            this.dtBusquedaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBusquedaPago.Location = new System.Drawing.Point(12, 100);
            this.dtBusquedaPago.Name = "dtBusquedaPago";
            this.dtBusquedaPago.Size = new System.Drawing.Size(346, 231);
            this.dtBusquedaPago.TabIndex = 0;
            this.dtBusquedaPago.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtBusquedaPago_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba el Tipo de Pago ";
            // 
            // txtBuscarPago
            // 
            this.txtBuscarPago.Location = new System.Drawing.Point(15, 58);
            this.txtBuscarPago.Name = "txtBuscarPago";
            this.txtBuscarPago.Size = new System.Drawing.Size(343, 20);
            this.txtBuscarPago.TabIndex = 2;
            this.txtBuscarPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPago_KeyUp);
            // 
            // FmrBuscarTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 364);
            this.Controls.Add(this.txtBuscarPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBusquedaPago);
            this.Name = "FmrBuscarTipoPago";
            this.Text = "Buscar Tipo de Pago";
            this.Load += new System.EventHandler(this.FmrBuscarTipoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBusquedaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtBusquedaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPago;
    }
}