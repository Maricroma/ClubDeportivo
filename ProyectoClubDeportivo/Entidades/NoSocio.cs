
namespace ProyectoClubDeportivo.Entidades
{
    internal class NoSocio : Cliente
    {
        public List<Actividad> Actividades { get; set; } = new List<Actividad>();
        public List<PagoActividad> PagosActividades { get; set; } = new List<PagoActividad>();


        public NoSocio(Int64 id, string nombre, string apellido, string dni, string telefono, string email, bool fichaMedica)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            Email = email;
            FichaMedica = fichaMedica;
            FechaInscripcion = DateTime.Now;
        }

        public NoSocio(string nombre, string apellido, string dni, string telefono, string email, bool fichaMedica)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            Email = email;
            FichaMedica = fichaMedica;
            FechaInscripcion = DateTime.Now;
        }

        public NoSocio()
        {
        }

        public bool PagarActividad()
        {
            // Lógica de pago de actividad
            return true;
        }
    }
}
