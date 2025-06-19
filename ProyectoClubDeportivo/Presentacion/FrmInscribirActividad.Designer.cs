namespace ProyectoClubDeportivo.Presentacion
{
    partial class FrmInscribirActividad
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
            dgvActividades = new DataGridView();
            lbLista = new Label();
            btnGridVolver = new Button();
            btnInscribir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.AllowUserToResizeColumns = false;
            dgvActividades.AllowUserToResizeRows = false;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.GridColor = SystemColors.Info;
            dgvActividades.Location = new Point(142, 64);
            dgvActividades.MultiSelect = false;
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.Size = new Size(504, 294);
            dgvActividades.TabIndex = 0;
            dgvActividades.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(329, 27);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(126, 15);
            lbLista.TabIndex = 1;
            lbLista.Text = "LISTA DE ACTIVIDADES";
            lbLista.TextAlign = ContentAlignment.TopCenter;
            lbLista.Click += label1_Click;
            // 
            // btnGridVolver
            // 
            btnGridVolver.Location = new Point(410, 380);
            btnGridVolver.Name = "btnGridVolver";
            btnGridVolver.Size = new Size(105, 36);
            btnGridVolver.TabIndex = 2;
            btnGridVolver.Text = "Volver";
            btnGridVolver.UseVisualStyleBackColor = true;
            btnGridVolver.Click += btnGridVolver_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.Highlight;
            btnInscribir.ForeColor = SystemColors.ControlLight;
            btnInscribir.Location = new Point(541, 380);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(105, 36);
            btnInscribir.TabIndex = 3;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // FrmInscribirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 428);
            Controls.Add(btnInscribir);
            Controls.Add(btnGridVolver);
            Controls.Add(lbLista);
            Controls.Add(dgvActividades);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmInscribirActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar Actividad";
            Load += FrmInscribirActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvActividades;
        private Label lbLista;
        private Button btnGridVolver;
        private Button btnInscribir;
    }
}