using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClubDeportivo.Datos
{
    internal class CuotaDAO
    {
        public static long InsertarPagoCuota(long clienteId, DateTime fecha, decimal precio, string formaPago)
        {
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                string query = "INSERT INTO cuota (ClienteId, Fecha, Precio, FormaPago) VALUES (@clienteId, @fecha, @precio, @formaPago)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    cmd.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@formaPago", formaPago);

                    cmd.ExecuteNonQuery();

                    return cmd.LastInsertedId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago de cuota: " + ex.Message);
            }
        }
    }
}
