using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void containerLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de los campos
            string name = fieldName.Text;
            string email = fieldEmail.Text;
            string password = fieldPassword.Text;
            string confirmPassword = fieldConfirmPassword.Text;

            // Obtenemos el valor del combo box
            string userType = comboInfluencer.Text;

            // Validamos que los campos no estén vacíos
            if (name == "" || email == "" || password == "" || confirmPassword == "" || userType == "")
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            // Validamos que las contraseñas coincidan
            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            // Validamos que el email sea válido
            if (!email.Contains("@"))
            {
                MessageBox.Show("Por favor, ingresa un email válido");
                return;
            }

            // Creamos un nuevo usuario de acuerdo al tipo de usuario seleccionado en el combo box
            // Si el usuario selecciona "CreadorConenido", creamos un nuevo CreadorContenido
            if (userType == "CreadorContenido")
            {
                CreadorContenido creadorContenido = new CreadorContenido(CreadorContenido.GenerarId() ,name, email, password);

                // Guardamos el creador de contenido en la base de datos
                try
                {
                    Dao.GuardarCreadorContenido(creadorContenido);
                } catch
                {
                    Console.WriteLine("Error al guardar el creador de contenido");
                    MessageBox.Show("Error al guardar el creador de contenido");
                    return;
                }
            } else if (userType == "Administrador")
            {
                // Si el usuario selecciona "Administrador", creamos un nuevo Administrador
                Administrador admin = new Administrador(Administrador.GenerarId(), name, email, password);

                // Guardamos el administrador en la base de datos
                try
                {
                    Dao.GuardarAdministrador(admin);
                }
                catch
                {
                    Console.WriteLine("Error al guardar el administrador");
                    MessageBox.Show("Error al guardar el administrador");
                    return;
                }
            } else if (userType == "Usuario")
            {
                // Si el usuario selecciona "Usuario", creamos un nuevo Usuario
                Usuario usuario = new Usuario(Usuario.GenerarId(), name, email, password);

                // Guardamos el usuario en la base de datos
                try
                {
                    Dao.GuardarUsuario(usuario);
                }
                catch
                {
                    Console.WriteLine("Error al guardar el usuario");
                    MessageBox.Show("Error al guardar el usuario");
                    return;
                }
            }

            // Mostramos un mensaje de éxito
            MessageBox.Show("Usuario registrado con éxito");

            // Cerramos la ventana actual
            this.Dispose();

            // Abrimos la ventana de login
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana de login
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            // Cerramos la ventana actual
            this.Dispose();
        }
    }
}
