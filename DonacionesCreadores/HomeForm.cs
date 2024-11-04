using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
using DonacionesCreadores.vistas_influencer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores
{
    public partial class HomeForm : Form
    {


        // Instancia de usuario
        private Usuario usuario;

        public HomeForm()
        {
            InitializeComponent();
        }

        // Constructor con parametros
        public HomeForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Cargamos los contenidos
            Load_Content();
        }

        // Function load content
        public void Load_Content()
        {
            // Cargamos todos los datos en el flow layout panel

            try
            {

                // Cargamos los contenidos
                List<Contenido> contenidos = Dao.ObtenerContenidos();


                // Limpiamos el flow layout panel
                flowLayoutPosts.Controls.Clear();

                // Recorremos los contenidos
                foreach (Contenido contenido in contenidos)
                {
                    // Creamos un nuevo control de contenido


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
                        HomeForm = this,
                        Usuario = usuario
                    };

                    // Agregamos el control al flow layout panel
                    flowLayoutPosts.Controls.Add(userControlContenido);

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al cargar los contenidos: " + ex.Message);
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
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
            // Abrimos el context menu en la posición del botón
            contextMenuStrip1.Show(buttonProfile, new Point(0, buttonProfile.Height));
        }
    }
}
