using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClubDeportivo.Entidades
{
    internal class Actividad
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public bool Crear()
        {
            // Lógica para crear actividad
            return true;
        }

        public bool Modificar()
        {
            // Lógica para modificar actividad
            return true;
        }

        public bool Eliminar()
        {
            // Lógica para eliminar actividad
            return true;
        }

        public string VerDatos()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Precio: {Precio}";
        }
    }
}
