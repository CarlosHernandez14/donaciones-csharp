using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesCreadores.clases
{
    public class Visualizacion
    {
        public string IdUsuario { get; set; }
        public string IdContenido { get; set; }

        public Visualizacion(string idUsuario, string idContenido)
        {
            IdUsuario = idUsuario;
            IdContenido = idContenido;
        }

        public override string ToString()
        {
            return $"Visualizacion{{ IdUsuario={IdUsuario}, IdContenido={IdContenido} }}";
        }
    }
}
