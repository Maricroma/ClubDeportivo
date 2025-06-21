using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoClubDeportivo.Datos
{
    internal class ConfiguracionConexion
    {
        public string? Servidor { get; set; } = string.Empty;
        public string? Puerto { get; set; } = string.Empty; // Puerto por defecto vacío, se puede cambiar según la configuración del servidor
        public string? Usuario { get; set; } = string.Empty;
        public string? Clave { get; set; } = string.Empty;
        public string BaseDatos { get; set; } = "clubdeportivo"; // por defecto
    }
}
