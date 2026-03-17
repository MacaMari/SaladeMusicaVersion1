using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MercedesVersion1.Models;

namespace MercedesVersion1.Controllers
{
    class ProfesorController
    {
        public static List<Profesor> profesores = new List<Profesor>();

        public static void AgregarProfesor(Profesor profesor)
        {
            profesores.Add(profesor);
        }

        public static List<Profesor> ListarProfesores()
        {
            return profesores;
        }

        public static Profesor BuscarPorDni(string dni)
        {
            foreach (Profesor p in profesores)
            {
                if (p.DNI == dni)
                {
                    return p;
                }
            }

            return null;
        }
    }
}
