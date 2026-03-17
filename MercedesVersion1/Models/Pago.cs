using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercedesVersion1.Models
{
    class Pago
    {
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
        public string FormaPago { get; set; }

        public Estudiante Estudiante { get; set; }
    }
}
