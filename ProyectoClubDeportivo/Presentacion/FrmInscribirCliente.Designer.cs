namespace ProyectoClubDeportivo.Presentacion
{
    partial class FrmInscribirCliente
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
            lblActividad = new Label();
            lblDni = new Label();
            tbBuscarDni = new TextBox();
            btnBuscarDni = new Button();
            lblSocioEstado = new Label();
            btnConfirmarSocio = new Button();
            btnPagar = new Button();
            btnImprimirNoSocio = new Button();
            btnVolver = new Button();
            gbFormaPago = new GroupBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            lblNombreCliente = new Label();
            gbFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActividad.Location = new Point(80, 36);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(0, 15);
            lblActividad.TabIndex = 0;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDni.Location = new Point(101, 87);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(96, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI del cliente: ";
            // 
            // tbBuscarDni
            // 
            tbBuscarDni.AcceptsTab = true;
            tbBuscarDni.AccessibleRole = AccessibleRole.MenuBar;
            tbBuscarDni.Location = new Point(203, 84);
            tbBuscarDni.Name = "tbBuscarDni";
            tbBuscarDni.Size = new Size(110, 23);
            tbBuscarDni.TabIndex = 2;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(350, 84);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(75, 23);
            btnBuscarDni.TabIndex = 3;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // lblSocioEstado
            // 
            lblSocioEstado.AutoSize = true;
            lblSocioEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSocioEstado.Location = new Point(203, 163);
            lblSocioEstado.Name = "lblSocioEstado";
            lblSocioEstado.Size = new Size(0, 15);
            lblSocioEstado.TabIndex = 5;
            lblSocioEstado.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConfirmarSocio
            // 
            btnConfirmarSocio.Location = new Point(217, 396);
            btnConfirmarSocio.Name = "btnConfirmarSocio";
            btnConfirmarSocio.Size = new Size(75, 23);
            btnConfirmarSocio.TabIndex = 6;
            btnConfirmarSocio.Text = "Confirmar";
            btnConfirmarSocio.UseVisualStyleBackColor = true;
            btnConfirmarSocio.Click += btnConfirmarSocio_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(122, 350);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnImprimirNoSocio
            // 
            btnImprimirNoSocio.Enabled = false;
            btnImprimirNoSocio.Location = new Point(309, 350);
            btnImprimirNoSocio.Name = "btnImprimirNoSocio";
            btnImprimirNoSocio.Size = new Size(75, 23);
            btnImprimirNoSocio.TabIndex = 9;
            btnImprimirNoSocio.Text = "Imprimir";
            btnImprimirNoSocio.UseVisualStyleBackColor = true;
            btnImprimirNoSocio.Click += btnImprimirNoSocio_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(217, 350);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // gbFormaPago
            // 
            gbFormaPago.BackColor = SystemColors.GradientActiveCaption;
            gbFormaPago.Controls.Add(rbTarjeta);
            gbFormaPago.Controls.Add(rbEfectivo);
            gbFormaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbFormaPago.Location = new Point(192, 204);
            gbFormaPago.Name = "gbFormaPago";
            gbFormaPago.Size = new Size(121, 100);
            gbFormaPago.TabIndex = 11;
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
            rbTarjeta.CheckedChanged += FormaPago_CheckedChanged;
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
            rbEfectivo.CheckedChanged += FormaPago_CheckedChanged;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreCliente.Location = new Point(176, 127);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(0, 15);
            lblNombreCliente.TabIndex = 12;
            lblNombreCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmInscribirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(lblNombreCliente);
            Controls.Add(gbFormaPago);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimirNoSocio);
            Controls.Add(btnPagar);
            Controls.Add(btnConfirmarSocio);
            Controls.Add(lblSocioEstado);
            Controls.Add(btnBuscarDni);
            Controls.Add(tbBuscarDni);
            Controls.Add(lblDni);
            Controls.Add(lblActividad);
            Name = "FrmInscribirCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción a actividad";
            Load += FrmInscribirCliente_Load;
            gbFormaPago.ResumeLayout(false);
            gbFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private long idActividad;
        private string nombreActividad;
        private decimal precioActividad;

        public FrmInscribirCliente(long idActividad, string nombreActividad, decimal precioActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            this.nombreActividad = nombreActividad;
            this.precioActividad = precioActividad;
        }
        private Label lblActividad;
        private Label lblDni;
        private TextBox tbBuscarDni;
        private Button btnBuscarDni;
        private Label lblSocioEstado;
        private Button btnPagar;
        private Button btnImprimirNoSocio;
        private Button btnConfirmarSocio;
        private Button btnVolver;
        private GroupBox gbFormaPago;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Label lblNombreCliente;
    }
}