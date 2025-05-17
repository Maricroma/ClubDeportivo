using ProyectoClubDeportivo.Enums;

namespace ProyectoClubDeportivo.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public RolEnum Rol { get; set; }

        public Usuario() { }

        public Usuario(int id, string nombre, string clave, RolEnum rol)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
            Rol = rol;
        }
    }
}
