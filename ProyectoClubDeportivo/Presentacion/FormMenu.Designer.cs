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
            SuspendLayout();
            // 
            // agregarSocio
            // 
            agregarSocio.BackColor = SystemColors.Highlight;
            agregarSocio.FlatStyle = FlatStyle.Flat;
            agregarSocio.Location = new Point(204, 92);
            agregarSocio.Name = "agregarSocio";
            agregarSocio.Size = new Size(351, 95);
            agregarSocio.TabIndex = 0;
            agregarSocio.Text = "Agregar Socio";
            agregarSocio.UseVisualStyleBackColor = false;
            agregarSocio.Click += AgregarSocio_Click;
            // 
            // agregarNoSocio
            // 
            agregarNoSocio.BackColor = SystemColors.Highlight;
            agregarNoSocio.FlatStyle = FlatStyle.Flat;
            agregarNoSocio.Location = new Point(204, 219);
            agregarNoSocio.Name = "agregarNoSocio";
            agregarNoSocio.Size = new Size(351, 95);
            agregarNoSocio.TabIndex = 1;
            agregarNoSocio.Text = "Agregar No Socio";
            agregarNoSocio.UseVisualStyleBackColor = false;
            agregarNoSocio.Click += AgregarNoSocio_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarNoSocio);
            Controls.Add(agregarSocio);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button agregarSocio;
        private Button agregarNoSocio;
    }
}