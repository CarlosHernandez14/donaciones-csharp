using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
using DonacionesCreadores.vistas_admin;
using DonacionesCreadores.vistas_influencer;
using System.Diagnostics;

namespace DonacionesCreadores
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void containerForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de los campos
            string email = fieldEmail.Text;
            string password = fieldPassword.Text;

            // Validamos que los campos no estén vacíos
            if (email == "" || password == "")
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            // Validamos que el email sea válido
            if (!email.Contains('@'))
            {
                MessageBox.Show("Por favor, ingresa un email válido");
                return;
            }

            // Validamos que el email y la contraseña sean correctos
            try
            {
                Usuario usuario = Dao.VerificarUsuario(email, password);

                if (usuario == null) {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return;
                }

                // Verificamos el tipo de usuario
                if (usuario is Administrador)
                {
                    // Creamos el usuario como administrador
                    Administrador administrador = (Administrador)usuario;
                    // Abrimos el formulario de administrador
                    HomeAdminFrom homeAdminFrom = new HomeAdminFrom(administrador);
                    homeAdminFrom.Show();
                    // Cerramos el formulario actual
                    this.Hide();

                }
                else if (usuario is CreadorContenido)
                {
                    // Parseamos el usuario a CreadorContenido
                    CreadorContenido creadorContenido = (CreadorContenido)usuario;
                    // Abrir el formulario de creador de contenido
                    HomeInfluencerForm homeInfluencerForm = new HomeInfluencerForm(creadorContenido);
                    homeInfluencerForm.Show();
                    // Cerrar el formulario actual
                    this.Hide();
                }
                else
                {
                    // Abrir el formulario de usuario
                    HomeForm homeForm = new HomeForm(usuario);
                    homeForm.Show();
                    // Cerrar el formulario actual
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Error al iniciar sesión");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro
            SignUp signUp = new SignUp();
            signUp.Show();
            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
