using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClubDeportivo.Datos
{
    internal class PagoActividadDAO
    {
        public static long InsertarPagoActividad(long clienteId, DateTime fecha, long actividadId)
        {
            MySqlConnection conexion = null;
            
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                string query = "INSERT INTO pagoactividad (ClienteId, Fecha, ActividadId) VALUES (@clienteId, @fecha, @actividadId)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    cmd.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@actividadId", actividadId);

                    cmd.ExecuteNonQuery();

                    return cmd.LastInsertedId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago de actividad: " + ex.Message);
            }
            
        }
    }
}
