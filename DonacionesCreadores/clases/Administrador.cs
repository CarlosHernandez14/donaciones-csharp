using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesCreadores.clases
{
    [Serializable]
    public class Administrador : Usuario
    {
        public Administrador(string id, string nombre, string email, string contrasena)
            : base(id, nombre, email, contrasena)
        {
        }

        public void EliminarContenido(Contenido contenido)
        {
            // Lógica para eliminar contenido
        }

        public void AsignarPartner(CreadorContenido creador)
        {
            if (creador.EsPartner())
            {
                // Lógica para asignar "partner"
            }
        }

        public void DescargarReportePDF()
        {
            // Lógica para descargar un PDF con los datos de los "partners"
        }

        public void DescargarReporteExcel()
        {
            // Lógica para descargar un Excel con los usuarios que reciben más donaciones
        }
    }
}
