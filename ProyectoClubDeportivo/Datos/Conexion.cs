using MySql.Data.MySqlClient;

namespace ProyectoClubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            baseDatos = "clubdeportivo";
            servidor = "localhost";
            puerto = "3306";
            usuario = "root";
            clave = "";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + clave +
                ";Database=" + baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion(); 
            }
            return con;
        }
    }
}
