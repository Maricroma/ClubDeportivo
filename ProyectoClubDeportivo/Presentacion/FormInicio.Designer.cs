namespace ProyectoClubDeportivo
{
    partial class FormInicio
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
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lbUsuario = new Label();
            lbPass = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(102, 54);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(141, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.ForeColor = SystemColors.WindowFrame;
            txtPass.Location = new Point(102, 101);
            txtPass.Margin = new Padding(2, 2, 2, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(141, 23);
            txtPass.TabIndex = 1;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(120, 166);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 26);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.BackColor = SystemColors.ControlLightLight;
            lbUsuario.ForeColor = SystemColors.GrayText;
            lbUsuario.Location = new Point(111, 57);
            lbUsuario.Margin = new Padding(2, 0, 2, 0);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(56, 15);
            lbUsuario.TabIndex = 3;
            lbUsuario.Text = "USUARIO";
            lbUsuario.Click += lbUsuario_Click;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.BackColor = SystemColors.ControlLightLight;
            lbPass.ForeColor = SystemColors.GrayText;
            lbPass.Location = new Point(111, 104);
            lbPass.Margin = new Padding(2, 0, 2, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(83, 15);
            lbPass.TabIndex = 4;
            lbPass.Text = "CONTRASEÑA";
            lbPass.Click += lbPass_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(353, 240);
            Controls.Add(lbPass);
            Controls.Add(lbUsuario);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnLogin;
        private Label lbUsuario;
        private Label lbPass;
    }
}