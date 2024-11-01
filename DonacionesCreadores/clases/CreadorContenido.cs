using DonacionesCreadores.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores.clases
{
    [Serializable]
    public class CreadorContenido : Usuario
    {
        public List<Contenido> Contenidos { get; set; }
        public bool CuentaBloqueada { get; set; }
        public List<string> Suscriptores { get; set; } // Guarda el id de los usuarios suscritos

        // Constructor vacío para serialización
        public CreadorContenido() : base()
        {
            Contenidos = new List<Contenido>();
            Suscriptores = new List<string>();
            CuentaBloqueada = false;
        }

        public CreadorContenido(string idUsuario, string nombre, string email, string contrasena)
            : base(idUsuario, nombre, email, contrasena)
        {
            Contenidos = new List<Contenido>();
            Suscriptores = new List<string>();
            CuentaBloqueada = false;
        }

        public void CrearContenido(string titulo, string descripcion, string imagePath)
        {
            try
            {
                if (CuentaBloqueada)
                {
                    Console.WriteLine("Cuenta bloqueada. No puedes crear contenido.");
                    return;
                }

                Contenido nuevoContenido = new Contenido(titulo, descripcion, this.Id, imagePath);
                Contenidos.Add(nuevoContenido);

                // Actualizamos la base de datos
                Dao.GuardarContenido(nuevoContenido);

                // Actualizamos los datos de CreadorContenido en la DB
                Dao.ActualizarCreadorContenido(this);
            }
            catch (Exception e)
            {
                // Propagamos la excepción
                throw e;
            }
        }

        // Metodo para agregar suscriptores
        public void AgregarSuscriptor(string idUsuario)
        {
            // Agregar el id del usuario a la lista de suscriptores
            Suscriptores.Add(idUsuario);

            // Actualizamos los datos de CreadorContenido en la DB
            Dao.ActualizarCreadorContenido(this);
        }

        // Metodo para eliminar suscriptores
        public void EliminarSuscriptor(string idUsuario)
        {
            // Eliminar el id del usuario de la lista de suscriptores
            Suscriptores.Remove(idUsuario);

            // Actualizamos los datos de CreadorContenido en la DB
            Dao.ActualizarCreadorContenido(this);
        }

        public void VerificarActividad()
        {
            // Verificar si ha creado al menos 3 contenidos por semana
            if (Contenidos.Count < 3)
            {
                CuentaBloqueada = true;
            }
        }

        public bool EsPartner()
        {
            // Lógica para verificar si es un "partner"
            return Suscriptores.Count >= 1000 && CalcularPromedioLikes() >= 500;
        }

        // Método para calcular el promedio de likes de los contenidos
        public double CalcularPromedioLikes()
        {
            double totalLikes = 0;
            foreach (Contenido contenido in Contenidos)
            {
                totalLikes += contenido.Likes.Count;
            }
            return Contenidos.Count > 0 ? totalLikes / Contenidos.Count : 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} CreadorContenido{{Contenidos={Contenidos.Count}, CuentaBloqueada={CuentaBloqueada}, Suscriptores={Suscriptores.Count}}}";
        }
    }
}
