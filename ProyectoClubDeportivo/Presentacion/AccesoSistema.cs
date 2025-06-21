using ProyectoClubDeportivo.Datos;
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
    public partial class AccesoSistema : Form
    {
        public AccesoSistema()
        {
            InitializeComponent();
            // Establece los placeholders modernos
            txtServidor.PlaceholderText = "SERVIDOR";
            txtPuerto.PlaceholderText = "3000";
            txtUsuarioDB.PlaceholderText = "USUARIO DB";
            txtClaveDB.PlaceholderText = "CLAVE DB";
            txtClaveDB.UseSystemPasswordChar = true;

        }

        // --- Métodos Enter para borrar el placeholder ---

        private void txtServidor_Enter(object sender, EventArgs e)
        {
            // Solo borra el texto si es el placeholder.
            // Si el usuario ya escribió algo y luego vuelve a hacer clic, no queremos borrarlo.
            if (txtServidor.Text == "SERVIDOR")
            {
                txtServidor.Text = "";
            }
        }

        private void txtServidor_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            // Verifica si el campo está vacío (sin texto o solo espacios en blanco).

            if (string.IsNullOrWhiteSpace(txtServidor.Text))
            {
                txtServidor.Text = "SERVIDOR";
            }
        }

        private void txtPuerto_Enter(object sender, EventArgs e)
        {
            if (txtPuerto.Text == "3000")
            {
                txtPuerto.Text = "";
            }
        }

        private void txtPuerto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPuerto.Text))
            {
                txtPuerto.Text = "3000";  // se le asignó este valor por defecto
            }
        }

        private void txtUsuarioDB_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioDB.Text == "USUARIO DB")
            {
                txtUsuarioDB.Text = "";
            }
        }

        private void txtUsuarioDB_Leave(object sender, EventArgs e)
        {
            // este evento se ejecuta cuando se va el foco 
            if (string.IsNullOrWhiteSpace(txtUsuarioDB.Text))
            {
                txtUsuarioDB.Text = "USUARIO DB";
            }
        }

        private void txtClaveDB_Enter(object sender, EventArgs e)
        {
            if (txtClaveDB.Text == "CLAVE DB")
            {
                txtClaveDB.Text = "";
                txtClaveDB.UseSystemPasswordChar = true; // Asegura que se oculta la clave
            }
        }

        private void txtClaveDB_Leave(object sender, EventArgs e)
        {
            // este evento se ejecuta cuando se va el foco 
            if (string.IsNullOrWhiteSpace(txtClaveDB.Text))
            {
                txtClaveDB.Text = "CLAVE DB";
                txtClaveDB.UseSystemPasswordChar = false; // Muestra el placeholder como texto normal
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Lógica para conectarte a la base de datos usando los valores ingresados.
            string servidor = txtServidor.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuarioDB.Text;
            string clave = txtClaveDB.Text;


            // Validación mejorada: ignora placeholders
            if (servidor == "SERVIDOR" || string.IsNullOrWhiteSpace(servidor) ||
                puerto == "3000" || string.IsNullOrWhiteSpace(puerto) ||
                usuario == "USUARIO DB" || string.IsNullOrWhiteSpace(usuario) ||
                clave == "CLAVE DB" || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar los datos ingresados
            MessageBox.Show(
                $"Datos ingresados:\n" +
                $"Servidor: {servidor}\n" +
                $"Puerto: {puerto}\n" +
                $"Usuario: {usuario}\n" +
                $"Clave: {clave}\n",

                "Datos de Conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Crear la configuracion de conexión

            var config = new ConfiguracionConexion
            {
                Servidor = servidor,
                Puerto = puerto,
                Usuario = usuario,
                Clave = clave
                // BaseDatos tiene valor por defecto
            };

            try
            {
                var conexion = new ConexionAccDB(config);
                using (var conn = conexion.CrearConexion())
                {
                    conn.Open(); // Aquí se prueba la conexión real
                    MessageBox.Show("¡Conexión a la base de datos exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                // Se conecta al formulario de Inicio, si la conexión fue exitosa
                // new FormInicio().Show(); this.Hide();

                FormInicio login = new FormInicio(); // Reemplazá con el nombre real del formulario de login
                login.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}

