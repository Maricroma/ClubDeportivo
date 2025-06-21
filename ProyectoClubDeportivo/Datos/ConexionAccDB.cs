using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoClubDeportivo.Datos
{
    internal class ConexionAccDB
    {
        private readonly ConfiguracionConexion _config;

        public ConexionAccDB(ConfiguracionConexion config)
        {
            _config = config;
        }

        public MySqlConnection CrearConexion()
        {
            string cadena = $"server={_config.Servidor};port={_config.Puerto};user={_config.Usuario};password={_config.Clave};database={_config.BaseDatos};";

            return new MySqlConnection(cadena);
        }
    }
}
