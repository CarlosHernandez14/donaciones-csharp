using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
using DonacionesCreadores.vistas_influencer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores.vistas_admin
{
    public partial class HomeAdminFrom : Form
    {

        // Usuario admin
        private Administrador admin;

        public HomeAdminFrom()
        {
            InitializeComponent();
        }

        public HomeAdminFrom(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Obtenemos el item clickeado
            ToolStripItem itemText = e.ClickedItem;


            // Verificamos si el item es el de cerrar sesión
            if (itemText != null)
            {
                if (itemText.Text == "Cerrar sesion")
                {
                    // Mostramos un mensaje de confirmación
                    DialogResult dialogResult = MessageBox.Show("¿Estás seguro de cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Mostramos el formulario de login
                        LoginForm login = new();
                        login.Show();
                        // Cerramos el formulario actual
                        this.Hide();
                    }
                }
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            // Abriremos el context menu strip en la posición del botón
            contextMenuStrip1.Show(buttonProfile, new Point(0, buttonProfile.Height));
        }

        private void HomeAdminFrom_Load(object sender, EventArgs e)
        {
            // Cargamos los contenidos
            CargarContenido();
        }

        // Funcion para cargar el contenido de los POST
        public void CargarContenido()
        {
            try
            {
                // Obtenemos los contenidos
                List<Contenido> contenidos = Dao.ObtenerContenidos();

                // Limpiamos el contenedor
                containerPosts.Controls.Clear();

                // Recorremos los contenidos
                foreach (Contenido contenido in contenidos)
                {
                    // Creamos un nuevo control de usuario
                    UserControlContenido userControlContenido = new()
                    {
                        // Asignamos los valores
                        Id = contenido.Id,
                        Titulo = contenido.Titulo,
                        Descripcion = contenido.Descripcion,
                        ImagePath = contenido.ImagePath,
                        IdCreador = contenido.IdCreador,
                        Donaciones = contenido.Donaciones,
                        LikeList = contenido.Likes,
                        VisualizacionesList = contenido.Visualizaciones,
                        CommentsList = contenido.Comentarios,
                        HomeAdminForm = this,
                        Usuario = admin
                    };

                    // Agregamos el control al flowLayoutPanel
                    containerPosts.Controls.Add(userControlContenido);
                }

                // Refrescamos el contenedor
                containerPosts.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contenidos: " + ex.Message);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Cargamos los influencers
            CargarInfluencers();
        }

        // Metodo para cargar influencers
        public void CargarInfluencers()
        {
            try
            {
                // Obtenemos los creadores de contenido
                List<CreadorContenido> creadores = Dao.ObtenerCreadoresContenido();

                // Limpiamos el contenedor
                containerPosts.Controls.Clear();

                // Recorremos los creadores
                foreach (CreadorContenido creador in creadores)
                {
                    // Creamos un nuevo control de usuario
                    UserControlUsuarios userControlUsuarios = new()
                    {
                        // Asignamos los valores
                        Influencer = creador,
                    };

                    // Agregamos el control al flowLayoutPanel
                    containerPosts.Controls.Add(userControlUsuarios);
                }

                // Refrescamos el contenedor
                containerPosts.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los creadores de contenido: " + ex.Message);
            }
        }

        private void btnPublicaciones_Click(object sender, EventArgs e)
        {
            // Cargamos los contenidos
            CargarContenido();
        }
    }
}
