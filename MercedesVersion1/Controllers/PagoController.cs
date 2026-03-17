using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MercedesVersion1.Models;

namespace MercedesVersion1.Controllers
{
    class PagoController
    {
        public static List<Pago> pagos = new List<Pago>();

        public static void RegistrarPago(Pago pago)
        {
            pagos.Add(pago);
        }

        public static List<Pago> ListarPagos()
        {
            return pagos;
        }
    }
}
