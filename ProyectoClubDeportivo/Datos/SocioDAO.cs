using MySql.Data.MySqlClient;
using ProyectoClubDeportivo.Entidades;
using System.Data;

namespace ProyectoClubDeportivo.Datos
{
    internal class SocioDAO
    {
        public string AgregarSocio(Socio socio)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("AltaCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = socio.Dni;
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = socio.Telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = socio.Email;
                comando.Parameters.Add("FichaMedica", MySqlDbType.Bit).Value = socio.FichaMedica;
                comando.Parameters.Add("FechaInscripcion", MySqlDbType.Date).Value = socio.FechaInscripcion;
                comando.Parameters.Add("EsSocio", MySqlDbType.Bit).Value = 1;
                comando.Parameters.Add("Carnet", MySqlDbType.Bit).Value = socio.Carnet;
                comando.Parameters.Add("FechaProximoPago", MySqlDbType.Date).Value = socio.FechaProximoPago;
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
