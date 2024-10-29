using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores.clases
{
    [Serializable]
    public class Contenido
    {
        public string Id { get; private set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string IdCreador { get; private set; }
        public List<Visualizacion> Visualizaciones { get; set; }
        public List<Like> Likes { get; set; }
        public List<string> Comentarios { get; set; }
        public double Donaciones { get; private set; }
        public string ImagePath { get; set; }

        public Contenido(string titulo, string descripcion, string idCreador, string imagePath)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            IdCreador = idCreador;
            Visualizaciones = new List<Visualizacion>();
            Likes = new List<Like>();
            Comentarios = new List<string>();
            Donaciones = 0.0;
            ImagePath = imagePath;
            Id = GenerarId();
        }

        public Contenido(string id, string titulo, string descripcion, string idCreador,
                         List<Visualizacion> visualizaciones, List<Like> likes,
                         List<string> comentarios, double donaciones, string imagePath)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            IdCreador = idCreador;
            Visualizaciones = visualizaciones;
            Likes = likes;
            Comentarios = comentarios;
            Donaciones = donaciones;
            ImagePath = imagePath;
        }

        public void AgregarComentario(string comentario, Usuario usuario)
        {
            Comentarios.Add($"{usuario.Nombre}: {comentario}");
        }

        public void AgregarLike(string idUsuario, string idContenido)
        {
            var like = new Like(idUsuario, idContenido);
            Likes.Add(like);
            Dao.ActualizarContenido(this);
        }

        public void EliminarLike(string idUsuario, string idContenido)
        {
            Likes.RemoveAll(like => like.IdUsuario == idUsuario && like.IdContenido == idContenido);
            Dao.ActualizarContenido(this);
        }

        public void AgregarVisualizacion(string idUsuario)
        {
            var visualizacion = new Visualizacion(idUsuario, Id);
            Visualizaciones.Add(visualizacion);
            Dao.ActualizarContenido(this);
        }

        public void RecibirDonacion(double cantidad)
        {
            Donaciones += cantidad;
            Dao.ActualizarContenido(this);
        }

        public static string GenerarId()
        {
            var random = new Random();
            const string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";
            var id = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                id += letras[random.Next(letras.Length)];
                id += numeros[random.Next(numeros.Length)];
            }

            return id;
        }

        public override string ToString()
        {
            return $"Contenido {{ Titulo = {Titulo}, Descripcion = {Descripcion}, Creador = {IdCreador}, " +
                   $"Visualizaciones = {Visualizaciones.Count}, Likes = {Likes.Count}, Comentarios = {Comentarios.Count}, " +
                   $"Donaciones = {Donaciones} }}";
        }
    }
}
