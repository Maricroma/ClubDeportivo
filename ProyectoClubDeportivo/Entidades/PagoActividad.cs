using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClubDeportivo.Entidades
{
    internal class PagoActividad
    {
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public Actividad Actividad { get; set; }

        public string VerDatos()
        {
            return $"ID: {Id}, Fecha: {Fecha.ToShortDateString()}, Actividad: {Actividad?.Nombre ?? "Sin nombre"}";
        }
    }
}
