namespace ProyectoClubDeportivo.Presentacion
{
    partial class FrmPagoCuota
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
            lblDni = new Label();
            tbBuscarDni = new TextBox();
            btnBuscarDni = new Button();
            gbDatosCliente = new GroupBox();
            lblProximoPago = new Label();
            lblNombre = new Label();
            gpDatosPago = new GroupBox();
            tbImporte = new TextBox();
            lblPrecio = new Label();
            gbFormaPago = new GroupBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            btnPagar = new Button();
            btnImprimirCuota = new Button();
            gbDatosCliente.SuspendLayout();
            gpDatosPago.SuspendLayout();
            gbFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDni.Location = new Point(125, 57);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(96, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI del cliente: ";
            // 
            // tbBuscarDni
            // 
            tbBuscarDni.AcceptsTab = true;
            tbBuscarDni.AccessibleRole = AccessibleRole.MenuBar;
            tbBuscarDni.Location = new Point(227, 54);
            tbBuscarDni.Name = "tbBuscarDni";
            tbBuscarDni.Size = new Size(110, 23);
            tbBuscarDni.TabIndex = 3;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(372, 54);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(75, 23);
            btnBuscarDni.TabIndex = 4;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // gbDatosCliente
            // 
            gbDatosCliente.BackColor = SystemColors.ControlLightLight;
            gbDatosCliente.Controls.Add(lblProximoPago);
            gbDatosCliente.Controls.Add(lblNombre);
            gbDatosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbDatosCliente.Location = new Point(24, 142);
            gbDatosCliente.Name = "gbDatosCliente";
            gbDatosCliente.Size = new Size(232, 173);
            gbDatosCliente.TabIndex = 5;
            gbDatosCliente.TabStop = false;
            gbDatosCliente.Text = "Datos del cliente";
            gbDatosCliente.Visible = false;
            // 
            // lblProximoPago
            // 
            lblProximoPago.AutoSize = true;
            lblProximoPago.Location = new Point(18, 80);
            lblProximoPago.Name = "lblProximoPago";
            lblProximoPago.Size = new Size(0, 15);
            lblProximoPago.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 0;
            // 
            // gpDatosPago
            // 
            gpDatosPago.BackColor = SystemColors.ControlLightLight;
            gpDatosPago.Controls.Add(tbImporte);
            gpDatosPago.Controls.Add(lblPrecio);
            gpDatosPago.Controls.Add(gbFormaPago);
            gpDatosPago.Controls.Add(label1);
            gpDatosPago.Controls.Add(label2);
            gpDatosPago.Location = new Point(303, 142);
            gpDatosPago.Name = "gpDatosPago";
            gpDatosPago.Size = new Size(245, 226);
            gpDatosPago.TabIndex = 6;
            gpDatosPago.TabStop = false;
            gpDatosPago.Text = "Datos del pago";
            gpDatosPago.Visible = false;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(81, 173);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 14;
            tbImporte.TextChanged += tbImporte_TextChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(27, 176);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(48, 15);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio: ";
            // 
            // gbFormaPago
            // 
            gbFormaPago.BackColor = SystemColors.GradientActiveCaption;
            gbFormaPago.Controls.Add(rbTarjeta);
            gbFormaPago.Controls.Add(rbEfectivo);
            gbFormaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbFormaPago.Location = new Point(60, 41);
            gbFormaPago.Name = "gbFormaPago";
            gbFormaPago.Size = new Size(121, 100);
            gbFormaPago.TabIndex = 12;
            gbFormaPago.TabStop = false;
            gbFormaPago.Text = "Forma de pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(6, 60);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(63, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(6, 35);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(71, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 73);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(181, 398);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 9;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Visible = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnImprimirCuota
            // 
            btnImprimirCuota.Enabled = false;
            btnImprimirCuota.Location = new Point(303, 398);
            btnImprimirCuota.Name = "btnImprimirCuota";
            btnImprimirCuota.Size = new Size(75, 23);
            btnImprimirCuota.TabIndex = 10;
            btnImprimirCuota.Text = "Imprimir";
            btnImprimirCuota.UseVisualStyleBackColor = true;
            btnImprimirCuota.Visible = false;
            btnImprimirCuota.Click += btnImprimir_Click;
            // 
            // FrmPagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(btnImprimirCuota);
            Controls.Add(btnPagar);
            Controls.Add(gpDatosPago);
            Controls.Add(gbDatosCliente);
            Controls.Add(btnBuscarDni);
            Controls.Add(tbBuscarDni);
            Controls.Add(lblDni);
            Name = "FrmPagoCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago de cuota";
            Load += FrmPagoCuota_Load;
            gbDatosCliente.ResumeLayout(false);
            gbDatosCliente.PerformLayout();
            gpDatosPago.ResumeLayout(false);
            gpDatosPago.PerformLayout();
            gbFormaPago.ResumeLayout(false);
            gbFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private TextBox tbBuscarDni;
        private Button btnBuscarDni;
        private GroupBox gbDatosCliente;
        private Label lblNombre;
        private Label lblProximoPago;
        private GroupBox gpDatosPago;
        private Label label1;
        private Label label2;
        private GroupBox gbFormaPago;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Label lblPrecio;
        private TextBox tbImporte;
        private Button btnPagar;
        private Button btnImprimirCuota;
    }
}