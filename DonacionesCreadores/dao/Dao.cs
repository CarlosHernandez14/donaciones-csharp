using DonacionesCreadores.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DonacionesCreadores.dao
{
    public class Dao
    {
        public Dao() { }

        // Método para verificar si el usuario existe
        public static Usuario VerificarUsuario(string correo, string contrasena)
        {
            var usuarioDao = new GenericDao<Usuario>("usuario.json");
            List<Usuario> usuarios = usuarioDao.Cargar();

            foreach (var usuario in usuarios)
            {
                if (usuario.Correo == correo && usuario.Contrasena == Sha1Encrypt(contrasena))
                {
                    return usuario;
                }
            }

            // Verificación en creadores de contenido
            var creadorContenidoDao = new GenericDao<CreadorContenido>("creadorContenido.json");
            List<CreadorContenido> creadoresContenido = creadorContenidoDao.Cargar();

            foreach (var creador in creadoresContenido)
            {
                if (creador.Correo == correo && creador.Contrasena == Sha1Encrypt(contrasena))
                {
                    return creador;
                }
            }

            // Verificación en administradores
            var administradorDao = new GenericDao<Administrador>("administrador.json");
            List<Administrador> administradores = administradorDao.Cargar();

            foreach (var admin in administradores)
            {
                if (admin.Correo == correo && admin.Contrasena == Sha1Encrypt(contrasena))
                {
                    return admin;
                }
            }

            return null;
        }

        // Método para guardar un usuario
        public static void GuardarUsuario(Usuario usuario)
        {
            var usuarioDao = new GenericDao<Usuario>("usuario.json");
            List<Usuario> usuarios = usuarioDao.Cargar();
            usuario.Contrasena = Sha1Encrypt(usuario.Contrasena);
            usuarios.Add(usuario);
            usuarioDao.Guardar(usuarios);
        }

        // Método para guardar un creador de contenido
        public static void GuardarCreadorContenido(CreadorContenido creadorContenido)
        {
            var creadorDao = new GenericDao<CreadorContenido>("creadorContenido.json");
            List<CreadorContenido> creadores = creadorDao.Cargar();
            creadorContenido.Contrasena = Sha1Encrypt(creadorContenido.Contrasena);
            creadores.Add(creadorContenido);
            creadorDao.Guardar(creadores);
        }

        // Método para obtener un creador de contenido por ID
        public static CreadorContenido ObtenerCreadorContenido(string id)
        {
            var creadorDao = new GenericDao<CreadorContenido>("creadorContenido.json");
            List<CreadorContenido> creadores = creadorDao.Cargar();

            return creadores.Find(c => c.Id == id);
        }

        // Método para actualizar un creador de contenido
        public static void ActualizarCreadorContenido(CreadorContenido creadorContenido)
        {
            var creadorDao = new GenericDao<CreadorContenido>("creadorContenido.json");
            List<CreadorContenido> creadores = creadorDao.Cargar();

            for (int i = 0; i < creadores.Count; i++)
            {
                if (creadores[i].Id == creadorContenido.Id)
                {
                    creadores[i] = creadorContenido;
                    break;
                }
            }

            creadorDao.Guardar(creadores);
        }

        // Método para guardar un administrador
        public static void GuardarAdministrador(Administrador administrador)
        {
            var adminDao = new GenericDao<Administrador>("administrador.json");
            List<Administrador> administradores = adminDao.Cargar();
            administrador.Contrasena = Sha1Encrypt(administrador.Contrasena);
            administradores.Add(administrador);
            adminDao.Guardar(administradores);
        }

        // Método para guardar contenido
        public static void GuardarContenido(Contenido contenido)
        {
            var contenidoDao = new GenericDao<Contenido>("contenido.json");
            List<Contenido> contenidos = contenidoDao.Cargar();
            contenidos.Add(contenido);
            contenidoDao.Guardar(contenidos);
        }

        // Método para obtener todos los contenidos
        public static List<Contenido> ObtenerContenidos()
        {
            var contenidoDao = new GenericDao<Contenido>("contenido.json");
            return contenidoDao.Cargar();
        }

        // Método para actualizar contenido
        public static void ActualizarContenido(Contenido contenido)
        {
            var contenidoDao = new GenericDao<Contenido>("contenido.json");
            List<Contenido> contenidos = contenidoDao.Cargar();

            for (int i = 0; i < contenidos.Count; i++)
            {
                if (contenidos[i].Id == contenido.Id)
                {
                    contenidos[i] = contenido;
                    break;
                }
            }

            contenidoDao.Guardar(contenidos);
        }

        // Método para eliminar contenido
        public static void EliminarContenido(string idContenido)
        {
            var contenidoDao = new GenericDao<Contenido>("contenido.json");
            List<Contenido> contenidos = contenidoDao.Cargar();

            contenidos.RemoveAll(c => c.Id == idContenido);
            contenidoDao.Guardar(contenidos);
        }

        // Método para encriptar la contraseña en SHA1
        private static string Sha1Encrypt(string contrasena)
        {
            using (var sha1 = SHA1.Create())
            {
                byte[] data = sha1.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
                var sBuilder = new StringBuilder();
                foreach (var b in data)
                {
                    sBuilder.Append(b.ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}
