using MySql.Data.MySqlClient;
using ProyectoClubDeportivo.Entidades;
using System.Data;

namespace ProyectoClubDeportivo.Datos
{
    internal class NoSocioDAO
    {
        public string AgregarNoSocio(NoSocio noSocio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("AltaCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = noSocio.Dni;
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = noSocio.Telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = noSocio.Email;
                comando.Parameters.Add("FichaMedica", MySqlDbType.Bit).Value = noSocio.FichaMedica;
                comando.Parameters.Add("FechaInscripcion", MySqlDbType.Date).Value = noSocio.FechaInscripcion;
                comando.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = 0;
                comando.Parameters.Add("Carnet", MySqlDbType.Bit).Value = 0;
                comando.Parameters.Add("FechaProximoPago", MySqlDbType.Date).Value = null;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
            return salida;

        }
    }
}
