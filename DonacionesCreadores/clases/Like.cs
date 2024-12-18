﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesCreadores.clases
{
    [Serializable]
    public class Like
    {
        public string IdUsuario { get; set; }
        public string IdContenido { get; set; }

        public Like() { }

        public Like(string idUsuario, string idContenido)
        {
            IdUsuario = idUsuario;
            IdContenido = idContenido;
        }

        public override string ToString()
        {
            return $"Like{{ IdUsuario={IdUsuario}, IdContenido={IdContenido} }}";
        }
    }
}
