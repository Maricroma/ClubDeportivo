namespace ProyectoClubDeportivo.Presentacion
{
    partial class FrmComprobantePago
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
            panel1 = new Panel();
            lblMonto = new Label();
            lblFormaPago = new Label();
            lblActividad = new Label();
            lblCliente = new Label();
            lblFecha = new Label();
            lblTitulo = new Label();
            btnVolver = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lblFormaPago);
            panel1.Controls.Add(lblActividad);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(22, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 330);
            panel1.TabIndex = 0;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(36, 254);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(76, 17);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Importe:  $";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPago.Location = new Point(36, 212);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(109, 17);
            lblFormaPago.TabIndex = 4;
            lblFormaPago.Text = "Forma de pago: ";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividad.Location = new Point(36, 170);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(74, 17);
            lblActividad.TabIndex = 3;
            lblActividad.Text = "Concepto: ";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(36, 129);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(66, 17);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Nombre: ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(36, 90);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha: ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(93, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(241, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "COMPROBANTE DE PAGO";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Highlight;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(163, 389);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 39);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmComprobantePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Name = "FrmComprobantePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante de pago";
            Load += FrmComprobantePago_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Label lblFecha;
        private Label lblFormaPago;
        private Label lblActividad;
        private Label lblCliente;
        private Label lblMonto;
        private Button btnVolver;
    }
}