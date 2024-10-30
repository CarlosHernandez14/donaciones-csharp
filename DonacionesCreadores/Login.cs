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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


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
