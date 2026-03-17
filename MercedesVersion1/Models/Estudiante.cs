using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercedesVersion1.Models
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public string Instrumento { get; set; }
        public Profesor ProfesorAsignado { get; set; }
    }
}
