
namespace ProyectoClubDeportivo.Entidades
{
    internal class Socio : Cliente
    {
        public bool Carnet { get; set; }
        public DateTime FechaProximoPago { get; set; }
        public List<Cuota> Cuotas { get; set; } = new List<Cuota>();

        public Socio(string nombre, string apellido, string dni, string telefono, string email, bool fichaMedica, bool carnet)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            Email = email;
            FichaMedica = fichaMedica;
            FechaInscripcion = DateTime.Now;
            FechaProximoPago = FechaInscripcion.AddMonths(1);
            Carnet = carnet;
        }

        public bool PagarCuota()
        {
            // Lógica de pago de cuota
            return true;
        }

        public bool SolicitarBaja()
        {
            // Lógica para solicitar baja
            return true;
        }

        public static List<Socio> ObtenerSociosConCuotaVencida(List<Socio> socios)
        {
            return socios.Where(s => s.FechaProximoPago < DateTime.Today).ToList();
        }
    }
}
