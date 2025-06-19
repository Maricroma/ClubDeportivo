using ProyectoClubDeportivo.Datos;
using ProyectoClubDeportivo.Entidades;

namespace ProyectoClubDeportivo.Presentacion
{
    public partial class FormAgregarSocio : Form
    {
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private RadioButton rbFichaSi;
        private RadioButton rbFichaNo;
        private RadioButton rbCarnetSi;
        private RadioButton rbCarnetNo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnVolver;
        private ErrorProvider errorProvider;


        public FormAgregarSocio()
        {
            InitializeComponent();
            InicializarControles();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.Load += FormAgregarSocio_Load;
        }

        private void InicializarControles()
        {
            this.Text = "Agregar Socio";
            this.Size = new Size(550, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(230, 245, 255); // Fondo celeste claro

            int labelWidth = 120;
            int textBoxWidth = 280;
            int leftMargin = 40;
            int topMargin = 40;
            int spacingY = 50;

            string[] labels = { "Nombre:", "Apellido:", "DNI:", "Teléfono:", "Email:" };
            TextBox[] textBoxes = new TextBox[labels.Length];

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label()
                {
                    Text = labels[i],
                    Location = new Point(leftMargin, topMargin + spacingY * i),
                    Width = labelWidth,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };
                this.Controls.Add(label);

                textBoxes[i] = new TextBox()
                {
                    Location = new Point(leftMargin + labelWidth + 10, topMargin + spacingY * i),
                    Width = textBoxWidth,
                    Height = 30,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };

                this.Controls.Add(textBoxes[i]);
            }

            txtNombre = textBoxes[0];
            txtApellido = textBoxes[1];
            txtDni = textBoxes[2];
            txtTelefono = textBoxes[3];
            txtEmail = textBoxes[4];

            GroupBox gbFicha = new GroupBox()
            {
                Text = "¿Presenta ficha médica?",
                Location = new Point(leftMargin, topMargin + spacingY * labels.Length + 10),
                Size = new Size(420, 70),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = Color.FromArgb(220, 235, 250)
            };

            rbFichaSi = new RadioButton()
            {
                Text = "Sí",
                Location = new Point(30, 30),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };
            rbFichaNo = new RadioButton()
            {
                Text = "No",
                Location = new Point(90, 30),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            gbFicha.Controls.Add(rbFichaSi);
            gbFicha.Controls.Add(rbFichaNo);
            this.Controls.Add(gbFicha);

            // Grupo Carnet
            GroupBox gbCarnet = new GroupBox()
            {
                Text = "Carnet Entregado",
                Location = new Point(leftMargin, gbFicha.Bottom + 10),
                Size = new Size(420, 70),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = Color.FromArgb(220, 235, 250)
            };

            rbCarnetSi = new RadioButton()
            {
                Text = "Sí",
                Location = new Point(30, 30),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };
            rbCarnetNo = new RadioButton()
            {
                Text = "No",
                Location = new Point(90, 30),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            gbCarnet.Controls.Add(rbCarnetSi);
            gbCarnet.Controls.Add(rbCarnetNo);
            this.Controls.Add(gbCarnet);

            // Botones
            int botonY = gbCarnet.Bottom + 25;
            int espacioX = 25;
            int botonAncho = 140;


            btnGuardar = new Button()
            {
                Text = "💾 Guardar",
                Location = new Point(leftMargin-10, botonY),
                Size = new Size(botonAncho, 45),
                BackColor = Color.FromArgb(30, 144, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Click += BtnGuardar_Click;
            this.Controls.Add(btnGuardar);

            btnLimpiar = new Button()
            {
                Text = "🧹 Limpiar",
                Location = new Point(btnGuardar.Right + espacioX, botonY),
                Size = new Size(botonAncho, 45),
                BackColor = Color.FromArgb(173, 216, 230), // celeste
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10)
            };
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.Click += BtnLimpiar_Click;
            this.Controls.Add(btnLimpiar);

            btnVolver = new Button()
            {
                Text = "↩️ Volver",
                Location = new Point(btnLimpiar.Right + espacioX, botonY),
                Size = new Size(botonAncho, 45),
                BackColor = Color.FromArgb(135, 206, 250), // celeste claro
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10)
            };
            btnVolver.FlatAppearance.BorderSize = 0;
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

            if (!rbCarnetSi.Checked && !rbCarnetNo.Checked)
            {
                errorProvider.SetError(rbCarnetNo, "Debe seleccionar una opción.");
                esValido = false;
            }

            return esValido;
        }


        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            bool fichaEntregada = rbFichaSi.Checked;
            bool carnetEntregado = rbCarnetSi.Checked;

            string respuesta;
            Socio socio = new Socio(nombre, apellido, dni, telefono, email, fichaEntregada, carnetEntregado);
            SocioDAO SocioDAO = new SocioDAO();
            respuesta = SocioDAO.AgregarSocio(socio);

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
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDni.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();

                    rbFichaSi.Checked = false;
                    rbFichaNo.Checked = false;
                    rbCarnetSi.Checked = false;
                    rbCarnetNo.Checked = false;
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
            rbCarnetSi.Checked = false;
            rbCarnetNo.Checked = false;
        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual y vuelve al menú
        }
    }
}
