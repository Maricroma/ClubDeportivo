namespace ProyectoClubDeportivo.Presentacion
{
    partial class FormMenu
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
            agregarSocio = new Button();
            agregarNoSocio = new Button();
            lbUsuarioInfo = new Label();
            pagarCuota = new Button();
            inscribirActividad = new Button();
            btnListado = new Button();
            SuspendLayout();
            // 
            // agregarSocio
            // 
            agregarSocio.BackColor = SystemColors.Highlight;
            agregarSocio.FlatStyle = FlatStyle.Flat;
            agregarSocio.Location = new Point(41, 61);
            agregarSocio.Margin = new Padding(2);
            agregarSocio.Name = "agregarSocio";
            agregarSocio.Size = new Size(172, 39);
            agregarSocio.TabIndex = 0;
            agregarSocio.Text = "Agregar Socio";
            agregarSocio.UseVisualStyleBackColor = false;
            agregarSocio.Click += AgregarSocio_Click;
            // 
            // agregarNoSocio
            // 
            agregarNoSocio.BackColor = SystemColors.Highlight;
            agregarNoSocio.FlatStyle = FlatStyle.Flat;
            agregarNoSocio.Location = new Point(41, 127);
            agregarNoSocio.Margin = new Padding(2);
            agregarNoSocio.Name = "agregarNoSocio";
            agregarNoSocio.Size = new Size(172, 43);
            agregarNoSocio.TabIndex = 1;
            agregarNoSocio.Text = "Agregar No Socio";
            agregarNoSocio.UseVisualStyleBackColor = false;
            agregarNoSocio.Click += AgregarNoSocio_Click;
            // 
            // lbUsuarioInfo
            // 
            lbUsuarioInfo.AutoSize = true;
            lbUsuarioInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUsuarioInfo.ForeColor = SystemColors.HotTrack;
            lbUsuarioInfo.Location = new Point(41, 12);
            lbUsuarioInfo.Margin = new Padding(2, 0, 2, 0);
            lbUsuarioInfo.Name = "lbUsuarioInfo";
            lbUsuarioInfo.Size = new Size(0, 15);
            lbUsuarioInfo.TabIndex = 2;
            // 
            // pagarCuota
            // 
            pagarCuota.BackColor = SystemColors.Highlight;
            pagarCuota.FlatStyle = FlatStyle.Flat;
            pagarCuota.Location = new Point(284, 61);
            pagarCuota.Margin = new Padding(2);
            pagarCuota.Name = "pagarCuota";
            pagarCuota.Size = new Size(172, 39);
            pagarCuota.TabIndex = 3;
            pagarCuota.Text = "Pagar cuota";
            pagarCuota.UseVisualStyleBackColor = false;
            pagarCuota.Click += PagarCuota_Click;
            // 
            // inscribirActividad
            // 
            inscribirActividad.BackColor = SystemColors.Highlight;
            inscribirActividad.FlatStyle = FlatStyle.Flat;
            inscribirActividad.Location = new Point(284, 131);
            inscribirActividad.Margin = new Padding(2);
            inscribirActividad.Name = "inscribirActividad";
            inscribirActividad.Size = new Size(172, 39);
            inscribirActividad.TabIndex = 4;
            inscribirActividad.Text = "Inscribir Actividad";
            inscribirActividad.UseVisualStyleBackColor = false;
            inscribirActividad.Click += InscribirActividad_Click;
            // 
            // btnListado
            // 
            btnListado.BackColor = Color.Firebrick;
            btnListado.FlatStyle = FlatStyle.Flat;
            btnListado.Location = new Point(165, 206);
            btnListado.Margin = new Padding(2);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(156, 46);
            btnListado.TabIndex = 5;
            btnListado.Text = "Clientes a cobrar";
            btnListado.UseVisualStyleBackColor = false;
            btnListado.Click += btnClientesACobrar_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(501, 310);
            Controls.Add(btnListado);
            Controls.Add(inscribirActividad);
            Controls.Add(pagarCuota);
            Controls.Add(lbUsuarioInfo);
            Controls.Add(agregarNoSocio);
            Controls.Add(agregarSocio);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button agregarSocio;
        private Button agregarNoSocio;
        private Label lbUsuarioInfo;
        private Button pagarCuota;
        private Button inscribirActividad;
        private Button btnListado;
    }
}