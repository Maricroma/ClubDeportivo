using ProyectoClubDeportivo.Datos;
using ProyectoClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClubDeportivo.Presentacion
{
    public partial class FormAgregarNoSocio : Form
    {
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private RadioButton rbFichaSi;
        private RadioButton rbFichaNo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnVolver;
        private ErrorProvider errorProvider;


        public FormAgregarNoSocio()
        {
            InitializeComponent();
            InicializarControles();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.Load += FormAgregarSocio_Load;
        }

        private void InicializarControles()
        {
            this.Text = "Agregar No Socio";
            this.Size = new Size(450, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            int labelWidth = 100;
            int textBoxWidth = 250;
            int leftMargin = 30;
            int topMargin = 30;
            int spacingY = 35;

            string[] labels = { "Nombre:", "Apellido:", "DNI:", "Teléfono:", "Email:" };
            TextBox[] textBoxes = new TextBox[labels.Length];

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label()
                {
                    Text = labels[i],
                    Location = new Point(leftMargin, topMargin + spacingY * i),
                    Width = labelWidth
                };
                this.Controls.Add(label);

                textBoxes[i] = new TextBox()
                {
                    Location = new Point(leftMargin + labelWidth + 10, topMargin + spacingY * i),
                    Width = textBoxWidth
                };
                this.Controls.Add(textBoxes[i]);
            }

            // Asignar a las variables de clase
            txtNombre = textBoxes[0];
            txtApellido = textBoxes[1];
            txtDni = textBoxes[2];
            txtTelefono = textBoxes[3];
            txtEmail = textBoxes[4];

            // Grupo Ficha Médica
            GroupBox gbFicha = new GroupBox()
            {
                Text = "¿Presenta ficha médica?",
                Location = new Point(leftMargin, topMargin + spacingY * labels.Length + 10),
                Size = new Size(380, 60)
            };

            rbFichaSi = new RadioButton()
            {
                Text = "Sí",
                Location = new Point(20, 25),
                AutoSize = true
            };
            rbFichaNo = new RadioButton()
            {
                Text = "No",
                Location = new Point(80, 25),
                AutoSize = true
            };

            gbFicha.Controls.Add(rbFichaSi);
            gbFicha.Controls.Add(rbFichaNo);
            this.Controls.Add(gbFicha);

            // Botones
            int botonY = gbFicha.Bottom + 40;
            int espacioX = 20;
            int botonAncho = 100;

            btnGuardar = new Button()
            {
                Text = "Guardar",
                Location = new Point(leftMargin, botonY),
                Size = new Size(botonAncho, 40),
                BackColor = SystemColors.Highlight,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Click += BtnGuardar_Click;
            this.Controls.Add(btnGuardar);

            btnLimpiar = new Button()
            {
                Text = "Limpiar",
                Location = new Point(btnGuardar.Right + espacioX, botonY),
                Size = new Size(botonAncho, 40)
            };
            btnLimpiar.Click += BtnLimpiar_Click;
            this.Controls.Add(btnLimpiar);

            btnVolver = new Button()
            {
                Text = "Volver",
                Location = new Point(btnLimpiar.Right + espacioX, botonY),
                Size = new Size(botonAncho, 40)
            };
            btnVolver.Click += BtnVolver_Click;
            this.Controls.Add(btnVolver);
        }

        private void FormAgregarSocio_Load(object? sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = SystemColors.Control;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private bool ValidarCampos()
        {
            bool esValido = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                errorProvider.SetError(txtDni, "El DNI es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider.SetError(txtTelefono, "El teléfono es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "El email es obligatorio.");
                esValido = false;
            }

            if (!rbFichaSi.Checked && !rbFichaNo.Checked)
            {
                errorProvider.SetError(rbFichaNo, "Debe seleccionar una opción.");
                esValido = false;
            }

            return esValido;
        }


        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Click detectado");  // 👈 Probar si el evento se dispara
            if (!ValidarCampos())
                return;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            bool fichaEntregada = rbFichaSi.Checked;

            string respuesta;
            NoSocio noSocio = new NoSocio(nombre, apellido, dni, telefono, email, fichaEntregada);
            NoSocioDAO noSocioDAO = new NoSocioDAO();
            respuesta = noSocioDAO.AgregarNoSocio(noSocio);
            MessageBox.Show("Respuesta de DAO: " + respuesta); // 👈 Verificás lo que devuelve

            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("CLIENTE N° " + respuesta + " AGREGADO.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                }
            }
        }
        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            rbFichaSi.Checked = false;
            rbFichaNo.Checked = false;
        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual y vuelve al menú
        }

        private void FormAgregarNoSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
