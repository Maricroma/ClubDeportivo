namespace ProyectoClubDeportivo.Presentacion
{
    partial class AccesoSistema
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
            lblAcceso = new Label();
            btnIngresar = new Button();
            lblServidor = new Label();
            lblPuerto = new Label();
            lblUsuarioDB = new Label();
            label1 = new Label();
            txtServidor = new TextBox();
            txtPuerto = new TextBox();
            txtUsuarioDB = new TextBox();
            txtClaveDB = new TextBox();
            SuspendLayout();
            // 
            // lblAcceso
            // 
            lblAcceso.AutoSize = true;
            lblAcceso.Location = new Point(315, 43);
            lblAcceso.Name = "lblAcceso";
            lblAcceso.Size = new Size(101, 15);
            lblAcceso.TabIndex = 0;
            lblAcceso.Text = "Acceso al Sistema";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(579, 323);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(175, 117);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(50, 15);
            lblServidor.TabIndex = 2;
            lblServidor.Text = "Servidor";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(177, 157);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 3;
            lblPuerto.Text = "Puerto";
            // 
            // lblUsuarioDB
            // 
            lblUsuarioDB.AutoSize = true;
            lblUsuarioDB.Location = new Point(174, 202);
            lblUsuarioDB.Name = "lblUsuarioDB";
            lblUsuarioDB.Size = new Size(73, 15);
            lblUsuarioDB.TabIndex = 4;
            lblUsuarioDB.Text = "Usuario (DB)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 243);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Clave (DB)";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(288, 117);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(100, 23);
            txtServidor.TabIndex = 6;
            txtServidor.Text = "SERVIDOR";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(289, 155);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 7;
            txtPuerto.Text = "3000";
            // 
            // txtUsuarioDB
            // 
            txtUsuarioDB.Location = new Point(289, 203);
            txtUsuarioDB.Name = "txtUsuarioDB";
            txtUsuarioDB.Size = new Size(100, 23);
            txtUsuarioDB.TabIndex = 8;
            txtUsuarioDB.Text = "Usuario DB";
            // 
            // txtClaveDB
            // 
            txtClaveDB.Location = new Point(291, 246);
            txtClaveDB.Name = "txtClaveDB";
            txtClaveDB.Size = new Size(100, 23);
            txtClaveDB.TabIndex = 9;
            txtClaveDB.Text = "Clave";
            // 
            // AccesoSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtClaveDB);
            Controls.Add(txtUsuarioDB);
            Controls.Add(txtPuerto);
            Controls.Add(txtServidor);
            Controls.Add(label1);
            Controls.Add(lblUsuarioDB);
            Controls.Add(lblPuerto);
            Controls.Add(lblServidor);
            Controls.Add(btnIngresar);
            Controls.Add(lblAcceso);
            Name = "AccesoSistema";
            Text = "AccesoSistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcceso;
        private Button btnIngresar;
        private Label lblServidor;
        private Label lblPuerto;
        private Label lblUsuarioDB;
        private Label label1;
        private TextBox txtServidor;
        private TextBox txtPuerto;
        private TextBox txtUsuarioDB;
        private TextBox txtClaveDB;
    }
}