using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClubDeportivo.Entidades
{
    internal class Cuota
    {
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
        public string FormaPago { get; set; }

        public string VerDatos()
        {
            return $"Fecha: {Fecha.ToShortDateString()}, Precio: {Precio}, Forma de Pago: {FormaPago}";
        }
    }
}
