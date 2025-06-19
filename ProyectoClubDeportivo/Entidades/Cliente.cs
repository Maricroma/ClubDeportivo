
namespace ProyectoClubDeportivo.Entidades
{
    public abstract class Cliente
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool FichaMedica { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public virtual bool Registrar()
        {
            // Lógica de registro
            return true;
        }

        public virtual bool Modificar()
        {
            // Lógica de modificación
            return true;
        }

        public virtual bool Eliminar()
        {
            // Lógica de eliminación
            return true;
        }

        public virtual string ConsultarDatos()
        {
            return $"ID: {Id}, Nombre: {Nombre} {Apellido}, DNI: {Dni}";
        }
    }
}
