
namespace DeudoresMorosos.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblPunitorioxdia = new System.Windows.Forms.Label();
            this.lblImpAdeudado = new System.Windows.Forms.Label();
            this.lblFechaVto = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblIntPunitorio = new System.Windows.Forms.Label();
            this.lblImpTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtImpAdeudado = new System.Windows.Forms.TextBox();
            this.txtPunitorioxdia = new System.Windows.Forms.TextBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.txtFechaVto = new System.Windows.Forms.TextBox();
            this.txtIntPunitorio = new System.Windows.Forms.TextBox();
            this.txtImpTotal = new System.Windows.Forms.TextBox();
            this.lblTituloMoras = new System.Windows.Forms.Label();
            this.lblDiasAtraso = new System.Windows.Forms.Label();
            this.lblIntPromedio = new System.Windows.Forms.Label();
            this.txtIntPromedio = new System.Windows.Forms.TextBox();
            this.txtDiasAtraso = new System.Windows.Forms.TextBox();
            this.lstPagos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(125, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario de Pago";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(40, 35);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(45, 13);
            this.lblServicio.TabIndex = 2;
            this.lblServicio.Text = "Servicio";
            // 
            // lblPunitorioxdia
            // 
            this.lblPunitorioxdia.AutoSize = true;
            this.lblPunitorioxdia.Location = new System.Drawing.Point(40, 64);
            this.lblPunitorioxdia.Name = "lblPunitorioxdia";
            this.lblPunitorioxdia.Size = new System.Drawing.Size(85, 13);
            this.lblPunitorioxdia.TabIndex = 3;
            this.lblPunitorioxdia.Text = "Punitorio por día";
            // 
            // lblImpAdeudado
            // 
            this.lblImpAdeudado.AutoSize = true;
            this.lblImpAdeudado.Location = new System.Drawing.Point(40, 102);
            this.lblImpAdeudado.Name = "lblImpAdeudado";
            this.lblImpAdeudado.Size = new System.Drawing.Size(94, 13);
            this.lblImpAdeudado.TabIndex = 4;
            this.lblImpAdeudado.Text = "Importe Adeudado";
            // 
            // lblFechaVto
            // 
            this.lblFechaVto.AutoSize = true;
            this.lblFechaVto.Location = new System.Drawing.Point(40, 139);
            this.lblFechaVto.Name = "lblFechaVto";
            this.lblFechaVto.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVto.TabIndex = 5;
            this.lblFechaVto.Text = "Fecha de Vencimiento";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(40, 169);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 6;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblIntPunitorio
            // 
            this.lblIntPunitorio.AutoSize = true;
            this.lblIntPunitorio.Location = new System.Drawing.Point(40, 233);
            this.lblIntPunitorio.Name = "lblIntPunitorio";
            this.lblIntPunitorio.Size = new System.Drawing.Size(83, 13);
            this.lblIntPunitorio.TabIndex = 7;
            this.lblIntPunitorio.Text = "Interes Punitorio";
            // 
            // lblImpTotal
            // 
            this.lblImpTotal.AutoSize = true;
            this.lblImpTotal.Location = new System.Drawing.Point(40, 268);
            this.lblImpTotal.Name = "lblImpTotal";
            this.lblImpTotal.Size = new System.Drawing.Size(69, 13);
            this.lblImpTotal.TabIndex = 8;
            this.lblImpTotal.Text = "Importe Total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(43, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(237, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(43, 293);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(237, 23);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(148, 169);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPago.TabIndex = 4;
            // 
            // txtImpAdeudado
            // 
            this.txtImpAdeudado.Location = new System.Drawing.Point(148, 99);
            this.txtImpAdeudado.Name = "txtImpAdeudado";
            this.txtImpAdeudado.Size = new System.Drawing.Size(100, 20);
            this.txtImpAdeudado.TabIndex = 2;
            // 
            // txtPunitorioxdia
            // 
            this.txtPunitorioxdia.Enabled = false;
            this.txtPunitorioxdia.Location = new System.Drawing.Point(148, 64);
            this.txtPunitorioxdia.Name = "txtPunitorioxdia";
            this.txtPunitorioxdia.Size = new System.Drawing.Size(100, 20);
            this.txtPunitorioxdia.TabIndex = 1;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(148, 32);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 0;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_Select);
            this.cmbServicio.Click += new System.EventHandler(this.cmbServicio_Click);
            // 
            // txtFechaVto
            // 
            this.txtFechaVto.Location = new System.Drawing.Point(148, 136);
            this.txtFechaVto.Name = "txtFechaVto";
            this.txtFechaVto.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVto.TabIndex = 3;
            // 
            // txtIntPunitorio
            // 
            this.txtIntPunitorio.Enabled = false;
            this.txtIntPunitorio.Location = new System.Drawing.Point(148, 224);
            this.txtIntPunitorio.Name = "txtIntPunitorio";
            this.txtIntPunitorio.Size = new System.Drawing.Size(100, 20);
            this.txtIntPunitorio.TabIndex = 16;
            // 
            // txtImpTotal
            // 
            this.txtImpTotal.Enabled = false;
            this.txtImpTotal.Location = new System.Drawing.Point(148, 261);
            this.txtImpTotal.Name = "txtImpTotal";
            this.txtImpTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImpTotal.TabIndex = 17;
            // 
            // lblTituloMoras
            // 
            this.lblTituloMoras.AutoSize = true;
            this.lblTituloMoras.Location = new System.Drawing.Point(531, 9);
            this.lblTituloMoras.Name = "lblTituloMoras";
            this.lblTituloMoras.Size = new System.Drawing.Size(92, 13);
            this.lblTituloMoras.TabIndex = 18;
            this.lblTituloMoras.Text = "Reporte de Moras";
            // 
            // lblDiasAtraso
            // 
            this.lblDiasAtraso.AutoSize = true;
            this.lblDiasAtraso.Location = new System.Drawing.Point(398, 233);
            this.lblDiasAtraso.Name = "lblDiasAtraso";
            this.lblDiasAtraso.Size = new System.Drawing.Size(124, 13);
            this.lblDiasAtraso.TabIndex = 19;
            this.lblDiasAtraso.Text = "Días de atraso Promedio";
            // 
            // lblIntPromedio
            // 
            this.lblIntPromedio.AutoSize = true;
            this.lblIntPromedio.Location = new System.Drawing.Point(398, 271);
            this.lblIntPromedio.Name = "lblIntPromedio";
            this.lblIntPromedio.Size = new System.Drawing.Size(86, 13);
            this.lblIntPromedio.TabIndex = 20;
            this.lblIntPromedio.Text = "Interes Promedio";
            // 
            // txtIntPromedio
            // 
            this.txtIntPromedio.Enabled = false;
            this.txtIntPromedio.Location = new System.Drawing.Point(576, 268);
            this.txtIntPromedio.Name = "txtIntPromedio";
            this.txtIntPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtIntPromedio.TabIndex = 21;
            // 
            // txtDiasAtraso
            // 
            this.txtDiasAtraso.Enabled = false;
            this.txtDiasAtraso.Location = new System.Drawing.Point(576, 230);
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.Size = new System.Drawing.Size(100, 20);
            this.txtDiasAtraso.TabIndex = 22;
            // 
            // lstPagos
            // 
            this.lstPagos.FormattingEnabled = true;
            this.lstPagos.Location = new System.Drawing.Point(440, 35);
            this.lstPagos.Name = "lstPagos";
            this.lstPagos.Size = new System.Drawing.Size(315, 147);
            this.lstPagos.TabIndex = 23;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.lstPagos);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.txtIntPromedio);
            this.Controls.Add(this.lblIntPromedio);
            this.Controls.Add(this.lblDiasAtraso);
            this.Controls.Add(this.lblTituloMoras);
            this.Controls.Add(this.txtImpTotal);
            this.Controls.Add(this.txtIntPunitorio);
            this.Controls.Add(this.txtFechaVto);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.txtPunitorioxdia);
            this.Controls.Add(this.txtImpAdeudado);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblImpTotal);
            this.Controls.Add(this.lblIntPunitorio);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblFechaVto);
            this.Controls.Add(this.lblImpAdeudado);
            this.Controls.Add(this.lblPunitorioxdia);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPrincipal";
            this.Text = "RAPI COBRANZA S.A.";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblPunitorioxdia;
        private System.Windows.Forms.Label lblImpAdeudado;
        private System.Windows.Forms.Label lblFechaVto;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblIntPunitorio;
        private System.Windows.Forms.Label lblImpTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtImpAdeudado;
        private System.Windows.Forms.TextBox txtPunitorioxdia;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.TextBox txtFechaVto;
        private System.Windows.Forms.TextBox txtIntPunitorio;
        private System.Windows.Forms.TextBox txtImpTotal;
        private System.Windows.Forms.Label lblTituloMoras;
        private System.Windows.Forms.Label lblDiasAtraso;
        private System.Windows.Forms.Label lblIntPromedio;
        private System.Windows.Forms.TextBox txtIntPromedio;
        private System.Windows.Forms.TextBox txtDiasAtraso;
        private System.Windows.Forms.ListBox lstPagos;
    }
}

