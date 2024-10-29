using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesCreadores.clases
{
    [Serializable]
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Usuario()
        {
        }

        public Usuario(string id, string nombre, string correo, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
        }

        public Usuario(string nombre, string correo, string contrasena)
        {
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
        }

        // Algoritmo para generar un id aleatorio de 10 caracteres
        public static string GenerarId()
        {
            var id = "";
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int indice = random.Next(caracteres.Length);
                id += caracteres[indice];
            }
            return id;
        }

        public override string ToString()
        {
            return $"Usuario{{Id={Id}, Nombre={Nombre}, Correo={Correo}, Contrasena={Contrasena}}}";
        }
    }
}
