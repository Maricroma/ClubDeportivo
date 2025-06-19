using MySql.Data.MySqlClient;
using ProyectoClubDeportivo.Datos;
using System.Collections.Generic;
using System.Data;

internal class ActividadDAO
{
    public DataTable ObtenerActividades()
    {
        DataTable tabla = new DataTable();
        MySqlConnection sqlCon = null;

        try
        {
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("SELECT Id, Nombre, Precio FROM Actividad", sqlCon);
            sqlCon.Open();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(tabla);

            return tabla;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al obtener actividades: " + ex.Message);
            return null;
        }
        finally
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }
    }
}

