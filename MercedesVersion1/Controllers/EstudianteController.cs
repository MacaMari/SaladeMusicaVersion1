using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MercedesVersion1.Models;

namespace MercedesVersion1.Controllers
{
    class EstudianteController
    {
        public static List<Estudiante> estudiantes = new List<Estudiante>();

        public static void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public static List<Estudiante> ListarEstudiantes()
        {
            return estudiantes;
        }

        public static Estudiante BuscarPorDni(string dni)
        {
            foreach (Estudiante e in estudiantes)
            {
                if (e.DNI == dni)
                {
                    return e;
                }
            }

            return null;
        }
    }
}
