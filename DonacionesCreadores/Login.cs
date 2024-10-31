using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
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
                    // Abrir el formulario de administrador
                    
                }
                else if (usuario is CreadorContenido)
                {
                    // Abrir el formulario de creador de contenido
                    HomeInfluencerForm homeInfluencerForm = new HomeInfluencerForm();
                    homeInfluencerForm.Show();
                    // Cerrar el formulario actual
                    this.Hide();
                }
                else
                {
                    // Abrir el formulario de usuario
                    HomeForm homeForm = new HomeForm();
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
