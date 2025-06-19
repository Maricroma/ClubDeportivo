using ProyectoClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;

namespace ProyectoClubDeportivo.Datos
{
    public class ClienteDAO
    {
        public static Cliente? BuscarPorDni(string dniCliente)
        {
            Cliente? cliente = null;
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                string query = "SELECT * FROM cliente WHERE dni = @dni";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@dni", dniCliente);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Int64 id = Convert.ToInt64(reader["Id"]);
                            string nombre = reader["Nombre"].ToString();
                            string apellido = reader["Apellido"].ToString();
                            string dni = reader["Dni"].ToString();
                            string telefono = reader["Telefono"].ToString();
                            string email = reader["Email"].ToString();

                            bool fichaMedica = Convert.ToBoolean(reader["FichaMedica"]);
                            DateTime fechaInscripcion = Convert.ToDateTime(reader["FechaInscripcion"]);
                            bool esSocio = Convert.ToBoolean(reader["EsSocio"]);

                            if (esSocio)
                            {
                                bool carnet = Convert.ToBoolean(reader["Carnet"]);
                                DateTime fechaProximoPago = Convert.ToDateTime(reader["FechaProximoPago"]);

                                cliente = new Socio(id, nombre, apellido, dni, telefono, email, fichaMedica, carnet)
                                {
                                    FechaInscripcion = fechaInscripcion,
                                    FechaProximoPago = fechaProximoPago
                                };
                            }
                            else
                            {
                                cliente = new NoSocio(id, nombre, apellido, dni, telefono, email, fichaMedica);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                    throw new Exception("Error al buscar el cliente por DNI: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

            return cliente;
        }

    }
}


