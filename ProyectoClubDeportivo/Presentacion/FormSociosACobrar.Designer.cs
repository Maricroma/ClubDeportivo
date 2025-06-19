namespace ProyectoClubDeportivo.Presentacion
{
    partial class FormSociosACobrar
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
            dgvSociosACobrar = new DataGridView();
            lblListado = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSociosACobrar).BeginInit();
            SuspendLayout();
            // 
            // dgvSociosACobrar
            // 
            dgvSociosACobrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSociosACobrar.Location = new Point(66, 67);
            dgvSociosACobrar.Name = "dgvSociosACobrar";
            dgvSociosACobrar.Size = new Size(670, 314);
            dgvSociosACobrar.TabIndex = 0;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListado.Location = new Point(164, 20);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(462, 30);
            lblListado.TabIndex = 1;
            lblListado.Text = "Clientes con vencimiento de cuota en la fecha";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Highlight;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(325, 400);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 39);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormSociosACobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblListado);
            Controls.Add(dgvSociosACobrar);
            Name = "FormSociosACobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes a cobrar";
            ((System.ComponentModel.ISupportInitialize)dgvSociosACobrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSociosACobrar;
        private Label lblListado;
        private Button btnVolver;
    }
}