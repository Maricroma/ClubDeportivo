using ProyectoClubDeportivo.Datos;
using ProyectoClubDeportivo.Entidades;
using ProyectoClubDeportivo.Presentacion;

namespace ProyectoClubDeportivo
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Si el texto está vacío, mostrar los placeholders
            lbUsuario.Visible = string.IsNullOrWhiteSpace(txtUsuario.Text);
            lbPass.Visible = string.IsNullOrWhiteSpace(txtPass.Text);
            txtPass.UseSystemPasswordChar = false; // para que no se vea como contraseña al inicio
            btnLogin.Select();

        }

        // ======== USUARIO ========
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            lbUsuario.Visible = false;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                lbUsuario.Visible = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lbUsuario.Visible = string.IsNullOrWhiteSpace(txtUsuario.Text) && !txtUsuario.Focused;
        }

        // ======== CONTRASEÑA ========
        private void txtPass_Enter(object sender, EventArgs e)
        {
            lbPass.Visible = false;
            txtPass.UseSystemPasswordChar = true;
            txtPass.ForeColor = Color.Black;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                lbPass.Visible = true;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lbPass.Visible = string.IsNullOrWhiteSpace(txtPass.Text) && !txtPass.Focused;
        }

        // USUARIO - al hacer clic en el placeholder
        private void lbUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            lbUsuario.Visible = false;
        }

        // CONTRASEÑA - al hacer clic en el placeholder
        private void lbPass_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            lbPass.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtPass.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Debe ingresar el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                List<Usuario> lista = dao.ObtenerUsuarios(usuario, clave);

                if (lista.Count > 0)
                {
                    // Usuario válido
                    Usuario usu = lista[0]; // Si querés usar sus datos
                    MessageBox.Show($"¡Bienvenido {usu.Nombre}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenu frm = new FormMenu();
                    this.Hide();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
