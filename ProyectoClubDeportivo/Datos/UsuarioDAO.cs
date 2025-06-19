using MySql.Data.MySqlClient;
using ProyectoClubDeportivo.Entidades;
using ProyectoClubDeportivo.Enums;
using System.Data;

namespace ProyectoClubDeportivo.Datos
{
    internal class UsuarioDAO
    {
        // creamos un metodo que retorne una tabla con la informacion
        public List<Usuario> ObtenerUsuarios(string nombre, string clave)
        {
            List<Usuario> lista = new List<Usuario>();
            MySqlConnection? sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("LoginUsuario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = clave;

                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = Convert.ToInt32(reader["CodUsu"]),
                        Nombre = reader["NombreUsu"].ToString(),
                        Clave = reader["PassUsu"].ToString(),
                        Rol = (RolEnum)Enum.Parse(typeof(RolEnum), reader["NomRol"].ToString())
                    };

                    lista.Add(usuario);
                }

                reader.Close();
                return lista;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public bool ValidarUsuario(string nombreUsuario, string clave)
        {
            bool resultado = false;
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE NombreUsu = @usuario AND PassUsu = @clave";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@clave", clave); // En la vida real, la clave debería estar hasheada

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                resultado = cantidad > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

    }
}
